namespace LINE_Bot
{
    partial class LineBotForm
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
            this.Btn_Send_Text = new System.Windows.Forms.Button();
            this.Btn_Send_Emoticon = new System.Windows.Forms.Button();
            this.Btn_Send_Image = new System.Windows.Forms.Button();
            this.TextBox_Image_Url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Send_Button_Template = new System.Windows.Forms.Button();
            this.Send_Confirm_Template = new System.Windows.Forms.Button();
            this.Send_Carousel_Template = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Send_Text
            // 
            this.Btn_Send_Text.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Send_Text.Location = new System.Drawing.Point(223, 65);
            this.Btn_Send_Text.Name = "Btn_Send_Text";
            this.Btn_Send_Text.Size = new System.Drawing.Size(144, 67);
            this.Btn_Send_Text.TabIndex = 0;
            this.Btn_Send_Text.Text = "Send Text";
            this.Btn_Send_Text.UseVisualStyleBackColor = true;
            this.Btn_Send_Text.Click += new System.EventHandler(this.Btn_Send_Text_Click);
            // 
            // Btn_Send_Emoticon
            // 
            this.Btn_Send_Emoticon.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Send_Emoticon.Location = new System.Drawing.Point(223, 184);
            this.Btn_Send_Emoticon.Name = "Btn_Send_Emoticon";
            this.Btn_Send_Emoticon.Size = new System.Drawing.Size(144, 67);
            this.Btn_Send_Emoticon.TabIndex = 1;
            this.Btn_Send_Emoticon.Text = "Send Emoticon";
            this.Btn_Send_Emoticon.UseVisualStyleBackColor = true;
            this.Btn_Send_Emoticon.Click += new System.EventHandler(this.Btn_Send_Emoticon_Click);
            // 
            // Btn_Send_Image
            // 
            this.Btn_Send_Image.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Send_Image.Location = new System.Drawing.Point(592, 263);
            this.Btn_Send_Image.Name = "Btn_Send_Image";
            this.Btn_Send_Image.Size = new System.Drawing.Size(144, 67);
            this.Btn_Send_Image.TabIndex = 2;
            this.Btn_Send_Image.Text = "Send Image";
            this.Btn_Send_Image.UseVisualStyleBackColor = true;
            this.Btn_Send_Image.Click += new System.EventHandler(this.Btn_Send_Image_Click);
            // 
            // TextBox_Image_Url
            // 
            this.TextBox_Image_Url.Location = new System.Drawing.Point(35, 289);
            this.TextBox_Image_Url.Multiline = true;
            this.TextBox_Image_Url.Name = "TextBox_Image_Url";
            this.TextBox_Image_Url.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Image_Url.Size = new System.Drawing.Size(528, 41);
            this.TextBox_Image_Url.TabIndex = 3;
            this.TextBox_Image_Url.Text = "https://www.google.com.tw/images/branding/googlelogo/2x/googlelogo_color_272x92dp" +
    ".png";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F);
            this.label1.Location = new System.Drawing.Point(31, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Image url (https):";
            // 
            // Send_Button_Template
            // 
            this.Send_Button_Template.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_Button_Template.Location = new System.Drawing.Point(35, 356);
            this.Send_Button_Template.Name = "Send_Button_Template";
            this.Send_Button_Template.Size = new System.Drawing.Size(144, 67);
            this.Send_Button_Template.TabIndex = 5;
            this.Send_Button_Template.Text = "Send Button Template";
            this.Send_Button_Template.UseVisualStyleBackColor = true;
            this.Send_Button_Template.Click += new System.EventHandler(this.Send_Button_Template_Click);
            // 
            // Send_Confirm_Template
            // 
            this.Send_Confirm_Template.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_Confirm_Template.Location = new System.Drawing.Point(223, 356);
            this.Send_Confirm_Template.Name = "Send_Confirm_Template";
            this.Send_Confirm_Template.Size = new System.Drawing.Size(144, 67);
            this.Send_Confirm_Template.TabIndex = 6;
            this.Send_Confirm_Template.Text = "Send Confirm Template";
            this.Send_Confirm_Template.UseVisualStyleBackColor = true;
            this.Send_Confirm_Template.Click += new System.EventHandler(this.Send_Confirm_Template_Click);
            // 
            // Send_Carousel_Template
            // 
            this.Send_Carousel_Template.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_Carousel_Template.Location = new System.Drawing.Point(397, 356);
            this.Send_Carousel_Template.Name = "Send_Carousel_Template";
            this.Send_Carousel_Template.Size = new System.Drawing.Size(144, 67);
            this.Send_Carousel_Template.TabIndex = 7;
            this.Send_Carousel_Template.Text = "Send Carousel Template";
            this.Send_Carousel_Template.UseVisualStyleBackColor = true;
            this.Send_Carousel_Template.Click += new System.EventHandler(this.Send_Carousel_Template_Click);
            // 
            // LineBotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 515);
            this.Controls.Add(this.Send_Carousel_Template);
            this.Controls.Add(this.Send_Confirm_Template);
            this.Controls.Add(this.Send_Button_Template);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_Image_Url);
            this.Controls.Add(this.Btn_Send_Image);
            this.Controls.Add(this.Btn_Send_Emoticon);
            this.Controls.Add(this.Btn_Send_Text);
            this.Name = "LineBotForm";
            this.Text = "LINE Bot Control Center";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Send_Text;
        private System.Windows.Forms.Button Btn_Send_Emoticon;
        private System.Windows.Forms.Button Btn_Send_Image;
        private System.Windows.Forms.TextBox TextBox_Image_Url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Send_Button_Template;
        private System.Windows.Forms.Button Send_Confirm_Template;
        private System.Windows.Forms.Button Send_Carousel_Template;
    }
}

