﻿namespace HumanResourseSystem
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.系统SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员档案管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员工资管理SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.数据库管理TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.偏好设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登出LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助目录MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.系统信息SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.hintbox = new System.Windows.Forms.ToolStripStatusLabel();
            this.ms_QuickAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加人员档案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加工资记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_QuickAdd = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.ms_QuickAdd.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统SToolStripMenuItem,
            this.关于AToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1264, 25);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // 系统SToolStripMenuItem
            // 
            this.系统SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人员档案管理ToolStripMenuItem,
            this.人员工资管理SToolStripMenuItem,
            this.toolStripSeparator1,
            this.数据库管理TToolStripMenuItem,
            this.偏好设置ToolStripMenuItem,
            this.登出LToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.系统SToolStripMenuItem.Name = "系统SToolStripMenuItem";
            this.系统SToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.系统SToolStripMenuItem.Text = "系统(&Y)";
            this.系统SToolStripMenuItem.MouseEnter += new System.EventHandler(this.系统SToolStripMenuItem_MouseEnter);
            this.系统SToolStripMenuItem.MouseLeave += new System.EventHandler(this.Items_MouseLeave);
            // 
            // 人员档案管理ToolStripMenuItem
            // 
            this.人员档案管理ToolStripMenuItem.Image = global::HumanResourseSystem.Properties.Resources.student;
            this.人员档案管理ToolStripMenuItem.Name = "人员档案管理ToolStripMenuItem";
            this.人员档案管理ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.人员档案管理ToolStripMenuItem.Text = "人员档案管理(&D)";
            this.人员档案管理ToolStripMenuItem.Click += new System.EventHandler(this.人员档案管理ToolStripMenuItem_Click);
            this.人员档案管理ToolStripMenuItem.MouseEnter += new System.EventHandler(this.人员档案管理ToolStripMenuItem_MouseEnter);
            this.人员档案管理ToolStripMenuItem.MouseLeave += new System.EventHandler(this.Items_MouseLeave);
            // 
            // 人员工资管理SToolStripMenuItem
            // 
            this.人员工资管理SToolStripMenuItem.Image = global::HumanResourseSystem.Properties.Resources.score;
            this.人员工资管理SToolStripMenuItem.Name = "人员工资管理SToolStripMenuItem";
            this.人员工资管理SToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.人员工资管理SToolStripMenuItem.Text = "人员工资管理(&S)";
            this.人员工资管理SToolStripMenuItem.Click += new System.EventHandler(this.人员工资管理SToolStripMenuItem_Click);
            this.人员工资管理SToolStripMenuItem.MouseEnter += new System.EventHandler(this.人员工资管理SToolStripMenuItem_MouseEnter);
            this.人员工资管理SToolStripMenuItem.MouseLeave += new System.EventHandler(this.Items_MouseLeave);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // 数据库管理TToolStripMenuItem
            // 
            this.数据库管理TToolStripMenuItem.Image = global::HumanResourseSystem.Properties.Resources.course;
            this.数据库管理TToolStripMenuItem.Name = "数据库管理TToolStripMenuItem";
            this.数据库管理TToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.数据库管理TToolStripMenuItem.Text = "打开数据库..(&T)";
            this.数据库管理TToolStripMenuItem.Click += new System.EventHandler(this.数据库管理TToolStripMenuItem_Click);
            this.数据库管理TToolStripMenuItem.MouseEnter += new System.EventHandler(this.数据库管理TToolStripMenuItem_MouseEnter);
            this.数据库管理TToolStripMenuItem.MouseLeave += new System.EventHandler(this.Items_MouseLeave);
            // 
            // 偏好设置ToolStripMenuItem
            // 
            this.偏好设置ToolStripMenuItem.Name = "偏好设置ToolStripMenuItem";
            this.偏好设置ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.偏好设置ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.偏好设置ToolStripMenuItem.Text = "偏好设置 ...";
            this.偏好设置ToolStripMenuItem.Click += new System.EventHandler(this.偏好设置ToolStripMenuItem_Click);
            this.偏好设置ToolStripMenuItem.MouseEnter += new System.EventHandler(this.偏好设置ToolStripMenuItem_MouseEnter);
            this.偏好设置ToolStripMenuItem.MouseLeave += new System.EventHandler(this.Items_MouseLeave);
            // 
            // 登出LToolStripMenuItem
            // 
            this.登出LToolStripMenuItem.Name = "登出LToolStripMenuItem";
            this.登出LToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.登出LToolStripMenuItem.Text = "登出(&L)";
            this.登出LToolStripMenuItem.Click += new System.EventHandler(this.登出LToolStripMenuItem_Click);
            this.登出LToolStripMenuItem.MouseEnter += new System.EventHandler(this.登出LToolStripMenuItem_MouseEnter);
            this.登出LToolStripMenuItem.MouseLeave += new System.EventHandler(this.Items_MouseLeave);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            this.退出ToolStripMenuItem.MouseEnter += new System.EventHandler(this.退出ToolStripMenuItem_MouseEnter);
            this.退出ToolStripMenuItem.MouseLeave += new System.EventHandler(this.Items_MouseLeave);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助目录MToolStripMenuItem,
            this.toolStripSeparator2,
            this.系统信息SToolStripMenuItem,
            this.关于AToolStripMenuItem1});
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.关于AToolStripMenuItem.Text = "帮助(&H)";
            this.关于AToolStripMenuItem.MouseEnter += new System.EventHandler(this.关于AToolStripMenuItem_MouseEnter);
            this.关于AToolStripMenuItem.MouseLeave += new System.EventHandler(this.Items_MouseLeave);
            // 
            // 帮助目录MToolStripMenuItem
            // 
            this.帮助目录MToolStripMenuItem.Enabled = false;
            this.帮助目录MToolStripMenuItem.Name = "帮助目录MToolStripMenuItem";
            this.帮助目录MToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.帮助目录MToolStripMenuItem.Text = "帮助目录(&M)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // 系统信息SToolStripMenuItem
            // 
            this.系统信息SToolStripMenuItem.Name = "系统信息SToolStripMenuItem";
            this.系统信息SToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.系统信息SToolStripMenuItem.Text = "系统信息 ... (&I)";
            this.系统信息SToolStripMenuItem.Click += new System.EventHandler(this.系统信息SToolStripMenuItem_Click);
            this.系统信息SToolStripMenuItem.MouseEnter += new System.EventHandler(this.系统信息SToolStripMenuItem_MouseEnter);
            this.系统信息SToolStripMenuItem.MouseLeave += new System.EventHandler(this.Items_MouseLeave);
            // 
            // 关于AToolStripMenuItem1
            // 
            this.关于AToolStripMenuItem1.Name = "关于AToolStripMenuItem1";
            this.关于AToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.关于AToolStripMenuItem1.Text = "关于... (&A)";
            this.关于AToolStripMenuItem1.Click += new System.EventHandler(this.关于AToolStripMenuItem1_Click);
            this.关于AToolStripMenuItem1.MouseEnter += new System.EventHandler(this.关于AToolStripMenuItem1_MouseEnter);
            this.关于AToolStripMenuItem1.MouseLeave += new System.EventHandler(this.Items_MouseLeave);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hintbox});
            this.statusBar.Location = new System.Drawing.Point(0, 659);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1264, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // hintbox
            // 
            this.hintbox.Name = "hintbox";
            this.hintbox.Size = new System.Drawing.Size(42, 17);
            this.hintbox.Text = "status";
            // 
            // ms_QuickAdd
            // 
            this.ms_QuickAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加人员档案ToolStripMenuItem,
            this.添加工资记录ToolStripMenuItem});
            this.ms_QuickAdd.Name = "ms_QuickAdd";
            this.ms_QuickAdd.Size = new System.Drawing.Size(193, 48);
            // 
            // 添加人员档案ToolStripMenuItem
            // 
            this.添加人员档案ToolStripMenuItem.Image = global::HumanResourseSystem.Properties.Resources.student;
            this.添加人员档案ToolStripMenuItem.Name = "添加人员档案ToolStripMenuItem";
            this.添加人员档案ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.添加人员档案ToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.添加人员档案ToolStripMenuItem.Text = "添加人员记录";
            this.添加人员档案ToolStripMenuItem.Click += new System.EventHandler(this.添加人员档案ToolStripMenuItem_Click);
            // 
            // 添加工资记录ToolStripMenuItem
            // 
            this.添加工资记录ToolStripMenuItem.Image = global::HumanResourseSystem.Properties.Resources.score;
            this.添加工资记录ToolStripMenuItem.Name = "添加工资记录ToolStripMenuItem";
            this.添加工资记录ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.添加工资记录ToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.添加工资记录ToolStripMenuItem.Text = "添加工资记录";
            this.添加工资记录ToolStripMenuItem.Click += new System.EventHandler(this.添加工资记录ToolStripMenuItem_Click);
            // 
            // btn_QuickAdd
            // 
            this.btn_QuickAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_QuickAdd.BackColor = System.Drawing.Color.Black;
            this.btn_QuickAdd.BackgroundImage = global::HumanResourseSystem.Properties.Resources.add;
            this.btn_QuickAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_QuickAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_QuickAdd.Font = new System.Drawing.Font("微软雅黑", 25F);
            this.btn_QuickAdd.Location = new System.Drawing.Point(1197, 614);
            this.btn_QuickAdd.Name = "btn_QuickAdd";
            this.btn_QuickAdd.Size = new System.Drawing.Size(55, 55);
            this.btn_QuickAdd.TabIndex = 6;
            this.btn_QuickAdd.UseVisualStyleBackColor = false;
            this.btn_QuickAdd.Click += new System.EventHandler(this.btn_QuickAdd_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::HumanResourseSystem.Properties.Resources.student;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::HumanResourseSystem.Properties.Resources.score;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_QuickAdd);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuBar;
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "frm_Main";
            this.Text = "人事工资管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ms_QuickAdd.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem 系统SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员档案管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员工资管理SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 数据库管理TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助目录MToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel hintbox;
        private System.Windows.Forms.ContextMenuStrip ms_QuickAdd;
        private System.Windows.Forms.ToolStripMenuItem 添加人员档案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加工资记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统信息SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登出LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 偏好设置ToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        public System.Windows.Forms.Button btn_QuickAdd;
    }
}