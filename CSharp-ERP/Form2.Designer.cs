namespace CSharp_ERP
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工培训管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工培训管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.员工薪金管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工月薪管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工年终奖管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工数据统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.视图VToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.关于AToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1131, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统设置ToolStripMenuItem,
            this.数据库维护ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.文件FToolStripMenuItem.Text = "系统管理";
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工管理ToolStripMenuItem,
            this.员工培训管理ToolStripMenuItem,
            this.员工培训管理ToolStripMenuItem1,
            this.员工薪金管理ToolStripMenuItem,
            this.员工数据统计ToolStripMenuItem});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.编辑EToolStripMenuItem.Text = "人事管理";
            // 
            // 视图VToolStripMenuItem
            // 
            this.视图VToolStripMenuItem.Name = "视图VToolStripMenuItem";
            this.视图VToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.视图VToolStripMenuItem.Text = "备忘记录";
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项OToolStripMenuItem});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具TToolStripMenuItem.Text = "工具";
            // 
            // 选项OToolStripMenuItem
            // 
            this.选项OToolStripMenuItem.Name = "选项OToolStripMenuItem";
            this.选项OToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.选项OToolStripMenuItem.Text = "选项 (&O)...";
            this.选项OToolStripMenuItem.Click += new System.EventHandler(this.选项OToolStripMenuItem_Click);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AToolStripMenuItem1});
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于AToolStripMenuItem.Text = "帮助";
            // 
            // 关于AToolStripMenuItem1
            // 
            this.关于AToolStripMenuItem1.Name = "关于AToolStripMenuItem1";
            this.关于AToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.关于AToolStripMenuItem1.Text = "关于";
            this.关于AToolStripMenuItem1.Click += new System.EventHandler(this.关于AToolStripMenuItem1_Click);
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.系统设置ToolStripMenuItem.Text = "系统设置...";
            this.系统设置ToolStripMenuItem.Click += new System.EventHandler(this.系统设置ToolStripMenuItem_Click);
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.员工管理ToolStripMenuItem.Text = "员工资料管理";
            // 
            // 员工培训管理ToolStripMenuItem
            // 
            this.员工培训管理ToolStripMenuItem.Name = "员工培训管理ToolStripMenuItem";
            this.员工培训管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.员工培训管理ToolStripMenuItem.Text = "员工考勤管理";
            // 
            // 数据库维护ToolStripMenuItem
            // 
            this.数据库维护ToolStripMenuItem.Name = "数据库维护ToolStripMenuItem";
            this.数据库维护ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.数据库维护ToolStripMenuItem.Text = "数据库维护...";
            // 
            // 员工培训管理ToolStripMenuItem1
            // 
            this.员工培训管理ToolStripMenuItem1.Name = "员工培训管理ToolStripMenuItem1";
            this.员工培训管理ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.员工培训管理ToolStripMenuItem1.Text = "员工培训管理";
            // 
            // 员工薪金管理ToolStripMenuItem
            // 
            this.员工薪金管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工月薪管理ToolStripMenuItem,
            this.员工年终奖管理ToolStripMenuItem});
            this.员工薪金管理ToolStripMenuItem.Name = "员工薪金管理ToolStripMenuItem";
            this.员工薪金管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.员工薪金管理ToolStripMenuItem.Text = "员工薪资管理";
            // 
            // 员工月薪管理ToolStripMenuItem
            // 
            this.员工月薪管理ToolStripMenuItem.Name = "员工月薪管理ToolStripMenuItem";
            this.员工月薪管理ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.员工月薪管理ToolStripMenuItem.Text = "员工月薪管理";
            // 
            // 员工年终奖管理ToolStripMenuItem
            // 
            this.员工年终奖管理ToolStripMenuItem.Name = "员工年终奖管理ToolStripMenuItem";
            this.员工年终奖管理ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.员工年终奖管理ToolStripMenuItem.Text = "员工年终奖管理";
            // 
            // 员工数据统计ToolStripMenuItem
            // 
            this.员工数据统计ToolStripMenuItem.Name = "员工数据统计ToolStripMenuItem";
            this.员工数据统计ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.员工数据统计ToolStripMenuItem.Text = "员工数据统计";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem1.Text = "退出";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1131, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1131, 507);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "FastERP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 选项OToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工培训管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工培训管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 员工薪金管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工月薪管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工年终奖管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工数据统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}