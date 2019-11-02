namespace Настройщик_ПК
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
            this.CheckedListRegistryKey = new System.Windows.Forms.CheckedListBox();
            this.СomboBox = new System.Windows.Forms.ComboBox();
            this.ButtonRunService = new System.Windows.Forms.Button();
            this.ButtonStopService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckedListRegistryKey
            // 
            this.CheckedListRegistryKey.FormattingEnabled = true;
            this.CheckedListRegistryKey.Location = new System.Drawing.Point(13, 13);
            this.CheckedListRegistryKey.Name = "CheckedListRegistryKey";
            this.CheckedListRegistryKey.Size = new System.Drawing.Size(120, 364);
            this.CheckedListRegistryKey.TabIndex = 0;
            // 
            // СomboBox
            // 
            this.СomboBox.FormattingEnabled = true;
            this.СomboBox.Location = new System.Drawing.Point(218, 177);
            this.СomboBox.Name = "СomboBox";
            this.СomboBox.Size = new System.Drawing.Size(33, 21);
            this.СomboBox.TabIndex = 1;
            // 
            // ButtonRunService
            // 
            this.ButtonRunService.Location = new System.Drawing.Point(176, 50);
            this.ButtonRunService.Name = "ButtonRunService";
            this.ButtonRunService.Size = new System.Drawing.Size(75, 23);
            this.ButtonRunService.TabIndex = 2;
            this.ButtonRunService.Text = "Запустить";
            this.ButtonRunService.UseVisualStyleBackColor = true;
            // 
            // ButtonStopService
            // 
            this.ButtonStopService.Location = new System.Drawing.Point(257, 50);
            this.ButtonStopService.Name = "ButtonStopService";
            this.ButtonStopService.Size = new System.Drawing.Size(75, 23);
            this.ButtonStopService.TabIndex = 3;
            this.ButtonStopService.Text = "Остановить";
            this.ButtonStopService.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 416);
            this.Controls.Add(this.ButtonStopService);
            this.Controls.Add(this.ButtonRunService);
            this.Controls.Add(this.СomboBox);
            this.Controls.Add(this.CheckedListRegistryKey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CheckedListRegistryKey;
        private System.Windows.Forms.ComboBox СomboBox;
        private System.Windows.Forms.Button ButtonRunService;
        private System.Windows.Forms.Button ButtonStopService;
    }
}

