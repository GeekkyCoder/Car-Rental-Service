namespace CartRentalService
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            CarLableText = new Label();
            CarSelectBox = new ComboBox();
            UserChoosenCarText = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            StatusText = new Label();
            DateText = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(239, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(635, 55);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Cart Rental Service";
            // 
            // CarLableText
            // 
            CarLableText.AutoSize = true;
            CarLableText.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CarLableText.ForeColor = SystemColors.Window;
            CarLableText.Location = new Point(129, 452);
            CarLableText.Margin = new Padding(4, 0, 4, 0);
            CarLableText.Name = "CarLableText";
            CarLableText.Size = new Size(259, 45);
            CarLableText.TabIndex = 1;
            CarLableText.Text = "CHOOSE A CAR :";
            CarLableText.Click += label2_Click;
            // 
            // CarSelectBox
            // 
            CarSelectBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            CarSelectBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            CarSelectBox.DisplayMember = "Dfd";
            CarSelectBox.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            CarSelectBox.FormattingEnabled = true;
            CarSelectBox.ItemHeight = 38;
            CarSelectBox.Items.AddRange(new object[] { "BenZ Z5", "Mercedes", "Tesla", "Toyota", "Suzuki" });
            CarSelectBox.Location = new Point(396, 451);
            CarSelectBox.Margin = new Padding(4, 5, 4, 5);
            CarSelectBox.Name = "CarSelectBox";
            CarSelectBox.Size = new Size(302, 46);
            CarSelectBox.TabIndex = 2;
            CarSelectBox.ValueMember = "fdg";
            CarSelectBox.SelectedIndexChanged += CarSelectBox_SelectedIndexChanged;
            // 
            // UserChoosenCarText
            // 
            UserChoosenCarText.AutoSize = true;
            UserChoosenCarText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            UserChoosenCarText.ForeColor = SystemColors.Highlight;
            UserChoosenCarText.Location = new Point(130, 586);
            UserChoosenCarText.Margin = new Padding(4, 0, 4, 0);
            UserChoosenCarText.Name = "UserChoosenCarText";
            UserChoosenCarText.Size = new Size(151, 38);
            UserChoosenCarText.TabIndex = 3;
            UserChoosenCarText.Text = "Your Car : ";
            UserChoosenCarText.TextAlign = ContentAlignment.MiddleCenter;
            UserChoosenCarText.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(151, 215);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 38);
            label2.TabIndex = 4;
            label2.Text = "CARS :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(295, 215);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 45);
            label3.TabIndex = 5;
            label3.Text = "Tesla";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(484, 215);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(167, 45);
            label4.TabIndex = 6;
            label4.Text = "Mercedes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.GradientActiveCaption;
            label5.Location = new Point(748, 215);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(120, 45);
            label5.TabIndex = 7;
            label5.Text = "Benz Z";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(130, 328);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(120, 38);
            label6.TabIndex = 8;
            label6.Text = "PRICES :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.WindowText;
            label7.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.GradientActiveCaption;
            label7.Location = new Point(295, 321);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(105, 45);
            label7.TabIndex = 9;
            label7.Text = "$1200";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.GradientActiveCaption;
            label8.Location = new Point(499, 319);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(92, 45);
            label8.TabIndex = 10;
            label8.Text = "$800";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.GradientActiveCaption;
            label9.Location = new Point(748, 319);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(92, 45);
            label9.TabIndex = 11;
            label9.Text = "$500";
            // 
            // StatusText
            // 
            StatusText.AutoSize = true;
            StatusText.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            StatusText.ForeColor = SystemColors.GradientActiveCaption;
            StatusText.Location = new Point(130, 651);
            StatusText.Margin = new Padding(4, 0, 4, 0);
            StatusText.Name = "StatusText";
            StatusText.Size = new Size(128, 45);
            StatusText.TabIndex = 12;
            StatusText.Text = "Status :";
            StatusText.Visible = false;
            StatusText.Click += StatusText_Click;
            // 
            // DateText
            // 
            DateText.AutoSize = true;
            DateText.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            DateText.ForeColor = SystemColors.GradientActiveCaption;
            DateText.Location = new Point(130, 718);
            DateText.Margin = new Padding(4, 0, 4, 0);
            DateText.Name = "DateText";
            DateText.Size = new Size(108, 45);
            DateText.TabIndex = 13;
            DateText.Text = "Date :";
            DateText.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1469, 825);
            Controls.Add(DateText);
            Controls.Add(StatusText);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(UserChoosenCarText);
            Controls.Add(CarSelectBox);
            Controls.Add(CarLableText);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CartRentalService";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label CarLableText;
        private ComboBox CarSelectBox;
        private Label UserChoosenCarText;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label StatusText;
        private Label DateText;
    }
}