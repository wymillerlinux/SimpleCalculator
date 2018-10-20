namespace SimpleCalculator.WyattCalculator
{
    partial class frm_mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mainWindow));
            this.lbl_title = new System.Windows.Forms.Label();
            this.PicBox_image = new System.Windows.Forms.PictureBox();
            this.radBtn_english = new System.Windows.Forms.RadioButton();
            this.radBtn_metric = new System.Windows.Forms.RadioButton();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.lbl_width = new System.Windows.Forms.Label();
            this.lbl_length = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.txtBtn_widthEntry = new System.Windows.Forms.TextBox();
            this.txtBtn_heightEntry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(196, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(399, 37);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "SimFarm Fence Calculator";
            // 
            // PicBox_image
            // 
            this.PicBox_image.Image = ((System.Drawing.Image)(resources.GetObject("PicBox_image.Image")));
            this.PicBox_image.InitialImage = ((System.Drawing.Image)(resources.GetObject("PicBox_image.InitialImage")));
            this.PicBox_image.Location = new System.Drawing.Point(12, 12);
            this.PicBox_image.Name = "PicBox_image";
            this.PicBox_image.Size = new System.Drawing.Size(178, 223);
            this.PicBox_image.TabIndex = 1;
            this.PicBox_image.TabStop = false;
            // 
            // radBtn_english
            // 
            this.radBtn_english.AutoSize = true;
            this.radBtn_english.Location = new System.Drawing.Point(203, 61);
            this.radBtn_english.Name = "radBtn_english";
            this.radBtn_english.Size = new System.Drawing.Size(59, 17);
            this.radBtn_english.TabIndex = 2;
            this.radBtn_english.TabStop = true;
            this.radBtn_english.Text = "English";
            this.radBtn_english.UseVisualStyleBackColor = true;
            this.radBtn_english.CheckedChanged += new System.EventHandler(this.radBtn_english_CheckedChanged);
            // 
            // radBtn_metric
            // 
            this.radBtn_metric.AutoSize = true;
            this.radBtn_metric.Location = new System.Drawing.Point(268, 61);
            this.radBtn_metric.Name = "radBtn_metric";
            this.radBtn_metric.Size = new System.Drawing.Size(54, 17);
            this.radBtn_metric.TabIndex = 3;
            this.radBtn_metric.TabStop = true;
            this.radBtn_metric.Text = "Metric";
            this.radBtn_metric.UseVisualStyleBackColor = true;
            this.radBtn_metric.CheckedChanged += new System.EventHandler(this.radBtn_metric_CheckedChanged);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(203, 212);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 4;
            this.btn_calculate.Text = "Calculate Fence";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(520, 212);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(75, 23);
            this.btn_help.TabIndex = 5;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // lbl_width
            // 
            this.lbl_width.AutoSize = true;
            this.lbl_width.Location = new System.Drawing.Point(309, 115);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(35, 13);
            this.lbl_width.TabIndex = 8;
            this.lbl_width.Text = "Width";
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Location = new System.Drawing.Point(309, 144);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(40, 13);
            this.lbl_length.TabIndex = 9;
            this.lbl_length.Text = "Length";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(439, 212);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "Exit";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txtBtn_widthEntry
            // 
            this.txtBtn_widthEntry.Location = new System.Drawing.Point(203, 112);
            this.txtBtn_widthEntry.Name = "txtBtn_widthEntry";
            this.txtBtn_widthEntry.Size = new System.Drawing.Size(100, 20);
            this.txtBtn_widthEntry.TabIndex = 11;
            // 
            // txtBtn_heightEntry
            // 
            this.txtBtn_heightEntry.Location = new System.Drawing.Point(203, 141);
            this.txtBtn_heightEntry.Name = "txtBtn_heightEntry";
            this.txtBtn_heightEntry.Size = new System.Drawing.Size(100, 20);
            this.txtBtn_heightEntry.TabIndex = 12;
            // 
            // frm_mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 261);
            this.Controls.Add(this.txtBtn_heightEntry);
            this.Controls.Add(this.txtBtn_widthEntry);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_length);
            this.Controls.Add(this.lbl_width);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.radBtn_metric);
            this.Controls.Add(this.radBtn_english);
            this.Controls.Add(this.PicBox_image);
            this.Controls.Add(this.lbl_title);
            this.Name = "frm_mainWindow";
            this.Text = "SimFarm Fence Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox PicBox_image;
        private System.Windows.Forms.RadioButton radBtn_english;
        private System.Windows.Forms.RadioButton radBtn_metric;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txtBtn_widthEntry;
        private System.Windows.Forms.TextBox txtBtn_heightEntry;
    }
}

