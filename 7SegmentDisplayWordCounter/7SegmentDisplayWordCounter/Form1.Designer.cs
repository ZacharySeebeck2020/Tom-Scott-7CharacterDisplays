namespace _7SegmentDisplayWordCounter
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
            this.label1 = new System.Windows.Forms.Label();
            this.longestAccepableWord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalWordCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.longestWordLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total word count: ";
            // 
            // longestAccepableWord
            // 
            this.longestAccepableWord.AutoSize = true;
            this.longestAccepableWord.Location = new System.Drawing.Point(150, 37);
            this.longestAccepableWord.Name = "longestAccepableWord";
            this.longestAccepableWord.Size = new System.Drawing.Size(0, 13);
            this.longestAccepableWord.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Longest acceptibale word.";
            // 
            // totalWordCount
            // 
            this.totalWordCount.AutoSize = true;
            this.totalWordCount.Location = new System.Drawing.Point(150, 9);
            this.totalWordCount.Name = "totalWordCount";
            this.totalWordCount.Size = new System.Drawing.Size(0, 13);
            this.totalWordCount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Longest word length.";
            // 
            // longestWordLength
            // 
            this.longestWordLength.AutoSize = true;
            this.longestWordLength.Location = new System.Drawing.Point(150, 71);
            this.longestWordLength.Name = "longestWordLength";
            this.longestWordLength.Size = new System.Drawing.Size(0, 13);
            this.longestWordLength.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 157);
            this.Controls.Add(this.longestWordLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalWordCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.longestAccepableWord);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "7 Segment Display Word Counter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label longestAccepableWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalWordCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label longestWordLength;
    }
}

