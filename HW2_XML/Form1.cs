using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HW2_XML
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Drugs drug1 = new Drugs();
            drug1.Name = "Амфетамин";
            drug1.Death_Dose = 100;
            Drugs drug2 = new Drugs();
            drug2.Name = "Кокаин";
            drug2.Death_Dose = 200;
            Drugs drug3 = new Drugs();
            drug3.Name = "ЛСД";
            drug3.Death_Dose = 100;

            try { string json = JsonSerializer.Serialize(typeof(Drugs)); }
            catch (Exception ex)
            {
                
            }
            XmlSerializer xml_serializer = new XmlSerializer(typeof(Drugs));
        }
        private DataTable CreateTable()
        {
            DataTable table = new DataTable("Drugs");
            DataColumn colName = new DataColumn("Name", typeof(String));
            DataColumn colDose = new DataColumn("Death_Dose", typeof(Byte));
            table.Columns.Add(colName);
            table.Columns.Add(colDose);
            return table;
        }

        private DataTable ReadXml()
        {
            DataTable table = null;
            try
            {
                XDocument xDoc = XDocument.Load("../../Resourses/XMLFile.xml");
                table = CreateTable();
                DataRow newRow = null;
                foreach (XElement elm in xDoc.Descendants("Drug"))
                {
                    newRow = table.NewRow();
                    if (elm.Element("Name") != null)
                    {
                        newRow["Name"] = elm.Element("Name").Value;
                    }
                    if (elm.Element("Death_Dose") != null)
                    {
                        newRow["Death_Dose"] = int.Parse(elm.Element("Death_Dose").Value);
                    }
                    table.Rows.Add(newRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            DataGrid.DataSource = ReadXml();
        }
        private void Info_Button_Click(object sender, EventArgs e)
        {
            SecondForm NewForm = new SecondForm();
            NewForm.Show();
        }
    }
}