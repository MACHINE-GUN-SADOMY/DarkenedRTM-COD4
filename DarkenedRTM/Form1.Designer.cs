namespace DarkenedRTM
{
    partial class Form1
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
            this.btnCloseMeWindows = new System.Windows.Forms.Button();
            this.lblCreeditsName = new System.Windows.Forms.Label();
            this.ptcMainPictureMenu = new System.Windows.Forms.PictureBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnRecovery = new System.Windows.Forms.Button();
            this.btnNonHost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptcMainPictureMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseMeWindows
            // 
            this.btnCloseMeWindows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCloseMeWindows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCloseMeWindows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseMeWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseMeWindows.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseMeWindows.ForeColor = System.Drawing.Color.Black;
            this.btnCloseMeWindows.Location = new System.Drawing.Point(376, 11);
            this.btnCloseMeWindows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCloseMeWindows.Name = "btnCloseMeWindows";
            this.btnCloseMeWindows.Size = new System.Drawing.Size(47, 35);
            this.btnCloseMeWindows.TabIndex = 0;
            this.btnCloseMeWindows.Text = "X";
            this.btnCloseMeWindows.UseVisualStyleBackColor = false;
            this.btnCloseMeWindows.Click += new System.EventHandler(this.btnCloseMeWindows_Click);
            // 
            // lblCreeditsName
            // 
            this.lblCreeditsName.AutoSize = true;
            this.lblCreeditsName.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreeditsName.Location = new System.Drawing.Point(14, 17);
            this.lblCreeditsName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreeditsName.Name = "lblCreeditsName";
            this.lblCreeditsName.Size = new System.Drawing.Size(221, 23);
            this.lblCreeditsName.TabIndex = 1;
            this.lblCreeditsName.Text = "Darkened RTM TOOL";
            // 
            // ptcMainPictureMenu
            // 
            this.ptcMainPictureMenu.BackgroundImage = global::DarkenedRTM.Properties.Resources.Sold__warheadart__catacombkvlt;
            this.ptcMainPictureMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptcMainPictureMenu.Location = new System.Drawing.Point(14, 52);
            this.ptcMainPictureMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ptcMainPictureMenu.Name = "ptcMainPictureMenu";
            this.ptcMainPictureMenu.Size = new System.Drawing.Size(407, 284);
            this.ptcMainPictureMenu.TabIndex = 2;
            this.ptcMainPictureMenu.TabStop = false;
            this.ptcMainPictureMenu.Click += new System.EventHandler(this.ptcMainPictureMenu_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Red;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(14, 342);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(197, 42);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.Color.Red;
            this.btnAttach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAttach.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttach.ForeColor = System.Drawing.Color.Black;
            this.btnAttach.Location = new System.Drawing.Point(222, 342);
            this.btnAttach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(201, 41);
            this.btnAttach.TabIndex = 4;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = false;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // btnRecovery
            // 
            this.btnRecovery.BackColor = System.Drawing.Color.Red;
            this.btnRecovery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecovery.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecovery.ForeColor = System.Drawing.Color.Black;
            this.btnRecovery.Location = new System.Drawing.Point(14, 391);
            this.btnRecovery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(407, 63);
            this.btnRecovery.TabIndex = 5;
            this.btnRecovery.Text = "Recovery";
            this.btnRecovery.UseVisualStyleBackColor = false;
            this.btnRecovery.Click += new System.EventHandler(this.btnRecovery_Click);
            // 
            // btnNonHost
            // 
            this.btnNonHost.BackColor = System.Drawing.Color.Red;
            this.btnNonHost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNonHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNonHost.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNonHost.ForeColor = System.Drawing.Color.Black;
            this.btnNonHost.Location = new System.Drawing.Point(14, 460);
            this.btnNonHost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNonHost.Name = "btnNonHost";
            this.btnNonHost.Size = new System.Drawing.Size(406, 65);
            this.btnNonHost.TabIndex = 6;
            this.btnNonHost.Text = "Non-Host";
            this.btnNonHost.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(436, 539);
            this.Controls.Add(this.btnNonHost);
            this.Controls.Add(this.btnRecovery);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.ptcMainPictureMenu);
            this.Controls.Add(this.lblCreeditsName);
            this.Controls.Add(this.btnCloseMeWindows);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Darkened";
            ((System.ComponentModel.ISupportInitialize)(this.ptcMainPictureMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseMeWindows;
        private System.Windows.Forms.Label lblCreeditsName;
        private System.Windows.Forms.PictureBox ptcMainPictureMenu;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnRecovery;
        private System.Windows.Forms.Button btnNonHost;
    }
}

