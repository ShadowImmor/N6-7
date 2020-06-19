namespace Zadanie_7
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
            this.DochYzl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DochYzl
            // 
            this.DochYzl.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DochYzl.Location = new System.Drawing.Point(12, 12);
            this.DochYzl.Name = "DochYzl";
            this.DochYzl.Size = new System.Drawing.Size(419, 58);
            this.DochYzl.TabIndex = 0;
            this.DochYzl.Text = "Все дочерние узлы первого уровня ";
            this.DochYzl.UseVisualStyleBackColor = true;
            this.DochYzl.Click += new System.EventHandler(this.DochYzl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 94);
            this.Controls.Add(this.DochYzl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DochYzl;
    }
}

