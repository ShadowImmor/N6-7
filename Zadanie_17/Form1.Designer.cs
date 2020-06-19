namespace Zadanie_17
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
            this.button = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(12, 12);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(138, 54);
            this.button.TabIndex = 0;
            this.button.Text = "button";
            this.button.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(12, 83);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(138, 32);
            this.textBox.TabIndex = 1;
            // 
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton.Location = new System.Drawing.Point(11, 131);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(142, 29);
            this.radioButton.TabIndex = 2;
            this.radioButton.TabStop = true;
            this.radioButton.Text = "radioButton";
            this.radioButton.UseVisualStyleBackColor = true;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox.Location = new System.Drawing.Point(12, 165);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(119, 29);
            this.checkBox.TabIndex = 3;
            this.checkBox.Text = "checkBox";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(11, 199);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(138, 33);
            this.progressBar.TabIndex = 4;
            this.progressBar.Value = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 277);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.radioButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.RadioButton radioButton;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

