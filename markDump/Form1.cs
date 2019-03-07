using System;
using System.Collections;
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
        double culmMark;
        ArrayList strands = new ArrayList();
         
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            studentName = Interaction.InputBox("What is the student's name?");
            WriteData(studentName, 0, 0);
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

        public void WriteData(string input, int x, int y)
        {
            excel.WriteToCell(x, y, input);
            excel.Save();
            MessageBox.Show(excel.ReadCell(0, 0));

        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            studentName = Interaction.InputBox("Enter Student Name:");
            string strandName = Interaction.InputBox("Enter Strand Name:");
            string expectationName = Interaction.InputBox("Enter Expectation Name:");
            double mark = double.Parse(Interaction.InputBox("Enter Assignment Mark:"));
            double weight = double.Parse(Interaction.InputBox("Enter Mark Weight:"));

            Strand strandUsed = new Strand("", 0);

            foreach (Strand s in strands)
            {
                if (s.name == strandName)
                {
                    strandUsed = s;
                    break;
                }
            }

            Expectation exUsed = new Expectation("", 0);

            foreach (Expectation ex in strandUsed.expectationList)
            {
                if (ex.name == expectationName)
                {
                    exUsed = ex;
                    break;
                }
            }

            exUsed.assignmentList.Add(new Assignment(mark, weight));
        }

        private void btnAddStrand_Click(object sender, EventArgs e)
        {
            string tempName = Interaction.InputBox("Enter Strand Name:");
            double tempWeight = double.Parse(Interaction.InputBox("Enter Strand Weight:"));

            //strands.Add(new Strand(tempName, tempWeight));
        }

        private void btnAddExpectation_Click(object sender, EventArgs e)
        {
            string strandName = Interaction.InputBox("Enter Strand Name:");

            Strand strandUsed = new Strand("", 0);

            foreach (Strand s in strands)
            {
                if (s.name == strandName)
                {
                    strandUsed = s;
                    break;
                }
            }

            string tempName = Interaction.InputBox("Enter Expectation Name:");
            double tempWeight = double.Parse(Interaction.InputBox("Enter Expectation Weight:"));
            strandUsed.expectationList.Add(new Expectation(tempName, tempWeight));
        }       

        private void btnCulm_Click(object sender, EventArgs e)
        {
            culmMark = double.Parse(Interaction.InputBox("Enter Culminating Mark:")) * 0.3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double courseMark = 0;
            foreach (Strand s in strands)
            {
                courseMark += s.CalculateMark() * s.weight * 0.7;
            }

            double finalMark = courseMark + culmMark;

            WriteData(finalMark + "", 0, 1);
        }
    }
}
