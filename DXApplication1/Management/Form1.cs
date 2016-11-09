using Management.connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Management {
    public partial class FrmLogin: DevExpress.XtraEditors.XtraForm {
        private const string uErrors = "Invalid ID or Password!";
        private const string bErrors = "Please choose branch!";
        Dictionary<Int32,string> myDic;
        
        private int currentBranch = 0;
        public FrmLogin() {
            InitializeComponent();
            myDic = new Dictionary<int,string>();
        }
        private void defaultLogin() {
            userName.Text = "admin";
            password.Text = "admin";
        }

        private void initDropDown() {
            DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            for(Int32 i = 0; i < dt.Rows.Count; i++) {
                string s = string.Concat(dt.Rows[i]["InstanceName"]);
                if(!s.Equals("SERVER") && !s.Equals("")) {
                    //branch.Properties.Items.Add(s);
                    myDic.Add(i,s);
                }
            }
            foreach(KeyValuePair<Int32,string> entry in myDic) {
                branch.Properties.Items.Add(entry.Value);
            }
            branch.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender,EventArgs e) {
            string id = userName.Text.Trim();
            string pass = password.Text.Trim();
            if(id.Equals("admin") && pass.Equals("admin")){
                loadData(0, currentBranch);
            }else{
                if(currentBranch == 0 && id.Equals("branch1") && pass.Equals("branch1")) {
                    loadData(1,currentBranch);
                } else if(currentBranch == 1 && id.Equals("branch2") && pass.Equals("branch2")) {
                    loadData(2,currentBranch);
                } else {
                    warning.Text = uErrors;
                    showWarning();
                    userName.Focus();
                }
            }
        }
        private void showWarning() {
            warning.Visible = true;
            BackgroundWorker back = new BackgroundWorker();
            back.WorkerReportsProgress = true;
            //do in background
            back.DoWork += new DoWorkEventHandler(delegate(object o,DoWorkEventArgs args) {
                BackgroundWorker bw = o as BackgroundWorker;
                System.Threading.Thread.Sleep(1000);
            });
            //do when progress change
            back.ProgressChanged += new ProgressChangedEventHandler(delegate(object o,ProgressChangedEventArgs args) {
                //set progress here with {args.ProgressPercentage}
            });
            //do when complete task
            back.RunWorkerCompleted += new RunWorkerCompletedEventHandler(delegate(object o,RunWorkerCompletedEventArgs args) {
                warning.Visible = false;
            });
            back.RunWorkerAsync();
        }
        private void startWorkSpace(int type, int branch) {
            this.Visible = false;
            new FrmMain(type, branch).ShowDialog();
            this.Close();
        }
        private void loadData(int type, int branch) {
            progressBar.Visible = true;
            BackgroundWorker back = new BackgroundWorker();
            back.WorkerReportsProgress = true;
            //do in background
            back.DoWork += new DoWorkEventHandler(delegate(object o,DoWorkEventArgs args) {
                BackgroundWorker bw = o as BackgroundWorker;
                Connection connect = Connection.getInstance();
                connect.startConnect();
                System.Threading.Thread.Sleep(3000);
            });
            //do when progress change
            back.ProgressChanged += new ProgressChangedEventHandler(delegate(object o,ProgressChangedEventArgs args) {
                //set progress here with {args.ProgressPercentage}
            });
            //do when complete task
            back.RunWorkerCompleted += new RunWorkerCompletedEventHandler(delegate(object o,RunWorkerCompletedEventArgs args) {
                progressBar.Visible = false;
                startWorkSpace(type, branch);
            });
            back.RunWorkerAsync();
        }

        private void branch_SelectedIndexChanged(object sender,EventArgs e) {
            currentBranch = branch.SelectedIndex;
        }

        private void FrmLogin_Load(object sender,EventArgs e) {
            initDropDown();
            defaultLogin();
        }
    }
}
