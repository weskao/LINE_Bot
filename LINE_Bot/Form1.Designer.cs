namespace LINE_Bot
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Send_Message = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Send_Message
            // 
            this.Btn_Send_Message.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Send_Message.Location = new System.Drawing.Point(223, 169);
            this.Btn_Send_Message.Name = "Btn_Send_Message";
            this.Btn_Send_Message.Size = new System.Drawing.Size(144, 67);
            this.Btn_Send_Message.TabIndex = 0;
            this.Btn_Send_Message.Text = "Send Message";
            this.Btn_Send_Message.UseVisualStyleBackColor = true;
            this.Btn_Send_Message.Click += new System.EventHandler(this.Btn_Send_Message_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 436);
            this.Controls.Add(this.Btn_Send_Message);
            this.Name = "Form1";
            this.Text = "LINE Bot Control Center";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Send_Message;
    }
}

