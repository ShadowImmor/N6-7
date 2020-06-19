namespace Zadanie23
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
            this.components = new System.ComponentModel.Container();
            this.Textlable = new System.Windows.Forms.Label();
            this.Text_textBox = new System.Windows.Forms.TextBox();
            this.ShowText = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.item1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Textlable
            // 
            this.Textlable.AutoSize = true;
            this.Textlable.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Textlable.Location = new System.Drawing.Point(12, 27);
            this.Textlable.Name = "Textlable";
            this.Textlable.Size = new System.Drawing.Size(62, 24);
            this.Textlable.TabIndex = 0;
            this.Textlable.Text = "Текст";
            // 
            // Text_textBox
            // 
            this.Text_textBox.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_textBox.Location = new System.Drawing.Point(94, 24);
            this.Text_textBox.Name = "Text_textBox";
            this.Text_textBox.Size = new System.Drawing.Size(364, 32);
            this.Text_textBox.TabIndex = 1;
            // 
            // ShowText
            // 
            this.ShowText.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowText.Location = new System.Drawing.Point(33, 62);
            this.ShowText.Name = "ShowText";
            this.ShowText.Size = new System.Drawing.Size(380, 67);
            this.ShowText.TabIndex = 2;
            this.ShowText.Text = "Вывести сообщение с текстом";
            this.ShowText.UseVisualStyleBackColor = true;
            this.ShowText.Click += new System.EventHandler(this.ShowText_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.item1ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.item1ToolStripMenuItem.Text = "Item1 ";
            this.item1ToolStripMenuItem.Click += new System.EventHandler(this.item1ToolStripMenuItem_Click);
            // 
            // item1ToolStripMenuItem1
            // 
            this.item1ToolStripMenuItem1.Name = "item1ToolStripMenuItem1";
            this.item1ToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.item1ToolStripMenuItem1.Text = "Item2 ";
            this.item1ToolStripMenuItem1.Click += new System.EventHandler(this.item1ToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 155);
            this.Controls.Add(this.ShowText);
            this.Controls.Add(this.Text_textBox);
            this.Controls.Add(this.Textlable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Textlable;
        private System.Windows.Forms.TextBox Text_textBox;
        private System.Windows.Forms.Button ShowText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem item1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item1ToolStripMenuItem1;
    }
}

