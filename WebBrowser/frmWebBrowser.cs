using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class frmWebBrowser : Form
    {
        String Url = string.Empty;
        public frmWebBrowser()
        {
            InitializeComponent();
            Url = "http://www.google.ca";
            myBrowser();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            tsbBack.Enabled = false;
            tsbForward.Enabled = false;
        }

        private void myBrowser()
        {
            if (tscbURL.Text != "")
                Url = tscbURL.Text;
            webBrowser.Navigate(Url);
            webBrowser.ProgressChanged +=
            new WebBrowserProgressChangedEventHandler(webpage_ProgressChanged);
            webBrowser.DocumentTitleChanged +=
            new EventHandler(webpage_DocumentTitleChanged);
            webBrowser.StatusTextChanged += new EventHandler(webpage_StatusTextChanged);
            webBrowser.Navigated += new WebBrowserNavigatedEventHandler(webpage_Navigated);
            webBrowser.DocumentCompleted +=
            new WebBrowserDocumentCompletedEventHandler(webpage_DocumentCompleted);
        }

        private void webpage_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser.CanGoBack) tsbBack.Enabled = true;
            else tsbBack.Enabled = false;

            if (webBrowser.CanGoForward) tsbForward.Enabled = true;
            else tsbForward.Enabled = false;
            tsslStatus.Text = "Done";
        }

        private void webpage_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.Text = webBrowser.DocumentTitle.ToString();
        }

        private void webpage_StatusTextChanged(object sender, EventArgs e)
        {
            tsslStatus.Text = webBrowser.StatusText;
        }

        private void webpage_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            tspbProgress.Maximum = (int)e.MaximumProgress;
            tspbProgress.Value = ((int)e.CurrentProgress < 0 ||
            (int)e.MaximumProgress < (int)e.CurrentProgress) ?
            (int)e.MaximumProgress : (int)e.CurrentProgress;
        }

        private void webpage_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            tscbURL.Text = webBrowser.Url.ToString();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void tsbForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void tsbBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void tsbHome_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }

        private void tsbGo_Click(object sender, EventArgs e)
        {
            Search();    
        }

        private void tscbURL_Enter(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            Url = tscbURL.Text;
            webBrowser.Navigate(Url);
            tscbURL.

        }


    }
}
