using System.Xml.Linq;

namespace XSLT___Transformation
{
    public partial class frmMain : Form 
    {
        private string desktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        private string fileName { get; set; }
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                XDocument document = XDocument.Load(fileName);
                inputFile.Text = document.ToString();  
            }
            else MessageBox.Show("File not selected to convert");
        }

        private void btnTransformation_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                StartTransformation(fileName);
            }
            else MessageBox.Show("File not selected to convert");
        }

        private void StartTransformation(string fileName)
        {
            XElement document = XElement.Load(fileName);
            document.SetAttributeValue("count", document.Elements("item").Count());
            document.Save(fileName);
            var newData =
                new XElement("groups",
                    from data in document.Elements("item")
                    orderby (int)data.Attribute("group")
                    group data by (int)data.Attribute("group")

                    into groupedData
                    select new XElement("group",
                        new XAttribute("name", groupedData.Key), new XAttribute("count", groupedData.Count()),
                        from _group in groupedData
                        orderby (int)_group.Attribute("name")
                        select new XElement("item",
                            _group.Attribute("name"))
                    )
                );

            newData.Save(desktopDirectory + "/Groups.xml");
            inputFile.Text = document.ToString();
            outputFile.Text = newData.ToString();
        } 
    }
}