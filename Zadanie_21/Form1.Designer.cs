namespace Zadanie_21
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
            this.TypeClass_textBox = new System.Windows.Forms.TextBox();
            this.CreateClass_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TypeClass_textBox
            // 
            this.TypeClass_textBox.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeClass_textBox.Location = new System.Drawing.Point(12, 12);
            this.TypeClass_textBox.Name = "TypeClass_textBox";
            this.TypeClass_textBox.Size = new System.Drawing.Size(185, 32);
            this.TypeClass_textBox.TabIndex = 0;
            // 
            // CreateClass_button
            // 
            this.CreateClass_button.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateClass_button.Location = new System.Drawing.Point(12, 67);
            this.CreateClass_button.Name = "CreateClass_button";
            this.CreateClass_button.Size = new System.Drawing.Size(185, 48);
            this.CreateClass_button.TabIndex = 1;
            this.CreateClass_button.Text = "button1";
            this.CreateClass_button.UseVisualStyleBackColor = true;
            this.CreateClass_button.Click += new System.EventHandler(this.CreateClass_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 134);
            this.Controls.Add(this.CreateClass_button);
            this.Controls.Add(this.TypeClass_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TypeClass_textBox;
        private System.Windows.Forms.Button CreateClass_button;
    }
}

