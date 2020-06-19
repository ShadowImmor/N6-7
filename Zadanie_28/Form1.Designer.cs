namespace Zadanie_28
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
            this.Nothing = new System.Windows.Forms.Button();
            this.Not_Forgotten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nothing
            // 
            this.Nothing.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nothing.Location = new System.Drawing.Point(12, 90);
            this.Nothing.Name = "Nothing";
            this.Nothing.Size = new System.Drawing.Size(139, 47);
            this.Nothing.TabIndex = 0;
            this.Nothing.Text = "Nothing";
            this.Nothing.UseVisualStyleBackColor = true;
            this.Nothing.Click += new System.EventHandler(this.Nothing_Click);
            // 
            // Not_Forgotten
            // 
            this.Not_Forgotten.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Not_Forgotten.Location = new System.Drawing.Point(220, 90);
            this.Not_Forgotten.Name = "Not_Forgotten";
            this.Not_Forgotten.Size = new System.Drawing.Size(162, 47);
            this.Not_Forgotten.TabIndex = 1;
            this.Not_Forgotten.Text = "Not forgotten";
            this.Not_Forgotten.UseVisualStyleBackColor = true;
            this.Not_Forgotten.Click += new System.EventHandler(this.Not_Forgotten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 148);
            this.Controls.Add(this.Not_Forgotten);
            this.Controls.Add(this.Nothing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Nothing;
        private System.Windows.Forms.Button Not_Forgotten;
    }
}

