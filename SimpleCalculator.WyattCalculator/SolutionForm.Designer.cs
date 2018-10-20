namespace SimpleCalculator.WyattCalculator
{
    partial class SolutionForm
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
            this.lbl_subtitle = new System.Windows.Forms.Label();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.lbl_unitanswer = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_sentence = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_subtitle
            // 
            this.lbl_subtitle.AutoSize = true;
            this.lbl_subtitle.Location = new System.Drawing.Point(102, 9);
            this.lbl_subtitle.Name = "lbl_subtitle";
            this.lbl_subtitle.Size = new System.Drawing.Size(70, 13);
            this.lbl_subtitle.TabIndex = 0;
            this.lbl_subtitle.Text = "You will need";
            // 
            // lbl_answer
            // 
            this.lbl_answer.AutoSize = true;
            this.lbl_answer.Location = new System.Drawing.Point(102, 37);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Size = new System.Drawing.Size(42, 13);
            this.lbl_answer.TabIndex = 1;
            this.lbl_answer.Text = "FENCE";
            // 
            // lbl_unitanswer
            // 
            this.lbl_unitanswer.AutoSize = true;
            this.lbl_unitanswer.Location = new System.Drawing.Point(150, 37);
            this.lbl_unitanswer.Name = "lbl_unitanswer";
            this.lbl_unitanswer.Size = new System.Drawing.Size(33, 13);
            this.lbl_unitanswer.TabIndex = 2;
            this.lbl_unitanswer.Text = "UNIT";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(97, 122);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_sentence
            // 
            this.lbl_sentence.AutoSize = true;
            this.lbl_sentence.Location = new System.Drawing.Point(108, 79);
            this.lbl_sentence.Name = "lbl_sentence";
            this.lbl_sentence.Size = new System.Drawing.Size(49, 13);
            this.lbl_sentence.TabIndex = 4;
            this.lbl_sentence.Text = "of fence.";
            // 
            // SolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 157);
            this.Controls.Add(this.lbl_sentence);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_unitanswer);
            this.Controls.Add(this.lbl_answer);
            this.Controls.Add(this.lbl_subtitle);
            this.Name = "SolutionForm";
            this.Text = "SolutionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_subtitle;
        private System.Windows.Forms.Label lbl_answer;
        private System.Windows.Forms.Label lbl_unitanswer;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_sentence;
    }
}