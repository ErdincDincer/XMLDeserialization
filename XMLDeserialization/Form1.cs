using System.Xml.Serialization;
using System.Xml;

namespace XMLDeserialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Company));
            //XmlReader'ın Create Methodunun içine dosya yolumuzu veya Url'i yazalım.
            XmlReader reader = XmlReader.Create("https://www.siteadi.com/XMLVerilerim.xml");
            Company company = (Company)xmlSerializer.Deserialize(reader);
            reader.Close();
        }
    }
}