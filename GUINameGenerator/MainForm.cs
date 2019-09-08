using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUINameGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GetName_Click(object sender, EventArgs e)
        {
            try
            {
                NameOperations nameOperations = new NameOperations("names.txt", "surnames.txt");
                nameGenerated.Text = nameOperations.GetRandomName();
            }
            catch (FileNotFoundException e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException e2)
            {
                MessageBox.Show(e2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
