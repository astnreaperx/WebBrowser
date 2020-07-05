namespace WebBrowser
{
    partial class frmWebBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebBrowser));
            this.tsMainBar = new System.Windows.Forms.ToolStrip();
            this.tscbURL = new System.Windows.Forms.ToolStripComboBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tsbBack = new System.Windows.Forms.ToolStripButton();
            this.tsbHome = new System.Windows.Forms.ToolStripButton();
            this.tsbForward = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbGo = new System.Windows.Forms.ToolStripButton();
            this.tsMainBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMainBar
            // 
            this.tsMainBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMainBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBack,
            this.tsbHome,
            this.tsbForward,
            this.tscbURL,
            this.tsbRefresh,
            this.tsbGo});
            this.tsMainBar.Location = new System.Drawing.Point(0, 0);
            this.tsMainBar.Name = "tsMainBar";
            this.tsMainBar.Size = new System.Drawing.Size(1124, 28);
            this.tsMainBar.TabIndex = 0;
            this.tsMainBar.Text = "toolStrip1";
            // 
            // tscbURL
            // 
            this.tscbURL.AutoSize = false;
            this.tscbURL.Name = "tscbURL";
            this.tscbURL.Size = new System.Drawing.Size(700, 28);
            this.tscbURL.Enter += new System.EventHandler(this.tscbURL_Enter);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 28);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1124, 646);
            this.webBrowser.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus,
            this.tspbProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 652);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1124, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // tspbProgress
            // 
            this.tspbProgress.Name = "tspbProgress";
            this.tspbProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // tsbBack
            // 
            this.tsbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBack.Image = global::WebBrowser.Properties.Resources.Back;
            this.tsbBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBack.Name = "tsbBack";
            this.tsbBack.Size = new System.Drawing.Size(24, 25);
            this.tsbBack.Text = "Back";
            this.tsbBack.Click += new System.EventHandler(this.tsbBack_Click);
            // 
            // tsbHome
            // 
            this.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHome.Image = global::WebBrowser.Properties.Resources.Home;
            this.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHome.Name = "tsbHome";
            this.tsbHome.Size = new System.Drawing.Size(24, 25);
            this.tsbHome.Text = "Home";
            this.tsbHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbHome.Click += new System.EventHandler(this.tsbHome_Click);
            // 
            // tsbForward
            // 
            this.tsbForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbForward.Image = global::WebBrowser.Properties.Resources.Forward;
            this.tsbForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbForward.Name = "tsbForward";
            this.tsbForward.Size = new System.Drawing.Size(24, 25);
            this.tsbForward.Text = "Forward";
            this.tsbForward.Click += new System.EventHandler(this.tsbForward_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = global::WebBrowser.Properties.Resources.refresh;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(24, 25);
            this.tsbRefresh.Text = "toolStripButton1";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // tsbGo
            // 
            this.tsbGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGo.Image = global::WebBrowser.Properties.Resources.Go;
            this.tsbGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGo.Name = "tsbGo";
            this.tsbGo.Size = new System.Drawing.Size(24, 25);
            this.tsbGo.Text = "toolStripButton1";
            this.tsbGo.Click += new System.EventHandler(this.tsbGo_Click);
            // 
            // frmWebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 674);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.tsMainBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWebBrowser";
            this.Text = "Austins Web Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsMainBar.ResumeLayout(false);
            this.tsMainBar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMainBar;
        private System.Windows.Forms.ToolStripButton tsbBack;
        private System.Windows.Forms.ToolStripButton tsbHome;
        private System.Windows.Forms.ToolStripButton tsbForward;
        private System.Windows.Forms.ToolStripComboBox tscbURL;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripProgressBar tspbProgress;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbGo;
    }
}

