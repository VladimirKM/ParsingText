namespace ParsingText
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRead = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tboxFileName = new System.Windows.Forms.TextBox();
            this.ChoiceFile = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(26, 125);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Прочитать";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.*";
            // 
            // tboxFileName
            // 
            this.tboxFileName.Location = new System.Drawing.Point(144, 48);
            this.tboxFileName.Name = "tboxFileName";
            this.tboxFileName.Size = new System.Drawing.Size(394, 20);
            this.tboxFileName.TabIndex = 2;
            // 
            // ChoiceFile
            // 
            this.ChoiceFile.Location = new System.Drawing.Point(26, 45);
            this.ChoiceFile.Name = "ChoiceFile";
            this.ChoiceFile.Size = new System.Drawing.Size(89, 26);
            this.ChoiceFile.TabIndex = 3;
            this.ChoiceFile.Text = "Выбрать файл";
            this.ChoiceFile.UseVisualStyleBackColor = true;
            this.ChoiceFile.Click += new System.EventHandler(this.ChoiceFile_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(26, 164);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 4;
            this.btnWrite.Text = "Записать";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.ChoiceFile);
            this.Controls.Add(this.tboxFileName);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tboxFileName;
        private System.Windows.Forms.Button ChoiceFile;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Collections.ArrayList listVal ;

    }
}

