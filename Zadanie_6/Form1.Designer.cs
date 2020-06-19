namespace Zadanie_6
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
            this.StrartThread = new System.Windows.Forms.Button();
            this.MsgBox = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // StrartThread
            // 
            this.StrartThread.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StrartThread.Location = new System.Drawing.Point(42, 29);
            this.StrartThread.Name = "StrartThread";
            this.StrartThread.Size = new System.Drawing.Size(143, 41);
            this.StrartThread.TabIndex = 0;
            this.StrartThread.Text = "Start Thread";
            this.StrartThread.UseVisualStyleBackColor = true;
            this.StrartThread.Click += new System.EventHandler(this.StrartThread_Click);
            // 
            // MsgBox
            // 
            this.MsgBox.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MsgBox.Location = new System.Drawing.Point(219, 29);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(143, 41);
            this.MsgBox.TabIndex = 1;
            this.MsgBox.Text = "MsgBox";
            this.MsgBox.UseVisualStyleBackColor = true;
            this.MsgBox.Click += new System.EventHandler(this.MsgBox_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 99);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.StrartThread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StrartThread;
        private System.Windows.Forms.Button MsgBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

