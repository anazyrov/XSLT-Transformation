namespace XSLT___Transformation
{
    partial class frmMain
    {
        private Button btnOpenFile;
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.inputFile = new System.Windows.Forms.RichTextBox();
            this.outputFile = new System.Windows.Forms.RichTextBox();
            this.lblInputFile = new System.Windows.Forms.Label();
            this.lblOutputFile = new System.Windows.Forms.Label();
            this.btnTransformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(166, 685);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(151, 59);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Открыть файл";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // inputFile
            // 
            this.inputFile.Location = new System.Drawing.Point(12, 70);
            this.inputFile.Name = "inputFile";
            this.inputFile.Size = new System.Drawing.Size(497, 587);
            this.inputFile.TabIndex = 2;
            this.inputFile.Text = "";
            // 
            // outputFile
            // 
            this.outputFile.Location = new System.Drawing.Point(546, 70);
            this.outputFile.Name = "outputFile";
            this.outputFile.Size = new System.Drawing.Size(497, 587);
            this.outputFile.TabIndex = 3;
            this.outputFile.Text = "";
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.Location = new System.Drawing.Point(169, 26);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(140, 25);
            this.lblInputFile.TabIndex = 4;
            this.lblInputFile.Text = "Исходный файл";
            // 
            // lblOutputFile
            // 
            this.lblOutputFile.AutoSize = true;
            this.lblOutputFile.Location = new System.Drawing.Point(752, 26);
            this.lblOutputFile.Name = "lblOutputFile";
            this.lblOutputFile.Size = new System.Drawing.Size(89, 25);
            this.lblOutputFile.TabIndex = 5;
            this.lblOutputFile.Text = "Результат";
            // 
            // btnTransformation
            // 
            this.btnTransformation.Location = new System.Drawing.Point(719, 685);
            this.btnTransformation.Name = "btnTransformation";
            this.btnTransformation.Size = new System.Drawing.Size(148, 59);
            this.btnTransformation.TabIndex = 6;
            this.btnTransformation.Text = "Преобразовать";
            this.btnTransformation.UseVisualStyleBackColor = true;
            this.btnTransformation.Click += new System.EventHandler(this.btnTransformation_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 756);
            this.Controls.Add(this.btnTransformation);
            this.Controls.Add(this.lblOutputFile);
            this.Controls.Add(this.lblInputFile);
            this.Controls.Add(this.outputFile);
            this.Controls.Add(this.inputFile);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XSLT - Transformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private RichTextBox inputFile;
        private RichTextBox outputFile;
        private Label lblInputFile;
        private Label lblOutputFile;
        private Button btnTransformation;
    }
}