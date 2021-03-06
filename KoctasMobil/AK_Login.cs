using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;
using Microsoft.Win32;
using System.Threading;

namespace KoctasMobil
{
    public partial class AK_Login : Form
    {
        [DllImport("coredll.dll")]
        private extern static void GetSystemTime(ref SYSTEMTIME lpSystemTime);

        [DllImport("coredll.dll")]
        private extern static uint SetSystemTime(ref SYSTEMTIME lpSystemTime);

        [DllImport("coredll.dll", EntryPoint = "GetTimeZoneInformation")]
        internal static extern UInt32 GetTimeZoneInformation(ref TIME_ZONE_INFORMATION TZI);

        [DllImport("coredll.dll", EntryPoint = "SetTimeZoneInformation")]
        internal static extern UInt32 SetTimeZoneInformation(ref TIME_ZONE_INFORMATION TZI);

        public struct SYSTEMTIME
        {
            public ushort wYear;
            public ushort wMonth;
            public ushort wDayOfWeek;
            public ushort wDay; public ushort wHour;
            public ushort wMinute;
            public ushort wSecond;
            public ushort wMilliseconds;
        }

        public struct STRING
        {
            public char char0;
            public char char1;
            public char char2;
            public char char3;
            public char char4;
            public char char5;
            public char char6;
            public char char7;
            public char char8;
            public char char9;
            public char char10;
            public char char11;
            public char char12;
            public char char13;
            public char char14;
            public char char15;
            public char char16;
            public char char17;
            public char char18;
            public char char19;
            public char char20;
            public char char21;
            public char char22;
            public char char23;
            public char char24;
            public char char25;
            public char char26;
            public char char27;
            public char char28;
            public char char29;
            public char char30;
            public char char31;

            public override String ToString()
            {
                char[] temp = new char[32];
                temp[0] = char0;
                temp[1] = char1;
                temp[2] = char2;
                temp[3] = char3;
                temp[4] = char4;
                temp[5] = char5;
                temp[6] = char6;
                temp[7] = char7;
                temp[8] = char8;
                temp[9] = char9;
                temp[10] = char10;
                temp[11] = char11;
                temp[12] = char12;
                temp[13] = char13;
                temp[14] = char14;
                temp[15] = char15;
                temp[16] = char16;
                temp[17] = char17;
                temp[18] = char18;
                temp[19] = char19;
                temp[20] = char20;
                temp[21] = char21;
                temp[22] = char22;
                temp[23] = char23;
                temp[24] = char24;
                temp[25] = char25;
                temp[26] = char26;
                temp[27] = char27;
                temp[28] = char28;
                temp[29] = char29;
                temp[30] = char30;
                temp[31] = char31;

                // The string constructor for char[] will create a string of a length of 32 that contains embedded nulls
                // find the first original null (if one exists) and ensure that it doesn't get embedded into the returned string.

                int iLen = 0;
                for (int i = 0; i < 32; i++)
                {
                    if ('\0' == temp[i])
                    {
                        iLen = i;
                        break;
                    }
                }

                String sRetVal = new String(temp, 0, iLen);
                return sRetVal;
            }
        }

        public struct TIME_ZONE_INFORMATION
        {
            public int Bias;
            public STRING StandardName;
            public SYSTEMTIME StandardDate;
            public int StandardBias;
            public STRING DaylightName;
            public SYSTEMTIME DaylightDate;
            public int DaylightBias;

            public override Boolean Equals(Object obj)
            {
                if (!(obj is TIME_ZONE_INFORMATION))
                    return false;

                TIME_ZONE_INFORMATION t1 = (TIME_ZONE_INFORMATION)obj;
                if (this.Bias != t1.Bias
                || !this.StandardDate.Equals(t1.StandardDate)
                || this.StandardBias != t1.StandardBias
                || !this.DaylightDate.Equals(t1.DaylightDate)
                || this.DaylightBias != t1.DaylightBias
                )
                    return false;

                return true;

            }

            public override Int32 GetHashCode()
            {
                return Bias;
            }

            public override String ToString()
            {
                String str1 = String.Format("Bias: {0}, StdName: {1}, StdDate: {2}, StdBias: {3}, DayName: {4}, DayDate: {5}, DayBias: {6}", Bias, StandardName, StandardDate, StandardBias, DaylightName, DaylightDate, DaylightBias);
                return str1;
            }

        } // public struct TIME_ZONE_INFORMATION

        string osession = "";
        string mUserNo = "MOBIL";

        public AK_Login()
        {
            InitializeComponent();
            try
            {
                //Utility.HideTaskbar();
            }
            catch (Exception ex )
            {
                
            }
            
        }       
        
        private void btnCikis_Click(object sender, EventArgs e)
        {
            //if (Txt_Password.Text == "symbol")
            //{ } 
            try
            {
                Utility.ShowTaskbar();
            }
            catch (Exception ex)
            {
            }
            //Application.Exit();      
            this.Close();    
        }

