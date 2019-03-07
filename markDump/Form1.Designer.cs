namespace markDump
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddStrand = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.btnAddMark = new System.Windows.Forms.Button();
            this.btnAddExpectation = new System.Windows.Forms.Button();
            this.dataSheet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddStrand
            // 
            this.btnAddStrand.Location = new System.Drawing.Point(171, 12);
            this.btnAddStrand.Name = "btnAddStrand";
            this.btnAddStrand.Size = new System.Drawing.Size(153, 52);
            this.btnAddStrand.TabIndex = 0;
            this.btnAddStrand.Text = "Add Strand";
            this.btnAddStrand.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(12, 12);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(153, 52);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(635, 386);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(153, 52);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = "Save to File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(476, 386);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(153, 52);
            this.btnFileOpen.TabIndex = 3;
            this.btnFileOpen.Text = "Open File";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // btnAddMark
            // 
            this.btnAddMark.Location = new System.Drawing.Point(489, 12);
            this.btnAddMark.Name = "btnAddMark";
            this.btnAddMark.Size = new System.Drawing.Size(153, 52);
            this.btnAddMark.TabIndex = 4;
            this.btnAddMark.Text = "Add Mark";
            this.btnAddMark.UseVisualStyleBackColor = true;
            // 
            // btnAddExpectation
            // 
            this.btnAddExpectation.Location = new System.Drawing.Point(330, 12);
            this.btnAddExpectation.Name = "btnAddExpectation";
            this.btnAddExpectation.Size = new System.Drawing.Size(153, 52);
            this.btnAddExpectation.TabIndex = 5;
            this.btnAddExpectation.Text = "Add Expectation";
            this.btnAddExpectation.UseVisualStyleBackColor = true;
            // 
            // dataSheet
            // 
            this.dataSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSheet.Location = new System.Drawing.Point(12, 92);
            this.dataSheet.Name = "dataSheet";
            this.dataSheet.Size = new System.Drawing.Size(776, 251);
            this.dataSheet.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataSheet);
            this.Controls.Add(this.btnAddExpectation);
            this.Controls.Add(this.btnAddMark);
            this.Controls.Add(this.btnFileOpen);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnAddStrand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSheet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStrand;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.Button btnAddMark;
        private System.Windows.Forms.Button btnAddExpectation;
        private System.Windows.Forms.DataGridView dataSheet;
    }
}

