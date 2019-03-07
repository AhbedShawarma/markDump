using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;

namespace markDump
{
    public partial class Form1 : Form
    {
        //DataSet result;
        Excel excel;
        string fileName;
        string studentName;
        int studentMark;
         
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            studentName = Interaction.InputBox("What is the student's name?");
            WriteData(studentName);
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            fileName = Interaction.InputBox("What is the file name?");
            OpenFile(fileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void OpenFile(string name)
        {
            excel = new Excel(@"C:\Users\qazth\OneDrive\Documents\School Work\comp sci\markDump\markDump\" + name + ".xlsx", 1);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            excel.ExcelClose();
            this.Close();
        }

        public void WriteData(string input)
        {
            excel.WriteToCell(0, 0, input);
            excel.Save();
            MessageBox.Show(excel.ReadCell(0, 0));

        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            studentName = Interaction.InputBox("Enter Student Name:");
            string strand = Interaction.InputBox("Enter Strand Name:");
            string strandEx = Interaction.InputBox("Enter Expectation Name:");
            studentMark = int.Parse(Interaction.InputBox("Enter Student Mark:"));

        }

        private void btnAddStrand_Click(object sender, EventArgs e)
        {

        }

        private void btnAddExpectation_Click(object sender, EventArgs e)
        {

        }
    }
}
