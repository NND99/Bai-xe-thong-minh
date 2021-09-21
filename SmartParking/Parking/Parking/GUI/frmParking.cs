using System;
using System.Collections.Generic;
using System.ComponentModel;
using Parking.DAL;
using Parking.DTO;
using Parking.GUI;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class frmParking : Form
    {
        private string textValue = "";
        private string realtime = "";

        private AccountDTO getAccountInfo;
        public AccountDTO GetAccountInfo
        {
            get { return getAccountInfo; }
            set { getAccountInfo = value; }
        }

        public frmParking(AccountDTO info)
        {
            InitializeComponent();

            this.getAccountInfo = info;
            if (GetAccountInfo.Type.Equals("Nhân viên") == true)
            {
                btnAdmin.Visible = false;
            }

            lbFullname.Text = GetAccountInfo.Fullname;

        }

        private void frmParking_Load(object sender, EventArgs e)
        {
            bgwParking.WorkerReportsProgress = true;
            bgwParking.WorkerSupportsCancellation = true;



            if (bgwParking.IsBusy != true)
            {
                // Start the asynchronous operation.
                bgwParking.RunWorkerAsync();
            }

        }

        private void bgwParking_DoWork(object sender, DoWorkEventArgs e)
        {
            String location = @"D:\GITHUB\nguyenduyen2210-nd2610\nguyenduyen2210-nd2610\SmartParking\Readtxt\parktext.txt";
            if (File.Exists(location))
            {
                try
                {

                    while (textValue == "")
                    {
                        StreamReader sr = new StreamReader(location);

                        string line = sr.ReadLine();
                        while (line != null)
                        {
                            bgwParking.CancelAsync();

                            textValue = line;
                            line = sr.ReadLine();
                        }

                        sr.Close();
                        StreamWriter sw = new StreamWriter(location);
                        sw.Write("");
                        sw.Close();


                        if (textValue == "")
                        {
                            System.Threading.Thread.Sleep(1000);
                        }

                    }

                }
                catch { }
            }

        }

        private void bgwParking_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {

                ParkingDTO getPark = Parking_GDAO.Instance.getParkingByID(textValue);

                realtime = DateTime.Now.ToString("yyyy-M-dd HH:mm:ss");

                if (textValue != null)
                {
                    txtcardID.Text = textValue;
                    txtTime.Text = realtime;
                    txtType.Text = "THẺ KHÁCH";
                    txtStatus.Text = "XE VÀO";

                    Bitmap myImg;

                    string directory = @"D:\GITHUB\nguyenduyen2210-nd2610\nguyenduyen2210-nd2610\SmartParking\Images\";

                    int id = Int32.Parse(textValue[textValue.Length - 1].ToString()) + Int32.Parse(textValue[textValue.Length - 2].ToString());

                    directory = directory + id.ToString() + ".png";

                    myImg = new Bitmap(directory);

                    ptImage.ClientSize = new Size(myImg.Width, myImg.Height);

                    ptImage.Image = (Image)myImg;


                    if (getPark != null)
                    {

                        if (getPark.Type.ToString().Equals("THẺ KHÁCH") == true && getPark.Status.ToString().Equals("XE VÀO") == true)
                        {
                            txtcardID.Text = getPark.CardID;
                            txtTime.Text = DateTime.Parse(getPark.Time).ToString("yyyy-M-dd HH:mm:ss");
                            txtStatus.Text = getPark.Status.ToString();
                            txtType.Text = "THẺ KHÁCH";
                            ptImage.ClientSize = new Size(myImg.Width, myImg.Height);
                            ptImage.Image = (Image)myImg;

                            txtCardIDOut.Text = textValue;
                            txtTimeOut.Text = realtime;
                            txtStatusOut.Text = "XE RA";
                            txtTypeOut.Text = "THẺ KHÁCH";
                            ptImageOut.ClientSize = new Size(myImg.Width, myImg.Height);
                            ptImageOut.Image = (Image)myImg;
                        }

                        else

                        if (getPark.Type.ToString().Equals("THẺ THÁNG") == true && getPark.Status.ToString().Equals("XE VÀO") == true)
                        {
                            txtcardID.Text = getPark.CardID; 
                            txtTime.Text = DateTime.Parse(getPark.Time).ToString("yyyy-M-dd HH:mm:ss");
                            txtStatus.Text = getPark.Status;
                            txtType.Text = "THẺ THÁNG";
                            ptImage.ClientSize = new Size(myImg.Width, myImg.Height);
                            ptImage.Image = (Image)myImg;

                            txtCardIDOut.Text = getPark.CardID;
                            txtTimeOut.Text = realtime;
                            txtStatusOut.Text = "XE RA";
                            txtTypeOut.Text = "THẺ THÁNG";
                            ptImageOut.ClientSize = new Size(myImg.Width, myImg.Height);
                            ptImageOut.Image = (Image)myImg;

                        }

                        else

                        if (getPark.Type.ToString().Equals("THẺ THÁNG") == true && getPark.Status.ToString().Equals("XE RA") == true)
                        {
                            txtCardIDOut.Text = getPark.CardID;
                            txtTimeOut.Text = DateTime.Parse(getPark.Time).ToString("yyyy-M-dd HH:mm:ss");
                            txtStatusOut.Text = getPark.Status;
                            txtTypeOut.Text = getPark.Type;
                            ptImageOut.ClientSize = new Size(myImg.Width, myImg.Height);
                            ptImageOut.Image = (Image)myImg;

                            txtcardID.Text = getPark.CardID;
                            txtTime.Text = realtime;
                            txtStatus.Text = "XE VÀO";
                            txtType.Text = getPark.Type;
                            ptImage.ClientSize = new Size(myImg.Width, myImg.Height);
                            ptImage.Image = (Image)myImg;
                        }

                    }

                }

                else
                {
                    MessageBox.Show("Không quét được thẻ", "Lỗi");
                }

            }
            catch { }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

   
            ParkingDTO getPark = Parking_GDAO.Instance.getParkingByID(textValue);
            realtime = DateTime.Now.ToString("yyyy-M-dd HH:mm:ss");
            double money = 0;

            if (textValue != null)
            {
                int id = Int32.Parse(textValue[textValue.Length - 1].ToString()) + Int32.Parse(textValue[textValue.Length - 2].ToString());

                Bitmap myImg;

                string directory = @"D:\GITHUB\nguyenduyen2210-nd2610\nguyenduyen2210-nd2610\SmartParking\Images\";

                directory = directory + id.ToString() + ".png";

                myImg = new Bitmap(directory);

                if (getPark == null)
                {

                    txtcardID.Text = textValue;
                    txtTime.Text = realtime;
                    txtStatus.Text = "XE VÀO";
                    txtType.Text = "THẺ KHÁCH";
                    ptImage.ClientSize = new Size(myImg.Width, myImg.Height);
                    ptImage.Image = (Image)myImg;

                    MessageBox.Show("Thêm vé thành công", "Thành Công");

                    ParkingDTO myParking = new ParkingDTO(txtcardID.Text, realtime, txtStatus.Text, txtType.Text, id.ToString());
                    Parking_GDAO.Instance.addtoDB(myParking);
                }
                
                else if (getPark.Type.ToString().Equals("THẺ KHÁCH") == true && getPark.Status.ToString().Equals("XE VÀO") == true)
                {
                    txtCardIDOut.Text = getPark.CardID;
                    txtTimeOut.Text = realtime;
                    txtStatusOut.Text = "XE RA";
                    txtTypeOut.Text = "THẺ KHÁCH";
                    ptImageOut.ClientSize = new Size(myImg.Width, myImg.Height);
                    ptImageOut.Image = (Image)myImg;

                    txtcardID.Text = getPark.CardID;
                    txtTime.Text = DateTime.Parse(getPark.Time).ToString("yyyy-M-dd HH:mm:ss");
                    txtStatus.Text = getPark.Status.ToString();
                    txtType.Text = getPark.Type;
                    ptImage.ClientSize = new Size(myImg.Width, myImg.Height);
                    ptImage.Image = (Image)myImg;



                    TimeSpan diff = (DateTime.Parse(DateTime.Parse(realtime).ToString("yyyy-M-dd HH:mm:ss"))).Subtract(DateTime.Parse(DateTime.Parse(getPark.Time).ToString("yyyy-M-dd HH:mm:ss")));
                    money = diff.TotalSeconds * 0.3 + 3000;
                    DialogResult dr = MessageBox.Show(string.Format("Số tiền cần phải trả là {0} đồng \nThời gian xe vào {1}", money, getPark.Time.ToString()), "Trả tiền", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            StatisticsDTO statis = new StatisticsDTO(getPark.CardID, DateTime.Parse(getPark.Time).ToString("yyyy-M-dd HH:mm:ss"), realtime, getPark.Type, (int)money);
                            Parking_GDAO.Instance.addtoStatisticsDB(statis);
                            Parking_GDAO.Instance.deleteParkingByID(getPark.CardID);
                            MessageBox.Show("Tính tiền thành công", " Thành công");
                            break;
                        case DialogResult.No:
                            MessageBox.Show("Tính tiền thất bại", " Thất bại");
                            break;
                    }
                }

                else if (getPark.Type.ToString().Equals("THẺ THÁNG") == true && getPark.Status.ToString().Equals("XE RA") == true)
                {
                    txtCardIDOut.Text = getPark.CardID;
                    txtTimeOut.Text = DateTime.Parse(getPark.Time).ToString("yyyy-M-dd HH:mm:ss");
                    txtStatusOut.Text = getPark.Status;
                    txtTypeOut.Text = "THẺ THÁNG";
                    ptImageOut.ClientSize = new Size(myImg.Width, myImg.Height);
                    ptImageOut.Image = (Image)myImg;

                    txtcardID.Text = getPark.CardID;
                    txtTime.Text = realtime;
                    txtStatus.Text = "XE VÀO";
                    txtType.Text = "THẺ THÁNG";
                    ptImage.ClientSize = new Size(myImg.Width, myImg.Height);
                    ptImage.Image = (Image)myImg;

                    MessageBox.Show(string.Format("Quét thẻ tháng thành công (xe vào) \nThời gian vào lúc {0}", realtime), "Thành công");

                    ParkingDTO myParking = new ParkingDTO(txtcardID.Text, realtime, txtStatus.Text, txtType.Text, id.ToString());
                    Parking_GDAO.Instance.updateParkingByID(myParking);
                }

                else if (getPark.Type.ToString().Equals("THẺ THÁNG") == true && getPark.Status.ToString().Equals("XE VÀO") == true)
                {
                    txtcardID.Text = getPark.CardID;
                    txtTime.Text = DateTime.Parse(getPark.Time).ToString("yyyy-M-dd HH:mm:ss");
                    txtStatus.Text = getPark.Status;
                    txtType.Text = "THẺ THÁNG";
                    ptImage.ClientSize = new Size(myImg.Width, myImg.Height);
                    ptImage.Image = (Image)myImg;

                    txtCardIDOut.Text = getPark.CardID;
                    txtTimeOut.Text = realtime;
                    txtStatusOut.Text = "XE RA";
                    txtTypeOut.Text = "THẺ THÁNG";
                    ptImageOut.ClientSize = new Size(myImg.Width, myImg.Height);
                    ptImageOut.Image = (Image)myImg;

                    MessageBox.Show(string.Format("Quét thẻ tháng thành công (xe ra) \nThời gian ra lúc {0}", realtime), "Thành công");

                    ParkingDTO myParking = new ParkingDTO(txtCardIDOut.Text, realtime, txtStatusOut.Text, txtTypeOut.Text, id.ToString());
                    Parking_GDAO.Instance.updateParkingByID(myParking);
                }

                else

                {
                    MessageBox.Show("Mã thẻ đã tồn tại", "Lỗi");

                }
            }
            else
            {
                MessageBox.Show("Không quét được thẻ", "Lỗi");

            }

            cancel();

        }

        void cancel()
        {
            txtcardID.Text = "";
            txtTime.Text = "";
            txtStatus.Text = "";
            txtType.Text = "";
            ptImage.Image = null;

            txtCardIDOut.Text = "";
            txtTimeOut.Text = "";
            txtStatusOut.Text = "";
            txtTypeOut.Text = "";
            ptImageOut.Image = null;

            textValue = "";

            if (bgwParking.IsBusy != true)
            {
                bgwParking.RunWorkerAsync();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
                cancel();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin lg = new frmLogin();
            lg.ShowDialog();
            this.Close();

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin df = new frmAdmin(GetAccountInfo);
            this.Hide();
            df.ShowDialog();
            this.Close();
        }
    }
}
