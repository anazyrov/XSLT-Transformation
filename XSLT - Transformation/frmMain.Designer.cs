namespace XSLT___Transformation
{
    partial class frmMain
    {
        private Button btnOpenFileXML;
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
            this.btnOpenFileXML = new System.Windows.Forms.Button();
            this.inputFile = new System.Windows.Forms.RichTextBox();
            this.outputFile = new System.Windows.Forms.RichTextBox();
            this.lblInputFile = new System.Windows.Forms.Label();
            this.lblOutputFile = new System.Windows.Forms.Label();
            this.btnTransformation = new System.Windows.Forms.Button();
            this.btnOpenFileXSL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFileXML
            // 
            this.btnOpenFileXML.Location = new System.Drawing.Point(166, 685);
            this.btnOpenFileXML.Name = "btnOpenFileXML";
            this.btnOpenFileXML.Size = new System.Drawing.Size(151, 59);
            this.btnOpenFileXML.TabIndex = 0;
            this.btnOpenFileXML.Text = "Открыть файл XML";
            this.btnOpenFileXML.UseVisualStyleBackColor = true;
            this.btnOpenFileXML.Click += new System.EventHandler(this.btnOpenFileXML_Click);
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
            this.btnTransformation.Location = new System.Drawing.Point(733, 685);
            this.btnTransformation.Name = "btnTransformation";
            this.btnTransformation.Size = new System.Drawing.Size(148, 59);
            this.btnTransformation.TabIndex = 6;
            this.btnTransformation.Text = "Преобразовать";
            this.btnTransformation.UseVisualStyleBackColor = true;
            this.btnTransformation.Click += new System.EventHandler(this.btnTransformation_Click);
            // 
            // btnOpenFileXSL
            // 
            this.btnOpenFileXSL.Location = new System.Drawing.Point(452, 685);
            this.btnOpenFileXSL.Name = "btnOpenFileXSL";
            this.btnOpenFileXSL.Size = new System.Drawing.Size(151, 59);
            this.btnOpenFileXSL.TabIndex = 7;
            this.btnOpenFileXSL.Text = "Выбрать файл XSL";
            this.btnOpenFileXSL.UseVisualStyleBackColor = true;
            this.btnOpenFileXSL.Click += new System.EventHandler(this.btnOpenFileXSL_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 756);
            this.Controls.Add(this.btnOpenFileXSL);
            this.Controls.Add(this.btnTransformation);
            this.Controls.Add(this.lblOutputFile);
            this.Controls.Add(this.lblInputFile);
            this.Controls.Add(this.outputFile);
            this.Controls.Add(this.inputFile);
            this.Controls.Add(this.btnOpenFileXML);
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
        private Button btnOpenFileXSL;
    }
}