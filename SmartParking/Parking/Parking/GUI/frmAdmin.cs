using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking.DAL;
using Parking.DAO;
using Parking.DTO;

namespace Parking.GUI
{
    public partial class frmAdmin : Form
    {
        private string textValue = "";
        private string nextmonth = "";
        private string realtime = "";

        BindingSource userList = new BindingSource();
        BindingSource statisList = new BindingSource();
        BindingSource accountList = new BindingSource();


        private AccountDTO getAccountInfo;
        public AccountDTO GetAccountInfo
        {
            get { return getAccountInfo; }
            set { getAccountInfo = value; }
        }

        public frmAdmin(AccountDTO info)
        {
            InitializeComponent();

            autoDeleteExpired();

            this.getAccountInfo = info;

            DateTime today = DateTime.Now;
            dpkStart.Value = new DateTime(today.Year, today.Month, 1);
            dpkEnd.Value = dpkStart.Value.AddMonths(1).AddDays(-1);

            Loaddtgv();
            AddDataBinding();

            bgwInsertUser.WorkerReportsProgress = true;
            bgwInsertUser.WorkerSupportsCancellation = true;

            loadCrystalReport();


            if (bgwInsertUser.IsBusy != true)
            {
                // Start the asynchronous operation.
                bgwInsertUser.RunWorkerAsync();
            }

        }

        private void bwInsertUser_DoWork(object sender, DoWorkEventArgs e)
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


                            bgwInsertUser.CancelAsync();


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

        private void bwInsertUser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {

                txtcardID.Text = textValue;

                nextmonth = DateTime.Now.AddMonths(1).ToString("yyyy-M-dd HH:mm:ss");
                realtime = DateTime.Now.ToString("yyyy-M-dd HH:mm:ss");
                txtTimeIn.Text = nextmonth;

                Bitmap myImg;

                string directory = @"D:\GITHUB\nguyenduyen2210-nd2610\nguyenduyen2210-nd2610\SmartParking\Images\";

                int id = Int32.Parse(textValue[textValue.Length - 1].ToString()) + Int32.Parse(textValue[textValue.Length - 2].ToString());

                directory = directory + id.ToString() + ".png";

                myImg = new Bitmap(directory);

                ptImage.ClientSize = new Size(myImg.Width, myImg.Height);

                ptImage.Image = (Image)myImg;

            }

            catch { }

        }

        public void Loaddtgv()
        {
            dtgvInsertUser.DataSource = userList;
            LoadListUser();
            dtgvStatistics.DataSource = statisList;
            LoadListStatis();
            dtgvStaff.DataSource = accountList;
            LoadListAccount();

        }

        public void AddDataBinding()
        {
            AddUserBinding();
            AddAccountBinding();

        }
        void AddUserBinding()
        {
            txtcardID.DataBindings.Add(new Binding("Text", dtgvInsertUser.DataSource, "CardID", true, DataSourceUpdateMode.Never));
            txtTimeIn.DataBindings.Add(new Binding("Text", dtgvInsertUser.DataSource, "Time", true, DataSourceUpdateMode.Never));

        }

        void LoadListUser()
        {
            userList.DataSource = Parking_UDAO.Instance.getUserList();
            this.dtgvInsertUser.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvInsertUser.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvInsertUser.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvInsertUser.Columns[0].HeaderText = "CardID";
            this.dtgvInsertUser.Columns[1].HeaderText = "Time";
            this.dtgvInsertUser.Columns[2].HeaderText = "Image";


        }
        void LoadListAccount()
        {
            accountList.DataSource = Account_DAO.Instance.getAccList();

            this.dtgvStaff.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStaff.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStaff.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStaff.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStaff.Columns[0].HeaderText = "Username";
            this.dtgvStaff.Columns[1].HeaderText = "Password";
            this.dtgvStaff.Columns[2].HeaderText = "Type";
            this.dtgvStaff.Columns[3].HeaderText = "Fullname";

        }

