namespace PedestrianSensingRadar
{
    partial class MessageCenter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox_showmessage = new System.Windows.Forms.ListBox();
            this.timer_rec = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox_showmessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // listBox_showmessage
            // 
            this.listBox_showmessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_showmessage.FormattingEnabled = true;
            this.listBox_showmessage.ItemHeight = 12;
            this.listBox_showmessage.Location = new System.Drawing.Point(0, 0);
            this.listBox_showmessage.Name = "listBox_showmessage";
            this.listBox_showmessage.Size = new System.Drawing.Size(800, 450);
            this.listBox_showmessage.TabIndex = 0;
            // 
            // timer_rec
            // 
            this.timer_rec.Enabled = true;
            this.timer_rec.Tick += new System.EventHandler(this.timer_rec_Tick);
            // 
            // MessageCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MessageCenter";
            this.Text = "MessageCenter";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox_showmessage;
        private System.Windows.Forms.Timer timer_rec;
    }
}