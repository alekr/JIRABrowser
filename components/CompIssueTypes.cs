using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

using Svg;
using System.Drawing.Imaging;

using JIRA.classes;

namespace JIRA.components
{
    public partial class CompIssueTypes : UserControl
    {
        private CJiraProject project;
        private string issueTypeAvatarFolder = null;

        public CompIssueTypes()
        {
            InitializeComponent();
        }

        private void CompIssueTypes_Load(object sender, EventArgs e)
        {
            issueTypeAvatarFolder = Path.GetDirectoryName(Application.ExecutablePath);
            if (issueTypeAvatarFolder.EndsWith("\\") == false)
                issueTypeAvatarFolder += "\\";
            issueTypeAvatarFolder += "avatars\\";

            Directory.CreateDirectory(issueTypeAvatarFolder);
        }

        public void SetProject(CJiraProject project)
        {
            this.project = project;

            BuildIconCollection();

            foreach (CJiraIssuetype issueType in project.issuetypes)
            {
                ListViewItem item = listView1.Items.Add(issueType.name);
                item.ImageKey = issueType.id;
            }
        }

        private void BuildIconCollection()
        {
            ImageList imageList = new ImageList();
            foreach (CJiraIssuetype issueType in project.issuetypes)
            {
                string fileName = SaveImage(issueType.iconUrl, issueType.id, imageList);
                Bitmap bmp = new Bitmap(fileName);
                imageList.Images.Add(issueType.id, bmp);
            }

            listView1.SmallImageList = imageList;
        }

        private string SaveImage(string imageUrl, string id, ImageList imageList)
        {
            Bitmap bmp;
            byte[] imageBytes;

            string filename = issueTypeAvatarFolder + id + ".png";

            if (File.Exists(filename))
                return filename;

            HttpWebRequest imageRequest = (HttpWebRequest)WebRequest.Create(imageUrl);
            WebResponse imageResponse = imageRequest.GetResponse();

            Stream responseStream = imageResponse.GetResponseStream();

            using (BinaryReader br = new BinaryReader(responseStream))
            {
                imageBytes = br.ReadBytes(500000);
                br.Close();
            }

            MemoryStream stream = new MemoryStream(imageBytes);
            MemoryStream copyStream = new MemoryStream(imageBytes);

            if (imageUrl.EndsWith(".png"))
            {
                bmp = new Bitmap(stream);
                bmp.Save(filename, ImageFormat.Png);
            }
            else
            {
                try
                {
                    var svgDocument = SvgDocument.Open(stream); 
                    var bitmap = svgDocument.Draw();
                    bitmap.Save(filename, ImageFormat.Png);
                }
                catch
                {
                    // it is PNG after all
                    bmp = new Bitmap(copyStream);
                    bmp.Save(filename, ImageFormat.Png);
                }
            }
            copyStream.Close();
            stream.Close();
            responseStream.Close();
            imageResponse.Close();

            return filename;
        }

    }
}
