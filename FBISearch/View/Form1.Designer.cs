namespace FBISearch
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Publication = new System.Windows.Forms.Label();
            this.infoContainer = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.TextBox();
            this.formatInfo = new System.Windows.Forms.WebBrowser();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.eyes = new System.Windows.Forms.TextBox();
            this.race = new System.Windows.Forms.TextBox();
            this.hair = new System.Windows.Forms.TextBox();
            this.personsFound = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.total = new System.Windows.Forms.Label();
            this.downloadPDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.personPic = new System.Windows.Forms.PictureBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.fullName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.wantedList = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tabCtrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.infoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personPic)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wantedList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabPage1);
            this.tabCtrl.Controls.Add(this.tabPage2);
            this.tabCtrl.Location = new System.Drawing.Point(-2, 1);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(893, 764);
            this.tabCtrl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MidnightBlue;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.Publication);
            this.tabPage1.Controls.Add(this.infoContainer);
            this.tabPage1.Controls.Add(this.personsFound);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.total);
            this.tabPage1.Controls.Add(this.downloadPDF);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.personPic);
            this.tabPage1.Controls.Add(this.searchBtn);
            this.tabPage1.Controls.Add(this.fullName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(885, 738);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            // 
            // Publication
            // 
            this.Publication.AutoSize = true;
            this.Publication.Location = new System.Drawing.Point(588, 422);
            this.Publication.Name = "Publication";
            this.Publication.Size = new System.Drawing.Size(62, 13);
            this.Publication.TabIndex = 15;
            this.Publication.Text = "Publication:";
            this.Publication.Click += new System.EventHandler(this.Publication_Click);
            // 
            // infoContainer
            // 
            this.infoContainer.Controls.Add(this.label7);
            this.infoContainer.Controls.Add(this.sex);
            this.infoContainer.Controls.Add(this.formatInfo);
            this.infoContainer.Controls.Add(this.label6);
            this.infoContainer.Controls.Add(this.label5);
            this.infoContainer.Controls.Add(this.label4);
            this.infoContainer.Controls.Add(this.label3);
            this.infoContainer.Controls.Add(this.label2);
            this.infoContainer.Controls.Add(this.height);
            this.infoContainer.Controls.Add(this.weight);
            this.infoContainer.Controls.Add(this.eyes);
            this.infoContainer.Controls.Add(this.race);
            this.infoContainer.Controls.Add(this.hair);
            this.infoContainer.Location = new System.Drawing.Point(34, 227);
            this.infoContainer.Name = "infoContainer";
            this.infoContainer.Size = new System.Drawing.Size(529, 444);
            this.infoContainer.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Sex:";
            // 
            // sex
            // 
            this.sex.Enabled = false;
            this.sex.Location = new System.Drawing.Point(56, 127);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(135, 20);
            this.sex.TabIndex = 24;
            // 
            // formatInfo
            // 
            this.formatInfo.Location = new System.Drawing.Point(19, 231);
            this.formatInfo.MinimumSize = new System.Drawing.Size(20, 20);
            this.formatInfo.Name = "formatInfo";
            this.formatInfo.Size = new System.Drawing.Size(466, 193);
            this.formatInfo.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Race:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hair:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Eyes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Weight:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Height:";
            // 
            // height
            // 
            this.height.Enabled = false;
            this.height.Location = new System.Drawing.Point(313, 131);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(172, 20);
            this.height.TabIndex = 18;
            // 
            // weight
            // 
            this.weight.Enabled = false;
            this.weight.Location = new System.Drawing.Point(313, 77);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(172, 20);
            this.weight.TabIndex = 17;
            // 
            // eyes
            // 
            this.eyes.Enabled = false;
            this.eyes.Location = new System.Drawing.Point(313, 32);
            this.eyes.Name = "eyes";
            this.eyes.Size = new System.Drawing.Size(172, 20);
            this.eyes.TabIndex = 16;
            // 
            // race
            // 
            this.race.Enabled = false;
            this.race.Location = new System.Drawing.Point(56, 77);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(135, 20);
            this.race.TabIndex = 15;
            // 
            // hair
            // 
            this.hair.Enabled = false;
            this.hair.Location = new System.Drawing.Point(56, 32);
            this.hair.Name = "hair";
            this.hair.Size = new System.Drawing.Size(135, 20);
            this.hair.TabIndex = 14;
            // 
            // personsFound
            // 
            this.personsFound.FormattingEnabled = true;
            this.personsFound.Location = new System.Drawing.Point(53, 176);
            this.personsFound.Name = "personsFound";
            this.personsFound.Size = new System.Drawing.Size(466, 21);
            this.personsFound.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(591, 458);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 193);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(50, 157);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(44, 13);
            this.total.TabIndex = 7;
            this.total.Text = "Total: ";
            // 
            // downloadPDF
            // 
            this.downloadPDF.Location = new System.Drawing.Point(617, 379);
            this.downloadPDF.Name = "downloadPDF";
            this.downloadPDF.Size = new System.Drawing.Size(151, 31);
            this.downloadPDF.TabIndex = 5;
            this.downloadPDF.Text = "Download info";
            this.downloadPDF.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // personPic
            // 
            this.personPic.BackColor = System.Drawing.Color.Transparent;
            this.personPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("personPic.InitialImage")));
            this.personPic.Location = new System.Drawing.Point(591, 176);
            this.personPic.Name = "personPic";
            this.personPic.Size = new System.Drawing.Size(204, 177);
            this.personPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.personPic.TabIndex = 4;
            this.personPic.TabStop = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(348, 78);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(171, 20);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search person";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(53, 78);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(279, 20);
            this.fullName.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.wantedList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(885, 738);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Top 10 Wanted Criminals";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(618, 467);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 193);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // wantedList
            // 
            this.wantedList.AllowUserToDeleteRows = false;
            this.wantedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wantedList.Location = new System.Drawing.Point(101, 100);
            this.wantedList.Name = "wantedList";
            this.wantedList.ReadOnly = true;
            this.wantedList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wantedList.Size = new System.Drawing.Size(644, 313);
            this.wantedList.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(235, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(351, 36);
            this.label8.TabIndex = 10;
            this.label8.Text = "Top 10 Wanted Criminals";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 695);
            this.Controls.Add(this.tabCtrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabCtrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.infoContainer.ResumeLayout(false);
            this.infoContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personPic)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wantedList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TabControl tabCtrl;
        public System.Windows.Forms.DataGridView wantedList;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Panel infoContainer;
        public System.Windows.Forms.WebBrowser formatInfo;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox height;
        public System.Windows.Forms.TextBox weight;
        public System.Windows.Forms.TextBox eyes;
        public System.Windows.Forms.TextBox race;
        public System.Windows.Forms.TextBox hair;
        public System.Windows.Forms.ComboBox personsFound;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label total;
        public System.Windows.Forms.Button downloadPDF;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox personPic;
        public System.Windows.Forms.Button searchBtn;
        public System.Windows.Forms.TextBox fullName;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox sex;
        public System.Windows.Forms.Label Publication;
        private System.Windows.Forms.Label label8;
    }
}

