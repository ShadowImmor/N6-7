namespace N6_7
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
            this.Delim = new System.Windows.Forms.TextBox();
            this.Delit = new System.Windows.Forms.TextBox();
            this.Res = new System.Windows.Forms.Label();
            this.Del_button = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Delim
            // 
            this.Delim.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delim.Location = new System.Drawing.Point(12, 21);
            this.Delim.Name = "Delim";
            this.Delim.Size = new System.Drawing.Size(132, 32);
            this.Delim.TabIndex = 0;
            // 
            // Delit
            // 
            this.Delit.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delit.Location = new System.Drawing.Point(12, 108);
            this.Delit.Name = "Delit";
            this.Delit.Size = new System.Drawing.Size(132, 32);
            this.Delit.TabIndex = 1;
            // 
            // Res
            // 
            this.Res.AutoSize = true;
            this.Res.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Res.Location = new System.Drawing.Point(186, 24);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(102, 24);
            this.Res.TabIndex = 2;
            this.Res.Text = "Результат";
            // 
            // Del_button
            // 
            this.Del_button.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Del_button.Location = new System.Drawing.Point(190, 107);
            this.Del_button.Name = "Del_button";
            this.Del_button.Size = new System.Drawing.Size(123, 33);
            this.Del_button.TabIndex = 3;
            this.Del_button.Text = "button1";
            this.Del_button.UseVisualStyleBackColor = true;
            this.Del_button.Click += new System.EventHandler(this.Del_button_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 207);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(513, 30);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.MouseClick += new System.Windows.Forms.MouseEventHandler(this.statusStrip_MouseClick);
            this.statusStrip.Resize += new System.EventHandler(this.statusStrip_Resize);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(157, 17);
            this.toolStripStatusLabel1.Text = "Статус";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Image = global::N6_7.Properties.Resources.Zadanie5;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(157, 25);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel_2";
            this.toolStripStatusLabel2.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripStatusLabel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 237);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.Del_button);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.Delit);
            this.Controls.Add(this.Delim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Delim;
        private System.Windows.Forms.TextBox Delit;
        private System.Windows.Forms.Label Res;
        private System.Windows.Forms.Button Del_button;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