        private void txt_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Txt_Password.Focus();
            }
        }

        private void Txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
				btn_giris_Click(new object(),new EventArgs());
				//Giris();
            }
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {

            if (txt_UserName.Text.Trim() == "")
            {
                return;
            }
            if (Txt_Password.Text.Trim() == "")
            {
                return;
            }

            //Eğer güvenli mod girişi var ise
            if (txt_UserName.Text.Trim() == ProgramGlobalData.modUser)
            {
                if ((txt_UserName.Text.ToString().Trim() == ProgramGlobalData.modUser) && (Txt_Password.Text.ToString().Trim() == ProgramGlobalData.modPass))
                {
                    cmbSunucu.Enabled = true;
                    MessageBox.Show("Günveli mod aktif edildi", "BİLGİ");
                    txt_UserName.Text = "";
                    Txt_Password.Text = "";
                    ProgramGlobalData.guvenliMod = true;
                }
                return;
            }

            Utility.setSunucu(cmbSunucu.Text);
            ProgramGlobalData.sunucuTip = cmbSunucu.Text;
            
            
            Cursor.Current = Cursors.WaitCursor;

            // Check NEW VERSION
            //int retVal = Utility.CheckNewVersion();
            int retVal = 0;
            Invalidate();
            Cursor.Current = Cursors.Default;
            //if (retVal < 0) return; // On Error
            
            if (retVal == 1)      // Found new version
            {
                try
                {
                    Utility.LaunchLauncher();
                }
                catch (Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Otomatik güncelleme uygulaması çalıştırılamadı.");
                    return;
                }
                
                Application.DoEvents();
                this.Close();
                Application.Exit();
                return;
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                bool logged = false;
                System.Net.NetworkCredential cr = new System.Net.NetworkCredential(txt_UserName.Text.Trim(), Txt_Password.Text.Trim());
                //Program.username = txt_UserName.Text.Trim();
                Txt_Password.Text = "";

                WS_Login.service srv = new KoctasMobil.WS_Login.service();
                WS_Login.ZkmobilReturn[] t_return = new KoctasMobil.WS_Login.ZkmobilReturn[1];
                WS_Login.ZktmobilLogin login = new KoctasMobil.WS_Login.ZktmobilLogin();
                WS_Login.ZktmobilLoginResponse resp = new KoctasMobil.WS_Login.ZktmobilLoginResponse();

                t_return[0] = new KoctasMobil.WS_Login.ZkmobilReturn();

                login.TReturn = t_return;
                resp.TReturn = t_return;
                srv.Credentials = cr;
                //if (Program.canlı)
                //{
                //    srv.Url = "http://212.115.6.165:8000/sap/bc/srt/rfc/sap/zktmobil_login/500/zktmobil_login/zktmobil_login";
                //}
                //else
                //{
                //    srv.Url = "http://212.115.6.172:8000/sap/bc/srt/rfc/sap/zktmobil_login/500/zktmobil_login/zktmobil_login";
                //}
                srv.Url = Utility.getWsUrl("zktmobil_login");


                try
                {
                    resp = srv.ZktmobilLogin(login);
                    if (resp.TReturn.Length > 0 && resp.TReturn[0].RcCode.ToUpper() == "S")
                    {
                        logged = true;
                        ProgramGlobalData.loginWerks = resp.EWerks.ToString();
                        ProgramGlobalData.loginMagnet = resp.EMagnet.ToString();
                    }
                    else
                    {
                        logged = false;
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message == "WebException")
                    {
                        MessageBox.Show("Kullanıcı adı / Şifre hatalı.", "Giriş Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    }
                    logged = false;
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }

                if (logged)
                {
                    ProgramGlobalData.username = txt_UserName.Text.Trim().ToUpper();
                    ProgramGlobalData.g_credential = cr;
                    frm_Menu frm = new frm_Menu();

                    TIME_ZONE_INFORMATION tzI = new TIME_ZONE_INFORMATION();
                    GetTimeZoneInformation(ref tzI);
                    
                    tzI.Bias = -120;
                    SetTimeZoneInformation(ref tzI);
                    DateTime to_set = Convert.ToDateTime(resp.ETarih + " " + resp.ESaat);
                    to_set -= new TimeSpan(2, 0, 0);
                    SetCurrentDate(to_set);

                    
                    

                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.Abort)
                    {
                        this.Close();
                    }
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void SetCurrentDate(DateTime dt)
        {            
            SYSTEMTIME sysTime = new SYSTEMTIME();
            sysTime.wYear = Convert.ToUInt16(dt.Year);
            sysTime.wDay = Convert.ToUInt16(dt.Day);
            sysTime.wDayOfWeek = (UInt16)dt.DayOfWeek;
            sysTime.wHour = Convert.ToUInt16(dt.Hour);
            sysTime.wSecond = Convert.ToUInt16(dt.Second);
            sysTime.wMinute = Convert.ToUInt16(dt.Minute);
            sysTime.wMonth = Convert.ToUInt16(dt.Month);
            sysTime.wMilliseconds = Convert.ToUInt16(dt.Millisecond);

            SetSystemTime(ref sysTime);

        }

        private void AK_Login_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lblVer.Text = "v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            cmbSunucu.Text = ProgramGlobalData.sunucuTip;
            lbl_Canli.Text = "Sistemine bağlanıyorsunuz...";

  
            /*
            if (Program.canli)
            {
                lbl_Canli.Text = "Canlı sisteme bağlanıyorsunuz.";
            }
            else
            {
                lbl_Canli.Text = "Test sisteme bağlanıyorsunuz.";
            }*/
        }

        private void btn_Satis_Click(object sender, EventArgs e)
        {

        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {

        }

        private void lblVer_ParentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmPalet = new frm_PaletMalKabul();

            frmPalet.ShowDialog();
        }      
    }
}