namespace OrdersServiceWinFormClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btnUnsubscribe = new System.Windows.Forms.Button();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.btnChangeOrderStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubscribe.Location = new System.Drawing.Point(12, 226);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(94, 23);
            this.btnSubscribe.TabIndex = 0;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.OnBtnSubscribeClick);
            // 
            // btnUnsubscribe
            // 
            this.btnUnsubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUnsubscribe.Location = new System.Drawing.Point(286, 226);
            this.btnUnsubscribe.Name = "btnUnsubscribe";
            this.btnUnsubscribe.Size = new System.Drawing.Size(94, 23);
            this.btnUnsubscribe.TabIndex = 1;
            this.btnUnsubscribe.Text = "Unsubscribe";
            this.btnUnsubscribe.UseVisualStyleBackColor = true;
            this.btnUnsubscribe.Click += new System.EventHandler(this.OnBtnUnsubscribeClick);
            // 
            // txtMessages
            // 
            this.txtMessages.Location = new System.Drawing.Point(6, 12);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ReadOnly = true;
            this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessages.Size = new System.Drawing.Size(374, 208);
            this.txtMessages.TabIndex = 2;
            // 
            // btnChangeOrderStatus
            // 
            this.btnChangeOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeOrderStatus.Location = new System.Drawing.Point(112, 226);
            this.btnChangeOrderStatus.Name = "btnChangeOrderStatus";
            this.btnChangeOrderStatus.Size = new System.Drawing.Size(168, 23);
            this.btnChangeOrderStatus.TabIndex = 3;
            this.btnChangeOrderStatus.Text = "Change Order StatusTest";
            this.btnChangeOrderStatus.UseVisualStyleBackColor = true;
            this.btnChangeOrderStatus.Click += new System.EventHandler(this.OnBtnChangeOrderStatusClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 261);
            this.Controls.Add(this.btnChangeOrderStatus);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.btnUnsubscribe);
            this.Controls.Add(this.btnSubscribe);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(410, 300);
            this.MinimumSize = new System.Drawing.Size(410, 300);
            this.Name = "MainForm";
            this.Text = "Subscribe on orders status changing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Button btnUnsubscribe;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.Button btnChangeOrderStatus;
    }
}

