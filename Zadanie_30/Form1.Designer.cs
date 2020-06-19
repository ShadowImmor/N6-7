namespace Zadanie_30
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.File_button = new System.Windows.Forms.Button();
            this.Files_button = new System.Windows.Forms.Button();
            this.File_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt files|*.txt; *.ini|All files|*.*";
            this.openFileDialog1.InitialDirectory = "C:\\";
            this.openFileDialog1.Multiselect = true;
            // 
            // File_button
            // 
            this.File_button.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.File_button.Location = new System.Drawing.Point(12, 290);
            this.File_button.Name = "File_button";
            this.File_button.Size = new System.Drawing.Size(213, 63);
            this.File_button.TabIndex = 0;
            this.File_button.Text = "Обзор файла";
            this.File_button.UseVisualStyleBackColor = true;
            this.File_button.Click += new System.EventHandler(this.File_button_Click);
            // 
            // Files_button
            // 
            this.Files_button.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Files_button.Location = new System.Drawing.Point(279, 290);
            this.Files_button.Name = "Files_button";
            this.Files_button.Size = new System.Drawing.Size(193, 63);
            this.Files_button.TabIndex = 1;
            this.Files_button.Text = "Обзор файлов";
            this.Files_button.UseVisualStyleBackColor = true;
            this.Files_button.Click += new System.EventHandler(this.Files_button_Click);
            // 
            // File_listBox
            // 
            this.File_listBox.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.File_listBox.FormattingEnabled = true;
            this.File_listBox.ItemHeight = 24;
            this.File_listBox.Location = new System.Drawing.Point(12, 13);
            this.File_listBox.Name = "File_listBox";
            this.File_listBox.Size = new System.Drawing.Size(460, 268);
            this.File_listBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 365);
            this.Controls.Add(this.File_listBox);
            this.Controls.Add(this.Files_button);
            this.Controls.Add(this.File_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button File_button;
        private System.Windows.Forms.Button Files_button;
        private System.Windows.Forms.ListBox File_listBox;
    }
}

