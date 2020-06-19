namespace Zadanie_27
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Color_button = new System.Windows.Forms.Button();
            this.Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Color_button
            // 
            this.Color_button.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Color_button.Location = new System.Drawing.Point(12, 84);
            this.Color_button.Name = "Color_button";
            this.Color_button.Size = new System.Drawing.Size(197, 66);
            this.Color_button.TabIndex = 0;
            this.Color_button.Text = "Выбрать цвет";
            this.Color_button.UseVisualStyleBackColor = true;
            this.Color_button.Click += new System.EventHandler(this.Color_button_Click);
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text.Location = new System.Drawing.Point(31, 35);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(152, 24);
            this.Text.TabIndex = 1;
            this.Text.Text = "Пример текста";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 166);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.Color_button);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Color_button;
        private System.Windows.Forms.Label Text;
    }
}