        void AddAccountBinding()
        {
            txtFullname.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "Fullname", true, DataSourceUpdateMode.Never));
            txtUsername.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "Username", true, DataSourceUpdateMode.Never));
            txtPassword.DataBindings.Add(new Binding(("Text"), dtgvStaff.DataSource, "Password", true, DataSourceUpdateMode.Never));
            cbType.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "Type", true, DataSourceUpdateMode.Never));

        }
        void LoadListStatis()
        {


            dpkStart.Format = DateTimePickerFormat.Custom;
            dpkStart.CustomFormat = "dd";
            dpkStart.ShowUpDown = true;

            dpkStart.Format = DateTimePickerFormat.Custom;
            dpkStart.CustomFormat = "mm";
            dpkStart.ShowUpDown = true;

            dpkStart.Format = DateTimePickerFormat.Custom;
            dpkStart.CustomFormat = "yyyy";
            dpkStart.ShowUpDown = true;

            statisList.DataSource = Parking_GDAO.Instance.getStatisticsByDate(dpkEnd.Value.ToString("yyyy-M-dd"), dpkStart.Value.ToString("yyyy-M-dd"));

            //statisList.DataSource = GuestDAL.Instance.getStatisticalDBByDate(dtpkSortByDay.Value.ToString("yyyy-M-dd"), dtpkSortByDay.Value.ToString("yyyy-M-dd"));

            customStatisgv();

        }

        void LoadListStatisByDay()
        {
            statisList.DataSource = Parking_GDAO.Instance.getStatisticsByDay(dpkStart.Value.Day.ToString(), dpkStart.Value.Month.ToString(), dpkStart.Value.Year.ToString());

        }
        void LoadListStatisByMonth()
        {
            statisList.DataSource = Parking_GDAO.Instance.getStatisticsByMonth(dpkStart.Value.Month.ToString(), dpkStart.Value.Year.ToString());

        }
        void LoadListStatisByYear()
        {
            statisList.DataSource = Parking_GDAO.Instance.getStatisticsByYear(dpkStart.Value.Year.ToString());

        }

        void customStatisgv()
        {
            this.dtgvStatistics.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStatistics.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStatistics.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStatistics.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStatistics.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStatistics.Columns[0].HeaderText = "CardID";
            this.dtgvStatistics.Columns[1].HeaderText = "TimeIn";
            this.dtgvStatistics.Columns[2].HeaderText = "TimeOut";
            this.dtgvStatistics.Columns[3].HeaderText = "Type";
            this.dtgvStatistics.Columns[4].HeaderText = "Money";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textValue != "")
            {
                int id = Int32.Parse(textValue[textValue.Length - 1].ToString()) + Int32.Parse(textValue[textValue.Length - 2].ToString());

                String status = "XE VÀO";
                String type = "THẺ THÁNG";
                ParkingDTO myPark = Parking_GDAO.Instance.getParkingByID(textValue);
                if (myPark == null)
                {
                    ParkingDTO myParking = new ParkingDTO(txtcardID.Text, realtime, status, type, id.ToString());
                    StatisticsDTO myStatis = new StatisticsDTO(txtcardID.Text, realtime, nextmonth, type, 200000);
                    Parking_GDAO.Instance.addtoDB(myParking);
                    Parking_GDAO.Instance.addtoStatisticsDB(myStatis);
                    /*
                    txtcardID.Text = "";
                    txtTimeIn.Text = "";
                    textAccept = "";
                    pbImage.Image = null;
                    */

                    LoadListStatis();
                    Loaddtgv();
                    loadCrystalReport();

                    MessageBox.Show("Thêm tài khoản thành công", "Thành Công");
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Lỗi");
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
            txtTimeIn.Text = "";
            textValue = "";
            ptImage.Image = null;

            if (bgwInsertUser.IsBusy != true)
            {
                bgwInsertUser.RunWorkerAsync();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtcardID.Text != "")
            {
                Parking_GDAO.Instance.deleteParkingByID(txtcardID.Text);
                //    GuestDAL.Instance.deleteStatisticalByID(txtcardID.Text);

                LoadListStatis();
                Loaddtgv();
                loadCrystalReport();

                MessageBox.Show("Xóa tài khoản thành công", "Thành công");
            }
            else
            {
                MessageBox.Show("Không xóa được tài khoản", "Lỗi");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
                cancel();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmParking pk = new frmParking(GetAccountInfo);
            pk.ShowDialog();
            this.Close();

        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            LoadListStatis();
            Loaddtgv();
            loadCrystalReport();

            dtgvStatistics.DataSource = statisList;
            LoadListStatisByDay();
            loadCrystalReport();

            dtgvStatistics.DataSource = statisList;
            LoadListStatisByMonth();
            loadCrystalReport();

            dtgvStatistics.DataSource = statisList;
            LoadListStatisByYear();
            loadCrystalReport();

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string fullname = txtFullname.Text;
            string username = txtUsername.Text;
            string pwd = txtPassword.Text;
            string type = cbType.SelectedItem.ToString();
            if (username != "" && Account_DAO.Instance.getAccByID(username) != null)
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Lỗi");
            }
            else
            if (pwd != "" && type != "")
            {
                AccountDTO acc = new AccountDTO(username, (pwd), type, fullname);
                Account_DAO.Instance.addtoAccDB(acc);
                MessageBox.Show("Thêm tài khoản thành công", "Thành công");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("Nhập thiếu thông tin", "Lỗi");
            }

        }

        private int adminCount()
        {
            int count = 0;
            List<AccountDTO> getList = Account_DAO.Instance.getAccList();
            for (int i = 0; i < getList.Count; i++)
            {
                if (getList[i].Type.Equals("Quản lý") == true)
                {
                    count++;
                }
            }
            return count;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            AccountDTO staff = Account_DAO.Instance.getAccByID(username);
            if (adminCount() == 1 && staff.Username == "Quản lý")
            {
                MessageBox.Show("Đây là tài khoản admin duy nhất, không thể xóa", "Lỗi");
            }

            else

            if (username != "")
            {
                Account_DAO.Instance.deleteAccByID(username);
                MessageBox.Show("Xóa tài khoản thành công", "Thành công");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("Không xóa được tài khoản", "Lỗi");
            }

        }

        private void btnHomeU_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmParking pk = new frmParking(GetAccountInfo);
            pk.ShowDialog();
            this.Close();
        }

        private void autoDeleteExpired()
        {

            int count = 0;
            List<StatisticsDTO> getStatisList = Parking_GDAO.Instance.getStatisticsByUser();
            for (int i = 0; i < getStatisList.Count; i++)
            {
                if (DateTime.Parse(getStatisList[i].TimeOut).ToString("yyyy-M-dd").Equals(DateTime.Now.ToString("yyyy-M-dd")))
                {
                    count++;
                    Parking_GDAO.Instance.deleteParkingByID(getStatisList[i].CardID);
                    //  GuestDAL.Instance.deleteStatisticalByID(getStatisList[i].CardID);
                }
            }
            if (count > 0)
            {

                MessageBox.Show(string.Format("Đã xóa {0} tài khoản hết hạn", count), "Thông báo");
            }

        }

        private void loadCrystalReport()
        {
            ParkingReport pr = new ParkingReport();
            pr.SetDataSource(statisList);
            ParkingReportViewer.ReportSource = pr;
            ParkingReportViewer.Refresh();
        }
    }
}
