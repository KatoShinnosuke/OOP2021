using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
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
                
                
                var stream = wc.OpenRead(url);
                XDocument xdoc = XDocument.Load(stream);
                items = xdoc.Root.Descendants("item").Select(x => new ItemDate
                {
                    lbTitle = (string)x.Element("title"),
                    Link = (string)x.Element("link"),
                    PubDate = (DateTime)x.Element("pubDate"),
                    Description =(string)x.Element("description")

                });
                var nodes = xdoc.Root.Descendants("title");

                foreach (var node in nodes)
                {
                    lbTitle.Items.Add(node.Value);                  
                }
            }
        }

        private void lbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string link = (items.ToArray())[lbTitle.SelectedIndex].Link;
            WebBrowser.Url = new Url(link);
        }
    }
}
 