using System.Xml.Linq;
using System.Xml;
using System.Xml.Xsl;

namespace XSLT___Transformation
{
    public partial class frmMain : Form
    {

        private string fileNameXML;
        private string fileNameXSL;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOpenFileXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileNameXML = openFileDialog.FileName;
                XDocument document = XDocument.Load(fileNameXML);
                inputFile.Text = document.ToString();
            }
            else MessageBox.Show("File not selected to convert");
        }

        private void btnOpenFileXSL_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileNameXSL = openFileDialog.FileName;
            }
            else MessageBox.Show("File not selected to convert");
        }

        private void btnTransformation_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fileNameXML) && !string.IsNullOrEmpty(fileNameXSL))
            {
                StartTransformation(fileNameXML, fileNameXSL);
            }
            else MessageBox.Show("File not selected to convert");
        }

        private void StartTransformation(string fileNameXML, string fileNameXSLT)
        {
            string outPutFile = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "/Groups.xml"; 
            
            XslCompiledTransform xslCompiledTransform = new();
            xslCompiledTransform.Load(fileNameXSLT);
            XmlTextWriter xmlTextWriter = new XmlTextWriter(outPutFile, null);
            xslCompiledTransform.Transform(fileNameXML, null, xmlTextWriter);
            xmlTextWriter.Close();

            AddCountItemsToInputFile(fileNameXML);
            AddCountItemsInGroups(outPutFile);
        }

        private void AddCountItemsInGroups(string outPutFile)
        {
            XmlDocument document = new();
            document.Load(outPutFile);

            XmlDeclaration xmldecl;
            xmldecl = document.CreateXmlDeclaration("1.0", "utf-8", null);

            if (document != null)
            {
                XmlElement root = document.DocumentElement;

                if (root != null)
                {
                    XmlNodeList elemList = root.GetElementsByTagName("group");

                    foreach (XmlNode elem in elemList)
                    {
                        XmlAttribute attr = document.CreateAttribute("count");
                        attr.Value = elem.ChildNodes.Count.ToString();
                        elem.Attributes.Append(attr);
                    }

                    document.InsertBefore(xmldecl, root);
                    document.Save(outPutFile);
                    outputFile.Text = document.InnerXml;
                }
            }
        }

        private void AddCountItemsToInputFile(string fileNameXML)
        {
            XmlDocument document = new();
            document.Load(fileNameXML);
            if (document != null)
            {
                XmlNodeList elemList = document.SelectNodes("list");

                foreach (XmlNode elem in elemList)
                {
                    XmlAttribute attr = document.CreateAttribute("count");
                    attr.Value = elem.ChildNodes.Count.ToString();
                    elem.Attributes.Append(attr);
                }
                document.Save(fileNameXML);
                inputFile.Text = document.InnerXml;
            }
        }
    }
}