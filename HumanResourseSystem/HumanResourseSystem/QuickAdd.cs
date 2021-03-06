﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourseSystem
{
    public partial class QuickAdd : Form
    {
        public static QuickAdd qa;
        public QuickAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ms_QuickAdd.Show(MousePosition);
        }

        private void 添加人员档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PeopleAdd pa = new frm_PeopleAdd();
            pa.ShowDialog();
        }

        private void 添加工资记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SalaryAdd sa = new frm_SalaryAdd();
            sa.ShowDialog();
        }

        private void QuickAdd_FormClosed(object sender, FormClosedEventArgs e)
        {   //浮动工具窗口关闭后,修改数据库中的按钮状态属性.
            DataConnector data = new DataConnector();
            DataSet ds;
            data.dataCon();
           string strSql = "UPDATE Preferences SET P_Value = 'hide' WHERE P_KEY='btn_QuickAdd' AND P_Username = '" + frm_Login.username + "'";
            ds = data.getDataset(strSql);
        }
        public void check_state()
        {
            DataConnector data = new DataConnector();
            DataSet ds;
            data.dataCon();
            string strSql = "SELECT P_Value FROM(SELECT P_Key , P_Value , P_Username FROM Preferences WHERE(P_Username = '" + frm_Login.username + "')) WHERE(P_Key='btn_QuickAdd')";
            ds = data.getDataset(strSql);
            if (ds.Tables[0].Rows[0][0].ToString().Equals("hide")|| ds.Tables[0].Rows[0][0].ToString().Equals("include"))
            {
                this.Close();
            }
        }
    }
}
