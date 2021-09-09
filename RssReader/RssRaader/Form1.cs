using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssRaader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            SetRssTitle(tbUrl.Text);
           // リンク先のList[lbTitle.SelectedIndex];
        }
        private void SetRssTitle(string url)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                
                var tbUrl = new Uri(url);
                
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");

                foreach (var node in nodes)
                {
                    lbTitle.Items.Add(node.Value);
                    List<string> link = new List<string>();
                    //link.Add();
                }
            }
        }
    }
}
