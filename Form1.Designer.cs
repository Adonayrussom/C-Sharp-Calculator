namespace Calculator
{
    partial class frmCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSecondnum = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.cboOperation = new System.Windows.Forms.ComboBox();
            this.lblOperators = new System.Windows.Forms.Label();
            this.txtfirstnum = new System.Windows.Forms.TextBox();
            this.txtsecondnum = new System.Windows.Forms.TextBox();
            this.txtresults = new System.Windows.Forms.TextBox();
            this.btnOperation = new System.Windows.Forms.Button();
            this.lblFirstnum = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSecondnum
            // 
            this.lblSecondnum.AutoSize = true;
            this.lblSecondnum.Location = new System.Drawing.Point(32, 78);
            this.lblSecondnum.Name = "lblSecondnum";
            this.lblSecondnum.Size = new System.Drawing.Size(93, 15);
            this.lblSecondnum.TabIndex = 3;
            this.lblSecondnum.Text = "Second Number";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(32, 188);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(44, 15);
            this.lblResults.TabIndex = 4;
            this.lblResults.Text = "Results";
            // 
            // cboOperation
            // 
            this.cboOperation.FormattingEnabled = true;
            this.cboOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "/",
            "%"});
            this.cboOperation.Location = new System.Drawing.Point(194, 133);
            this.cboOperation.Name = "cboOperation";
            this.cboOperation.Size = new System.Drawing.Size(121, 23);
            this.cboOperation.TabIndex = 5;
            this.cboOperation.SelectedIndexChanged += new System.EventHandler(this.cboOperation_SelectedIndexChanged);
            // 
            // lblOperators
            // 
            this.lblOperators.AutoSize = true;
            this.lblOperators.Location = new System.Drawing.Point(32, 133);
            this.lblOperators.Name = "lblOperators";
            this.lblOperators.Size = new System.Drawing.Size(59, 15);
            this.lblOperators.TabIndex = 6;
            this.lblOperators.Text = "Operators";
            // 
            // txtfirstnum
            // 
            this.txtfirstnum.Location = new System.Drawing.Point(194, 14);
            this.txtfirstnum.Name = "txtfirstnum";
            this.txtfirstnum.Size = new System.Drawing.Size(121, 23);
            this.txtfirstnum.TabIndex = 7;
            // 
            // txtsecondnum
            // 
            this.txtsecondnum.Location = new System.Drawing.Point(194, 78);
            this.txtsecondnum.Name = "txtsecondnum";
            this.txtsecondnum.Size = new System.Drawing.Size(121, 23);
            this.txtsecondnum.TabIndex = 8;
            // 
            // txtresults
            // 
            this.txtresults.Location = new System.Drawing.Point(194, 188);
            this.txtresults.Name = "txtresults";
            this.txtresults.Size = new System.Drawing.Size(121, 23);
            this.txtresults.TabIndex = 9;
            // 
            // btnOperation
            // 
            this.btnOperation.Location = new System.Drawing.Point(33, 248);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(75, 23);
            this.btnOperation.TabIndex = 10;
            this.btnOperation.Text = "Add";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // lblFirstnum
            // 
            this.lblFirstnum.AutoSize = true;
            this.lblFirstnum.Location = new System.Drawing.Point(32, 17);
            this.lblFirstnum.Name = "lblFirstnum";
            this.lblFirstnum.Size = new System.Drawing.Size(76, 15);
            this.lblFirstnum.TabIndex = 11;
            this.lblFirstnum.Text = "First Number";
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(211, 248);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 12;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click_1);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 301);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.lblFirstnum);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.txtresults);
            this.Controls.Add(this.txtsecondnum);
            this.Controls.Add(this.txtfirstnum);
            this.Controls.Add(this.lblOperators);
            this.Controls.Add(this.cboOperation);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblSecondnum);
            this.Name = "frmCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblSecondnum;
        private Label lblResults;
        private ComboBox cboOperation;
        private Label lblOperators;
        private TextBox txtfirstnum;
        private TextBox txtsecondnum;
        private TextBox txtresults;
        private Button btnOperation;
        private Label lblFirstnum;
        private Button btnreset;
    }
}