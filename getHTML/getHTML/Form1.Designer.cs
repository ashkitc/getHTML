namespace getHTML
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.browser = new System.Windows.Forms.WebBrowser();
            this.urlField = new System.Windows.Forms.TextBox();
            this.goButtom = new System.Windows.Forms.Button();
            this.getHTMLButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(12, 52);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(885, 393);
            this.browser.TabIndex = 0;
            this.browser.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            this.browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browser_DocumentCompleted);
            // 
            // urlField
            // 
            this.urlField.Location = new System.Drawing.Point(12, 20);
            this.urlField.Name = "urlField";
            this.urlField.Size = new System.Drawing.Size(682, 20);
            this.urlField.TabIndex = 1;
            // 
            // goButtom
            // 
            this.goButtom.Location = new System.Drawing.Point(700, 12);
            this.goButtom.Name = "goButtom";
            this.goButtom.Size = new System.Drawing.Size(83, 34);
            this.goButtom.TabIndex = 2;
            this.goButtom.Text = "Go!";
            this.goButtom.UseVisualStyleBackColor = true;
            this.goButtom.Click += new System.EventHandler(this.goButtom_Click);
            // 
            // getHTMLButton
            // 
            this.getHTMLButton.Location = new System.Drawing.Point(789, 12);
            this.getHTMLButton.Name = "getHTMLButton";
            this.getHTMLButton.Size = new System.Drawing.Size(89, 34);
            this.getHTMLButton.TabIndex = 3;
            this.getHTMLButton.Text = "Save HTML";
            this.getHTMLButton.UseVisualStyleBackColor = true;
            this.getHTMLButton.Click += new System.EventHandler(this.getHTMLButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 476);
            this.Controls.Add(this.getHTMLButton);
            this.Controls.Add(this.goButtom);
            this.Controls.Add(this.urlField);
            this.Controls.Add(this.browser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.TextBox urlField;
        private System.Windows.Forms.Button goButtom;
        private System.Windows.Forms.Button getHTMLButton;

    }
}

