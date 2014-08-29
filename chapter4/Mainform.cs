using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace chapter4
{
    public partial class Mainform : Form
    {
        private BindingSource myBindingSource = new BindingSource();
        public Mainform()
        {
            InitializeComponent();

            dataGridView1.DataSource = myBindingSource;
        }



        private void AddPersonnel_Click(object sender, EventArgs e)
        {
            Personnel newPersonnel = new Personnel();
            newPersonnel.FirstName = FirstNameTextBox.Text;
            newPersonnel.LastName = LastNameTextBox.Text;
            newPersonnel.HireDate = dateTimeHireDate.Value;
            newPersonnel.Position = listBoxPosition.SelectedItem.ToString();

            myBindingSource.Add(newPersonnel);
            pnpPersonnel.Add(newPersonnel);
        }

        private void FirstNameTextBox_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = "";

        }

        private void LastNameTextBox_Click(object sender, EventArgs e)
        {
            LastNameTextBox.Text = "";
        }

        List<Personnel> pnpPersonnel = new List<Personnel>();

        
 

       
       
        private void LoadButton_Click_1(object sender, EventArgs e)
        {
            var myData = File.ReadAllText(@"C:\Users\Public\New Folder\myData.json");
            List<Personnel> newPnpPersonnel = JsonConvert.DeserializeObject<List<Personnel>>(myData);

            foreach (var personnel in newPnpPersonnel)
            {
                pnpPersonnel.Add(personnel);
                myBindingSource.Add(personnel);
            }
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            var myData = JsonConvert.SerializeObject(pnpPersonnel);
            File.WriteAllText(@"C:\Users\Public\New Folder\myData.json", myData);
        }

              
    }
    
    }


