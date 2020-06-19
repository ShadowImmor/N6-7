namespace Zadanie_26
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
            this.Form2_button = new System.Windows.Forms.Button();
            this.Text_Form2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Form2_button
            // 
            this.Form2_button.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form2_button.Location = new System.Drawing.Point(78, 12);
            this.Form2_button.Name = "Form2_button";
            this.Form2_button.Size = new System.Drawing.Size(192, 56);
            this.Form2_button.TabIndex = 0;
            this.Form2_button.Text = "Form2";
            this.Form2_button.UseVisualStyleBackColor = true;
            this.Form2_button.Click += new System.EventHandler(this.Form2_button_Click);
            // 
            // Text_Form2
            // 
            this.Text_Form2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Form2.Location = new System.Drawing.Point(12, 102);
            this.Text_Form2.Name = "Text_Form2";
            this.Text_Form2.Size = new System.Drawing.Size(346, 32);
            this.Text_Form2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 161);
            this.Controls.Add(this.Text_Form2);
            this.Controls.Add(this.Form2_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Form2_button;
        private System.Windows.Forms.TextBox Text_Form2;
    }
}

