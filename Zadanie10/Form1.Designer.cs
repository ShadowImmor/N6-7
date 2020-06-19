namespace Zadanie10
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
            this.YznInfo_button = new System.Windows.Forms.Button();
            this.SysInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // YznInfo_button
            // 
            this.YznInfo_button.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YznInfo_button.Location = new System.Drawing.Point(13, 12);
            this.YznInfo_button.Name = "YznInfo_button";
            this.YznInfo_button.Size = new System.Drawing.Size(612, 68);
            this.YznInfo_button.TabIndex = 0;
            this.YznInfo_button.Text = "Узнать системную информацию";
            this.YznInfo_button.UseVisualStyleBackColor = true;
            this.YznInfo_button.Click += new System.EventHandler(this.YznInfo_button_Click);
            // 
            // SysInfo
            // 
            this.SysInfo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SysInfo.Location = new System.Drawing.Point(13, 86);
            this.SysInfo.Name = "SysInfo";
            this.SysInfo.Size = new System.Drawing.Size(612, 325);
            this.SysInfo.TabIndex = 1;
            this.SysInfo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 423);
            this.Controls.Add(this.SysInfo);
            this.Controls.Add(this.YznInfo_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button YznInfo_button;
        private System.Windows.Forms.RichTextBox SysInfo;
    }
}

