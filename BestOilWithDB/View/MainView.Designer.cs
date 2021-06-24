
namespace BestOilWithDB.View
{
    partial class MainView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.aznRadiobtn = new System.Windows.Forms.RadioButton();
            this.litrRadiobtn = new System.Windows.Forms.RadioButton();
            this.aznLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.cv = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.totalLbl);
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.aznRadiobtn);
            this.groupBox1.Controls.Add(this.litrRadiobtn);
            this.groupBox1.Controls.Add(this.aznLbl);
            this.groupBox1.Controls.Add(this.priceLbl);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.cv);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gasoline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "AZN";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(97, 309);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(24, 25);
            this.totalLbl.TabIndex = 9;
            this.totalLbl.Text = "0";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Enabled = false;
            this.maskedTextBox2.Location = new System.Drawing.Point(128, 231);
            this.maskedTextBox2.Mask = "00000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 31);
            this.maskedTextBox2.TabIndex = 8;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(128, 178);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 31);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // aznRadiobtn
            // 
            this.aznRadiobtn.AutoSize = true;
            this.aznRadiobtn.Location = new System.Drawing.Point(11, 233);
            this.aznRadiobtn.Name = "aznRadiobtn";
            this.aznRadiobtn.Size = new System.Drawing.Size(72, 29);
            this.aznRadiobtn.TabIndex = 6;
            this.aznRadiobtn.TabStop = true;
            this.aznRadiobtn.Text = "AZN";
            this.aznRadiobtn.UseVisualStyleBackColor = true;
            this.aznRadiobtn.CheckedChanged += new System.EventHandler(this.aznRadiobtn_CheckedChanged);
            // 
            // litrRadiobtn
            // 
            this.litrRadiobtn.AutoSize = true;
            this.litrRadiobtn.Location = new System.Drawing.Point(11, 178);
            this.litrRadiobtn.Name = "litrRadiobtn";
            this.litrRadiobtn.Size = new System.Drawing.Size(60, 29);
            this.litrRadiobtn.TabIndex = 5;
            this.litrRadiobtn.TabStop = true;
            this.litrRadiobtn.Text = "Litr";
            this.litrRadiobtn.UseVisualStyleBackColor = true;
            this.litrRadiobtn.CheckedChanged += new System.EventHandler(this.litrRadiobtn_CheckedChanged);
            // 
            // aznLbl
            // 
            this.aznLbl.AutoSize = true;
            this.aznLbl.Location = new System.Drawing.Point(187, 128);
            this.aznLbl.Name = "aznLbl";
            this.aznLbl.Size = new System.Drawing.Size(54, 25);
            this.aznLbl.TabIndex = 4;
            this.aznLbl.Text = "AZN";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(90, 128);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(24, 25);
            this.priceLbl.TabIndex = 3;
            this.priceLbl.Text = "0";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(6, 128);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(61, 25);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price";
            // 
            // cv
            // 
            this.cv.AutoSize = true;
            this.cv.Location = new System.Drawing.Point(6, 52);
            this.cv.Name = "cv";
            this.cv.Size = new System.Drawing.Size(38, 25);
            this.cv.TabIndex = 1;
            this.cv.Text = "Oil";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.BackColor = System.Drawing.Color.Silver;
            this.CalculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateBtn.Location = new System.Drawing.Point(12, 384);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(254, 37);
            this.CalculateBtn.TabIndex = 1;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = false;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(291, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 342);
            this.listBox1.TabIndex = 2;
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.Silver;
            this.LoadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadBtn.Location = new System.Drawing.Point(291, 384);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(223, 37);
            this.LoadBtn.TabIndex = 3;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainView";
            this.Text = "MainView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RadioButton aznRadiobtn;
        private System.Windows.Forms.RadioButton litrRadiobtn;
        private System.Windows.Forms.Label aznLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label cv;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button LoadBtn;
    }
}