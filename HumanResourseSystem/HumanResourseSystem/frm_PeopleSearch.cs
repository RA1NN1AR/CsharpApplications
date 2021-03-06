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
    public partial class frm_PeopleSearch : Form
    {
        public static string strSql;
        public frm_PeopleSearch()
        {
            InitializeComponent();
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            string condition = "";
            if (chk_LIKEMODE.Checked==false)    //判断模糊查询复选框是否选中
            {
                if (txt_ID.Text.Length != 0) { condition += "and E_ID='" + txt_ID.Text + "'"; }
                if (txt_Name.Text.Length != 0) { condition += "and E_Name='" + txt_Name.Text + "'"; }
                if (txt_Sex.Text.Length != 0) { condition += "and E_Sex='" + txt_Sex.Text + "'"; }
                if (txt_Birthday.Text.Length != 0) { condition += "and E_Birthday='" + txt_Birthday.Text + "'"; }
                if (txt_Inworkdate.Text.Length != 0) { condition += "and E_InworkDate='" + txt_Inworkdate.Text + "'"; }
                if (txt_Age.Text.Length != 0) { condition += "and E_Age='" + txt_Age.Text + "'"; }
                if (txt_Position.Text.Length != 0) { condition += "and E_Position='" + txt_Position.Text + "'"; }
                if (txt_Phone.Text.Length != 0) { condition += "and E_Tel='" + txt_Phone.Text + "'"; }
                if (txt_Address.Text.Length != 0) { condition += "and E_Address='" + txt_Address.Text + "'"; }
                strSql = "SELECT   E_ID AS 编号, E_Name AS 姓名, E_Sex AS 性别, E_Age AS 年龄, E_Birthday AS 出生日期, E_InworkDate AS 入职日期, E_Position AS 岗位, E_Phone AS 电话, E_Address AS 地址 FROM  Employee WHERE (1 = 1) " + condition;
            }
            else
            {
                if (txt_ID.Text.Length != 0) { condition += "AND (E_ID LIKE '%" + txt_ID.Text + "%')"; }
                if (txt_Name.Text.Length != 0) { condition += "AND (E_Name LIKE '%" + txt_Name.Text + "%')"; }
                if (txt_Sex.Text.Length != 0) { condition += "AND (E_Sex LIKE '%" + txt_Sex.Text + "%')"; }
                if (txt_Birthday.Text.Length != 0) { condition += "AND (E_Birthday LIKE '%" + txt_Birthday.Text + "%')"; }
                if (txt_Inworkdate.Text.Length != 0) { condition += "AND (E_InworkDate LIKE '%" + txt_Inworkdate.Text + "%')"; }
                if (txt_Age.Text.Length != 0) { condition += "AND (E_Age LIKE '%" + txt_Age.Text + "%')"; }
                if (txt_Position.Text.Length != 0) { condition += "AND (E_Position LIKE '%" + txt_Position.Text + "%')"; }
                if (txt_Phone.Text.Length != 0) { condition += "AND (E_Tel= LIKE '%" + txt_Phone.Text + "%')"; }
                if (txt_Address.Text.Length != 0) { condition += "AND (E_Address LIKE '%" + txt_Address.Text + "%')"; }
                strSql = "SELECT   E_ID AS 编号, E_Name AS 姓名, E_Sex AS 性别, E_Age AS 年龄, E_Birthday AS 出生日期, E_InworkDate AS 入职日期, E_Position AS 岗位, E_Phone AS 电话, E_Address AS 地址 FROM Employee WHERE   (1 = 1) " + condition;
            }
            frm_PeopleMgmt.frm_PM.ExecSQL();
            this.Close();

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "";txt_Sex.Text = "";txt_Age.Text = ""; txt_Position.Text = "";txt_Phone .Text= "";txt_Address.Text = "";
        }

        private void frm_PeopleSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) { this.Close(); }
        }
    }
}
