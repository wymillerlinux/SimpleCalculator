namespace SimpleCalculator.WyattCalculator
{
    partial class HelpForm
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
            this.lbl_helpTitle = new System.Windows.Forms.Label();
            this.lbl_directions = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_helpTitle
            // 
            this.lbl_helpTitle.AutoSize = true;
            this.lbl_helpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_helpTitle.Location = new System.Drawing.Point(110, 9);
            this.lbl_helpTitle.Name = "lbl_helpTitle";
            this.lbl_helpTitle.Size = new System.Drawing.Size(234, 20);
            this.lbl_helpTitle.TabIndex = 0;
            this.lbl_helpTitle.Text = "SimFarm Fence Calculator Help";
            // 
            // lbl_directions
            // 
            this.lbl_directions.AutoSize = true;
            this.lbl_directions.Location = new System.Drawing.Point(111, 60);
            this.lbl_directions.Name = "lbl_directions";
            this.lbl_directions.Size = new System.Drawing.Size(35, 13);
            this.lbl_directions.TabIndex = 1;
            this.lbl_directions.Text = "label1";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(197, 276);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 311);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_directions);
            this.Controls.Add(this.lbl_helpTitle);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_helpTitle;
        private System.Windows.Forms.Label lbl_directions;
        private System.Windows.Forms.Button btn_close;
    }
}