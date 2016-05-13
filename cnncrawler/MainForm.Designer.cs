namespace cnncrawler
{
    partial class frmMain
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
            this.btnCrawCnnTech = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstCnnTech = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstCnnPolitics = new System.Windows.Forms.ListBox();
            this.btnCrawlCnnPolitics = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lstCnnTravel = new System.Windows.Forms.ListBox();
            this.btnCrawlCnnTravel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrawCnnTech
            // 
            this.btnCrawCnnTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCrawCnnTech.Location = new System.Drawing.Point(377, 175);
            this.btnCrawCnnTech.Name = "btnCrawCnnTech";
            this.btnCrawCnnTech.Size = new System.Drawing.Size(162, 53);
            this.btnCrawCnnTech.TabIndex = 0;
            this.btnCrawCnnTech.Text = "Crawling CNN Tech";
            this.btnCrawCnnTech.UseVisualStyleBackColor = false;
            this.btnCrawCnnTech.Click += new System.EventHandler(this.btnCrawlCnnTech_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnCrawCnnTech);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CNN TECH";
            // 
            // lstCnnTech
            // 
            this.lstCnnTech.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCnnTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCnnTech.ForeColor = System.Drawing.Color.Blue;
            this.lstCnnTech.FormattingEnabled = true;
            this.lstCnnTech.ItemHeight = 16;
            this.lstCnnTech.Location = new System.Drawing.Point(3, 18);
            this.lstCnnTech.Name = "lstCnnTech";
            this.lstCnnTech.Size = new System.Drawing.Size(525, 126);
            this.lstCnnTech.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstCnnTech);
            this.groupBox2.Location = new System.Drawing.Point(11, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 147);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Top 3 HeadLine:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btnCrawlCnnPolitics);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(556, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(545, 239);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CNN POLITICS";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstCnnPolitics);
            this.groupBox4.Location = new System.Drawing.Point(11, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(528, 147);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Top 3 HeadLine:";
            // 
            // lstCnnPolitics
            // 
            this.lstCnnPolitics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCnnPolitics.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCnnPolitics.ForeColor = System.Drawing.Color.Blue;
            this.lstCnnPolitics.FormattingEnabled = true;
            this.lstCnnPolitics.ItemHeight = 16;
            this.lstCnnPolitics.Location = new System.Drawing.Point(3, 18);
            this.lstCnnPolitics.Name = "lstCnnPolitics";
            this.lstCnnPolitics.Size = new System.Drawing.Size(522, 126);
            this.lstCnnPolitics.TabIndex = 1;
            // 
            // btnCrawlCnnPolitics
            // 
            this.btnCrawlCnnPolitics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCrawlCnnPolitics.Location = new System.Drawing.Point(374, 175);
            this.btnCrawlCnnPolitics.Name = "btnCrawlCnnPolitics";
            this.btnCrawlCnnPolitics.Size = new System.Drawing.Size(162, 53);
            this.btnCrawlCnnPolitics.TabIndex = 0;
            this.btnCrawlCnnPolitics.Text = "Crawling CNN Politics";
            this.btnCrawlCnnPolitics.UseVisualStyleBackColor = false;
            this.btnCrawlCnnPolitics.Click += new System.EventHandler(this.btnCrawlCnnPolitics_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.btnCrawlCnnTravel);
            this.groupBox5.ForeColor = System.Drawing.Color.Blue;
            this.groupBox5.Location = new System.Drawing.Point(2, 246);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(548, 239);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CNN TRAVEL";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lstCnnTravel);
            this.groupBox6.Location = new System.Drawing.Point(11, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(531, 147);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Top 3 HeadLine:";
            // 
            // lstCnnTravel
            // 
            this.lstCnnTravel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCnnTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCnnTravel.ForeColor = System.Drawing.Color.Blue;
            this.lstCnnTravel.FormattingEnabled = true;
            this.lstCnnTravel.ItemHeight = 16;
            this.lstCnnTravel.Location = new System.Drawing.Point(3, 18);
            this.lstCnnTravel.Name = "lstCnnTravel";
            this.lstCnnTravel.Size = new System.Drawing.Size(525, 126);
            this.lstCnnTravel.TabIndex = 1;
            // 
            // btnCrawlCnnTravel
            // 
            this.btnCrawlCnnTravel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCrawlCnnTravel.Location = new System.Drawing.Point(377, 175);
            this.btnCrawlCnnTravel.Name = "btnCrawlCnnTravel";
            this.btnCrawlCnnTravel.Size = new System.Drawing.Size(162, 53);
            this.btnCrawlCnnTravel.TabIndex = 0;
            this.btnCrawlCnnTravel.Text = "Crawling CNN Travel";
            this.btnCrawlCnnTravel.UseVisualStyleBackColor = false;
            this.btnCrawlCnnTravel.Click += new System.EventHandler(this.btnCrawlCnnTravel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 492);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrawCnnTech;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstCnnTech;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstCnnPolitics;
        private System.Windows.Forms.Button btnCrawlCnnPolitics;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lstCnnTravel;
        private System.Windows.Forms.Button btnCrawlCnnTravel;
    }
}

