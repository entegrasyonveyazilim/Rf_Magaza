using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Data.Common;
using System.IO;
using System.Text;

namespace KoctasMobil
{
    public class SignatureControl : Control
    {
        // gdi objects
        Bitmap _bmp;

        public Bitmap Bmp
        {
            get { return _bmp; }
            set 
            { 
                _bmp = value;
                _graphics = Graphics.FromImage(_bmp);
            }
        }
        Graphics _graphics;
        Pen _pen = new Pen(Color.Black);

        // list of line segments
        ArrayList _lines = new ArrayList();

        // the current line segment
        ArrayList _points = new ArrayList();
        Point _lastPoint = new Point(0, 0);

        // if drawing signature or not
        bool _collectPoints = false;

        // notify parent that line segment was updated
        public event EventHandler SignatureUpdate;


        /// <summary>
        /// List of signature line segments.
        /// </summary>
        public ArrayList Lines
        {
            get { return _lines; }
        }

        /// <summary>
        /// Return the signature flattened to a stream of bytes.
        /// </summary>
        //public byte[] SignatureBits
        //{
        //get { return SignatureData.GetBytes(this.Width, this.Height, _lines); }
        //}

        public SignatureControl()
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // blit the memory bitmap to the screen
            // we draw on the memory bitmap on mousemove so there
            // is nothing else to draw at this time (the memory 
            // bitmap already contains all of the lines)
            CreateGdiObjects();
            e.Graphics.DrawImage(_bmp, 0, 0);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // don't pass to base since we paint everything, avoid flashing
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            // process if currently drawing signature
            if (!_collectPoints)
            {
                // start collecting points
                _collectPoints = true;

                // use current mouse click as the first point
                _lastPoint.X = e.X;
                _lastPoint.Y = e.Y;

                // this is the first point in the list
                _points.Clear();
                _points.Add(_lastPoint);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            // process if drawing signature
            if (_collectPoints)
            {
                // stop collecting points
                _collectPoints = false;

                // add current line to list of segments
                Point[] points = new Point[_points.Count];
                for (int i = 0; i < _points.Count; i++)
                {
                    Point pt = (Point)_points[i];
                    points[i].X = pt.X;
                    points[i].Y = pt.Y;
                }

                _lines.Add(points);

                // start over with a new line
                _points.Clear();

                // notify container a new segment was added
                RaiseSignatureUpdateEvent();
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            // process if drawing signature
            if (_collectPoints)
            {
                // add point to current line segment
                _points.Add(new Point(e.X, e.Y));

                // draw the new segment on the memory bitmap
                _graphics.DrawLine(_pen, _lastPoint.X, _lastPoint.Y, e.X, e.Y);

                // update the current position
                _lastPoint.X = e.X;
                _lastPoint.Y = e.Y;

                // display the updated bitmap
                Invalidate();
            }
        }

        /// <summary>
        /// Clear the signature.
        /// </summary>
        public void Clear()
        {
            _lines.Clear();
            InitMemoryBitmap();
            Invalidate();
        }

        public MemoryStream GetStream()
        {
            MemoryStream s = new MemoryStream();
            _bmp.Save(s, System.Drawing.Imaging.ImageFormat.Bmp);
            return s;
        }

        public string GetBytes()
        {
            MemoryStream ms = new MemoryStream();
            _bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bsig = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(bsig, 0, Convert.ToInt32(ms.Length));
            //_bmp.Save("\\Program Files\\KoctasMobil\\saved.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            System.Text.StringBuilder hexString = new StringBuilder(bsig.Length);
            for (int i = 0; i < bsig.Length; i++)
            {
                hexString.Append(bsig[i].ToString("X2"));
            }
            return hexString.ToString();           
        }

        public static string GetBytes(Bitmap _bmp)
        { 
            MemoryStream ms = new MemoryStream();
            _bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] bsig = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(bsig, 0, Convert.ToInt32(ms.Length));
            //_bmp.Save("\\Program Files\\KoctasMobil\\saved.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            System.Text.StringBuilder hexString = new StringBuilder(bsig.Length);
            for (int i = 0; i < bsig.Length; i++)
            {
                hexString.Append(bsig[i].ToString("X2"));
            }
            return hexString.ToString();
        }

        /// <summary>
        /// Create any GDI objects required to draw signature.
        /// </summary>
        private void CreateGdiObjects()
        {
            // only create if don't have one or the size changed
            if (_bmp == null || _bmp.Width != this.Width || _bmp.Height != this.Height)
            {
                // memory bitmap to draw on
                InitMemoryBitmap();
            }
        }

        /// <summary>
        /// Create a memory bitmap that is used to draw the signature.
        /// </summary>
        private void InitMemoryBitmap()
        {
            // load the background image
            //_bmp = Global.LoadImage("sign here.png");
            //_bmp = new Bitmap(100, 100);
            _bmp = new Bitmap("\\Program Files\\KoctasMobil\\sign.BMP");
            
            // get graphics object now to make drawing during mousemove faster
            _graphics = Graphics.FromImage(_bmp);
        }

        /// <summary>
        /// Notify container that a line segment has been added.
        /// </summary>
        private void RaiseSignatureUpdateEvent()
        {
            if (this.SignatureUpdate != null)
                SignatureUpdate(this, EventArgs.Empty);
        }

        public static Bitmap ResizePicture(Bitmap image, Size maxSize)
        {
            if (image == null)
                throw new ArgumentNullException("image", "Null passed to ResizePictureToMaximum");

            if ((image.Width > maxSize.Width) || (image.Height > maxSize.Height))
            {
                Bitmap resizedImage = new Bitmap(maxSize.Width, maxSize.Height);

                using (Graphics graphics = Graphics.FromImage(resizedImage))
                {
                    graphics.Clear(Color.White);

                    float widthRatio = maxSize.Width / image.Width;
                    float heightRatio = maxSize.Height / image.Height;

                    int width = maxSize.Width;
                    int height = maxSize.Height;

                    if (widthRatio > heightRatio)
                    {
                        width = (int)Math.Ceiling(maxSize.Width * heightRatio);
                    }
                    else if (heightRatio > widthRatio)
                    {
                        height = (int)Math.Ceiling(maxSize.Height * widthRatio);                        
                    }
                    graphics.DrawImage(image,  new Rectangle(0, 0, width, height), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
                }
                return resizedImage;
            }
            return image;
        }
    }
}
