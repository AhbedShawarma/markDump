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

namespace markDump
{
    public partial class Form1 : Form
    {
        //DataSet result;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //studentName = 
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            //using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook *.xls", ValidateNames = true })
            //{
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
            //        IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fs);
            //        reader.IsFirstRowAsColumnNames = true;
            //    }
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFile();
        }

        public void OpenFile()
        {
            //Excel 
        }
    }
}
