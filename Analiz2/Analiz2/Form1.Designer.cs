namespace Analiz2
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
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.pdfButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(21, 41);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(258, 26);
            this.filePathTextBox.TabIndex = 0;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(21, 77);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(258, 193);
            this.resultTextBox.TabIndex = 1;
            this.resultTextBox.Text = "";
            // 
            // loadButton
            // 
            this.loadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadButton.Location = new System.Drawing.Point(310, 41);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(130, 35);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Dosya Yükle";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // analyzeButton
            // 
            this.analyzeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.analyzeButton.Location = new System.Drawing.Point(310, 82);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(132, 35);
            this.analyzeButton.TabIndex = 3;
            this.analyzeButton.Text = "Analiz";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // pdfButton
            // 
            this.pdfButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pdfButton.Location = new System.Drawing.Point(310, 123);
            this.pdfButton.Name = "pdfButton";
            this.pdfButton.Size = new System.Drawing.Size(130, 35);
            this.pdfButton.TabIndex = 4;
            this.pdfButton.Text = "Word Dosyası ";
            this.pdfButton.UseVisualStyleBackColor = true;
            this.pdfButton.Click += new System.EventHandler(this.pdfButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(460, 301);
            this.Controls.Add(this.pdfButton);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.filePathTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Analizci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.Button pdfButton;
    }
}

