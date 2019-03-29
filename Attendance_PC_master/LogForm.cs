using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using MySql.Data.MySqlClient;

namespace Attendance_PC_master
{
    public partial class LogForm : Form
    {
        //数据库信息
        //string host = "localhost";
        string host = "47.100.28.6";
        string database = "attendance";
        string username = "root";
        string passwd = "LL960220";

        public LogForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.None;
        }


        /// <summary>
        /// 限制TextBox只输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TextChangeNum(object sender, EventArgs e)
        {
            TextBox tbInput = (TextBox)sender;
            var reg = new Regex("^[0-9]*$");
            var str = tbInput.Text.Trim();
            var sb = new StringBuilder();
            if (!reg.IsMatch(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (reg.IsMatch(str[i].ToString()))
                    {
                        sb.Append(str[i].ToString());
                    }
                }
                tbInput.Text = sb.ToString();
                tbInput.SelectionStart = tbInput.Text.Length;    //定义输入焦点在最后一个字符
            }
        }

        /// <summary>
        /// 点击登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_login_Click(object sender, EventArgs e)
        {
            if(tbUserName.Text==""||tbPasswd.Text=="")
            {
                MessageBox.Show("登录名或密码不得为空!");
            }
            else if(tbUserName.Text != "" || tbPasswd.Text != "")
            {
                MySqlConnection myconn = new MySqlConnection("Host =" + host
                                            + ";Database=" + database
                                            + ";Username=" + username
                                            + ";Password=" + passwd + ";");
                try
                {
                    //开启连接
                    myconn.Open();
                    //新建SQL指令
                    MySqlCommand mycom = myconn.CreateCommand();
                    //构造SQL指令
                    string sql = string.Format("SELECT * FROM userinfo;");

                    mycom.CommandText = sql;

                    //执行查询指令
                    MySqlDataReader reader = mycom.ExecuteReader();

                    while (reader.Read())
                    {
                        //MessageBox.Show(reader[0].ToString());
                        if (reader.GetString(3).ToString() == tbPasswd.Text)
                        {
                            //跳转界面
                            this.DialogResult = DialogResult.OK;
                            this.Hide();
                            MainForm mainForm = new MainForm(tbUserName.Text, reader.GetString(1));
                            mainForm.ShowDialog();
                        }
                    }
                }
                catch (MySqlException)
                {

                }
                finally
                {
                    //释放资源，防止数据库锁住
                    myconn.Dispose();
                    //关闭数据库连接
                    myconn.Close();
                }
            }
        }
    }
}
