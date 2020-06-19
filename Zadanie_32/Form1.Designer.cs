namespace Zadanie_32
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
            this.Press = new System.Windows.Forms.Button();
            this.Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Press
            // 
            this.Press.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Press.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Press.Location = new System.Drawing.Point(217, 22);
            this.Press.Name = "Press";
            this.Press.Size = new System.Drawing.Size(169, 66);
            this.Press.TabIndex = 1;
            this.Press.Text = "&Press";
            this.Press.UseVisualStyleBackColor = true;
            this.Press.Click += new System.EventHandler(this.Click_Click);
            // 
            // Click
            // 
            this.Click.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Click.ForeColor = System.Drawing.Color.DarkOrange;
            this.Click.Location = new System.Drawing.Point(12, 22);
            this.Click.Name = "Click";
            this.Click.Size = new System.Drawing.Size(169, 66);
            this.Click.TabIndex = 0;
            this.Click.Text = "&Click";
            this.Click.UseVisualStyleBackColor = true;
            this.Click.Click += new System.EventHandler(this.Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 110);
            this.Controls.Add(this.Press);
            this.Controls.Add(this.Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Click;
        private System.Windows.Forms.Button Press;
    }
}

