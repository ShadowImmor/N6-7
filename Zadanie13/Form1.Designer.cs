namespace Zadanie13
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
            this.Text_label = new System.Windows.Forms.Label();
            this.Fonts_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Text_label
            // 
            this.Text_label.AutoSize = true;
            this.Text_label.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_label.Location = new System.Drawing.Point(12, 265);
            this.Text_label.Name = "Text_label";
            this.Text_label.Size = new System.Drawing.Size(152, 24);
            this.Text_label.TabIndex = 0;
            this.Text_label.Text = "Пример текста";
            // 
            // Fonts_listBox
            // 
            this.Fonts_listBox.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fonts_listBox.FormattingEnabled = true;
            this.Fonts_listBox.ItemHeight = 24;
            this.Fonts_listBox.Location = new System.Drawing.Point(12, 12);
            this.Fonts_listBox.Name = "Fonts_listBox";
            this.Fonts_listBox.Size = new System.Drawing.Size(407, 220);
            this.Fonts_listBox.TabIndex = 1;
            this.Fonts_listBox.SelectedIndexChanged += new System.EventHandler(this.Fonts_listBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 323);
            this.Controls.Add(this.Fonts_listBox);
            this.Controls.Add(this.Text_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text_label;
        private System.Windows.Forms.ListBox Fonts_listBox;
    }
}

