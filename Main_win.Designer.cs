namespace Calculator
{
    partial class Main_win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_win));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pamet = new System.Windows.Forms.Button();
            this.pamet_clear = new System.Windows.Forms.Button();
            this.back_space = new System.Windows.Forms.Button();
            this.clear_data = new System.Windows.Forms.Button();
            this.rovna_se = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox_vstup = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_vystup = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nastaveniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tOPWinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pamet, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pamet_clear, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.back_space, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.clear_data, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rovna_se, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(164, 115);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(197, 135);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pamet
            // 
            this.pamet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pamet.Location = new System.Drawing.Point(3, 93);
            this.pamet.Name = "pamet";
            this.pamet.Size = new System.Drawing.Size(59, 39);
            this.pamet.TabIndex = 6;
            this.pamet.Text = "M";
            this.pamet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pamet.UseMnemonic = false;
            this.pamet.UseVisualStyleBackColor = true;
            this.pamet.Click += new System.EventHandler(this.pamet_Click);
            // 
            // pamet_clear
            // 
            this.pamet_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pamet_clear.Location = new System.Drawing.Point(68, 93);
            this.pamet_clear.Name = "pamet_clear";
            this.pamet_clear.Size = new System.Drawing.Size(59, 39);
            this.pamet_clear.TabIndex = 5;
            this.pamet_clear.Text = "MC";
            this.pamet_clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pamet_clear.UseMnemonic = false;
            this.pamet_clear.UseVisualStyleBackColor = true;
            this.pamet_clear.Click += new System.EventHandler(this.pamet_clear_Click);
            // 
            // back_space
            // 
            this.back_space.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.back_space.Location = new System.Drawing.Point(68, 3);
            this.back_space.Name = "back_space";
            this.back_space.Size = new System.Drawing.Size(59, 39);
            this.back_space.TabIndex = 1;
            this.back_space.Text = "->";
            this.back_space.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.back_space.UseMnemonic = false;
            this.back_space.UseVisualStyleBackColor = true;
            this.back_space.Click += new System.EventHandler(this.back_space_Click);
            // 
            // clear_data
            // 
            this.clear_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear_data.Location = new System.Drawing.Point(3, 3);
            this.clear_data.Name = "clear_data";
            this.clear_data.Size = new System.Drawing.Size(59, 39);
            this.clear_data.TabIndex = 0;
            this.clear_data.Text = "CE";
            this.clear_data.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clear_data.UseVisualStyleBackColor = true;
            this.clear_data.Click += new System.EventHandler(this.button1_Click);
            // 
            // rovna_se
            // 
            this.rovna_se.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rovna_se.Location = new System.Drawing.Point(133, 93);
            this.rovna_se.Name = "rovna_se";
            this.rovna_se.Size = new System.Drawing.Size(61, 39);
            this.rovna_se.TabIndex = 4;
            this.rovna_se.Text = "=";
            this.rovna_se.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rovna_se.UseVisualStyleBackColor = true;
            this.rovna_se.Click += new System.EventHandler(this.rovna_se_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "10";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "16";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // textBox_vstup
            // 
            this.textBox_vstup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_vstup.Location = new System.Drawing.Point(82, 27);
            this.textBox_vstup.Name = "textBox_vstup";
            this.textBox_vstup.Size = new System.Drawing.Size(267, 38);
            this.textBox_vstup.TabIndex = 4;
            this.textBox_vstup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_vstup.TextChanged += new System.EventHandler(this.textBox_vstup_TextChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 63);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "2";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(68, 94);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IN-BASE";
            // 
            // textBox_vystup
            // 
            this.textBox_vystup.Enabled = false;
            this.textBox_vystup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_vystup.Location = new System.Drawing.Point(82, 71);
            this.textBox_vystup.Name = "textBox_vystup";
            this.textBox_vystup.Size = new System.Drawing.Size(267, 38);
            this.textBox_vystup.TabIndex = 7;
            this.textBox_vystup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nastaveniToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(365, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nastaveniToolStripMenuItem
            // 
            this.nastaveniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tOPWinToolStripMenuItem});
            this.nastaveniToolStripMenuItem.Name = "nastaveniToolStripMenuItem";
            this.nastaveniToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.nastaveniToolStripMenuItem.Text = "Nastaveni";
            // 
            // tOPWinToolStripMenuItem
            // 
            this.tOPWinToolStripMenuItem.CheckOnClick = true;
            this.tOPWinToolStripMenuItem.Name = "tOPWinToolStripMenuItem";
            this.tOPWinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tOPWinToolStripMenuItem.Text = "TOP win";
            this.tOPWinToolStripMenuItem.Click += new System.EventHandler(this.tOPWinToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Location = new System.Drawing.Point(82, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(79, 94);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OUT-BASE";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(15, 17);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "10";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(15, 63);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.Text = "2";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(15, 40);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(37, 17);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.Text = "16";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "IN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "OUT";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 273);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(365, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(350, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 295);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox_vystup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_vstup);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button clear_data;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox_vstup;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button back_space;
        private System.Windows.Forms.Button rovna_se;
        private System.Windows.Forms.TextBox textBox_vystup;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nastaveniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tOPWinToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pamet;
        private System.Windows.Forms.Button pamet_clear;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

