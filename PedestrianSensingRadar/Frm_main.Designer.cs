namespace PedestrianSensingRadar
{
    partial class Frm_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_communicate = new System.Windows.Forms.Panel();
            this.btn_message = new System.Windows.Forms.Button();
            this.btn_opencan = new System.Windows.Forms.Button();
            this.groupBox_setting = new System.Windows.Forms.GroupBox();
            this.btn_rebuild = new System.Windows.Forms.Button();
            this.btn_sensitivity = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_write = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_rec = new System.Windows.Forms.Timer(this.components);
            this.panel_show = new System.Windows.Forms.Panel();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel_area = new System.Windows.Forms.Panel();
            this.pb_area = new System.Windows.Forms.PictureBox();
            this.panel_communicate.SuspendLayout();
            this.groupBox_setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel_show.SuspendLayout();
            this.panel_area.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_area)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_communicate
            // 
            this.panel_communicate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_communicate.Controls.Add(this.btn_opencan);
            this.panel_communicate.Controls.Add(this.groupBox_setting);
            this.panel_communicate.Controls.Add(this.btn_message);
            this.panel_communicate.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_communicate.Location = new System.Drawing.Point(0, 0);
            this.panel_communicate.Name = "panel_communicate";
            this.panel_communicate.Size = new System.Drawing.Size(267, 556);
            this.panel_communicate.TabIndex = 0;
            // 
            // btn_message
            // 
            this.btn_message.Location = new System.Drawing.Point(69, 403);
            this.btn_message.Name = "btn_message";
            this.btn_message.Size = new System.Drawing.Size(75, 23);
            this.btn_message.TabIndex = 2;
            this.btn_message.Text = "消息中心";
            this.btn_message.UseVisualStyleBackColor = true;
            this.btn_message.Click += new System.EventHandler(this.btn_message_Click);
            // 
            // btn_opencan
            // 
            this.btn_opencan.Location = new System.Drawing.Point(69, 460);
            this.btn_opencan.Name = "btn_opencan";
            this.btn_opencan.Size = new System.Drawing.Size(75, 23);
            this.btn_opencan.TabIndex = 0;
            this.btn_opencan.Text = "打开CAN";
            this.btn_opencan.UseVisualStyleBackColor = true;
            this.btn_opencan.Click += new System.EventHandler(this.btn_opencan_Click);
            // 
            // groupBox_setting
            // 
            this.groupBox_setting.Controls.Add(this.btn_rebuild);
            this.groupBox_setting.Controls.Add(this.btn_sensitivity);
            this.groupBox_setting.Controls.Add(this.numericUpDown1);
            this.groupBox_setting.Controls.Add(this.btn_write);
            this.groupBox_setting.Controls.Add(this.btn_read);
            this.groupBox_setting.Controls.Add(this.textBox4);
            this.groupBox_setting.Controls.Add(this.textBox3);
            this.groupBox_setting.Controls.Add(this.label6);
            this.groupBox_setting.Controls.Add(this.label5);
            this.groupBox_setting.Controls.Add(this.textBox2);
            this.groupBox_setting.Controls.Add(this.textBox1);
            this.groupBox_setting.Controls.Add(this.label3);
            this.groupBox_setting.Controls.Add(this.label4);
            this.groupBox_setting.Controls.Add(this.label2);
            this.groupBox_setting.Controls.Add(this.label1);
            this.groupBox_setting.Location = new System.Drawing.Point(12, 69);
            this.groupBox_setting.Name = "groupBox_setting";
            this.groupBox_setting.Size = new System.Drawing.Size(229, 254);
            this.groupBox_setting.TabIndex = 0;
            this.groupBox_setting.TabStop = false;
            this.groupBox_setting.Text = "参数设置";
            // 
            // btn_rebuild
            // 
            this.btn_rebuild.Location = new System.Drawing.Point(148, 204);
            this.btn_rebuild.Name = "btn_rebuild";
            this.btn_rebuild.Size = new System.Drawing.Size(75, 23);
            this.btn_rebuild.TabIndex = 15;
            this.btn_rebuild.Text = "重建背景";
            this.btn_rebuild.UseVisualStyleBackColor = true;
            // 
            // btn_sensitivity
            // 
            this.btn_sensitivity.Location = new System.Drawing.Point(57, 204);
            this.btn_sensitivity.Name = "btn_sensitivity";
            this.btn_sensitivity.Size = new System.Drawing.Size(75, 23);
            this.btn_sensitivity.TabIndex = 14;
            this.btn_sensitivity.Text = "灵敏度设置";
            this.btn_sensitivity.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(9, 204);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(32, 21);
            this.numericUpDown1.TabIndex = 13;
            // 
            // btn_write
            // 
            this.btn_write.Location = new System.Drawing.Point(97, 162);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(75, 23);
            this.btn_write.TabIndex = 12;
            this.btn_write.Text = "写入";
            this.btn_write.UseVisualStyleBackColor = true;
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(9, 162);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 23);
            this.btn_read.TabIndex = 11;
            this.btn_read.Text = "读取";
            this.btn_read.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(138, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(54, 21);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 21);
            this.textBox3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "水平角度偏移（0.01度）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "安装高度偏移（厘米）";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 21);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 21);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y坐标（厘米）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "X坐标（厘米）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "行人模式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "雷达模式：";
            // 
            // timer_rec
            // 
            this.timer_rec.Tick += new System.EventHandler(this.timer_rec_Tick);
            // 
            // panel_show
            // 
            this.panel_show.Controls.Add(this.panel_area);
            this.panel_show.Controls.Add(this.panel_top);
            this.panel_show.Controls.Add(this.panel_bottom);
            this.panel_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_show.Location = new System.Drawing.Point(267, 0);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(847, 556);
            this.panel_show.TabIndex = 1;
            // 
            // panel_bottom
            // 
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 506);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(847, 50);
            this.panel_bottom.TabIndex = 0;
            // 
            // panel_top
            // 
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(847, 35);
            this.panel_top.TabIndex = 1;
            // 
            // panel_area
            // 
            this.panel_area.Controls.Add(this.pb_area);
            this.panel_area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_area.Location = new System.Drawing.Point(0, 35);
            this.panel_area.Name = "panel_area";
            this.panel_area.Size = new System.Drawing.Size(847, 471);
            this.panel_area.TabIndex = 2;
            // 
            // pb_area
            // 
            this.pb_area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_area.Location = new System.Drawing.Point(0, 0);
            this.pb_area.Name = "pb_area";
            this.pb_area.Size = new System.Drawing.Size(847, 471);
            this.pb_area.TabIndex = 0;
            this.pb_area.TabStop = false;
            this.pb_area.SizeChanged += new System.EventHandler(this.pb_area_SizeChanged);
            this.pb_area.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_area_Paint_1);
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 556);
            this.Controls.Add(this.panel_show);
            this.Controls.Add(this.panel_communicate);
            this.Name = "Frm_main";
            this.Text = "行人感知雷达";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_communicate.ResumeLayout(false);
            this.groupBox_setting.ResumeLayout(false);
            this.groupBox_setting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel_show.ResumeLayout(false);
            this.panel_area.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_area)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_communicate;
        private System.Windows.Forms.GroupBox groupBox_setting;
        private System.Windows.Forms.Button btn_rebuild;
        private System.Windows.Forms.Button btn_sensitivity;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_opencan;
        private System.Windows.Forms.Timer timer_rec;
        private System.Windows.Forms.Panel panel_show;
        private System.Windows.Forms.Button btn_message;
        private System.Windows.Forms.Panel panel_area;
        private System.Windows.Forms.PictureBox pb_area;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_bottom;
    }
}

