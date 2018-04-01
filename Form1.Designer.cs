namespace DU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRun = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.rdoC = new System.Windows.Forms.RadioButton();
            this.groupStartDir = new System.Windows.Forms.GroupBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoE = new System.Windows.Forms.RadioButton();
            this.rdoD = new System.Windows.Forms.RadioButton();
            this.groupOutput = new System.Windows.Forms.GroupBox();
            this.rdoTextFile = new System.Windows.Forms.RadioButton();
            this.rdoTextBox = new System.Windows.Forms.RadioButton();
            this.groupOrder = new System.Windows.Forms.GroupBox();
            this.cbLargestFirst = new System.Windows.Forms.CheckBox();
            this.groupLimit = new System.Windows.Forms.GroupBox();
            this.rdo1000 = new System.Windows.Forms.RadioButton();
            this.rdo500 = new System.Windows.Forms.RadioButton();
            this.rdo50 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupStartDir.SuspendLayout();
            this.groupOutput.SuspendLayout();
            this.groupOrder.SuspendLayout();
            this.groupLimit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(533, 51);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(77, 60);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 124);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(616, 389);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.WordWrap = false;
            // 
            // rdoC
            // 
            this.rdoC.AutoSize = true;
            this.rdoC.Location = new System.Drawing.Point(6, 19);
            this.rdoC.Name = "rdoC";
            this.rdoC.Size = new System.Drawing.Size(40, 17);
            this.rdoC.TabIndex = 9;
            this.rdoC.TabStop = true;
            this.rdoC.Text = "C:\\";
            this.rdoC.UseVisualStyleBackColor = true;
            // 
            // groupStartDir
            // 
            this.groupStartDir.Controls.Add(this.txtOther);
            this.groupStartDir.Controls.Add(this.rdoOther);
            this.groupStartDir.Controls.Add(this.rdoE);
            this.groupStartDir.Controls.Add(this.rdoD);
            this.groupStartDir.Controls.Add(this.rdoC);
            this.groupStartDir.Location = new System.Drawing.Point(12, 66);
            this.groupStartDir.Name = "groupStartDir";
            this.groupStartDir.Size = new System.Drawing.Size(489, 45);
            this.groupStartDir.TabIndex = 10;
            this.groupStartDir.TabStop = false;
            this.groupStartDir.Text = "Start Directory";
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(199, 18);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(284, 20);
            this.txtOther.TabIndex = 13;
            this.txtOther.Text = "F:\\";
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(130, 19);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(63, 17);
            this.rdoOther.TabIndex = 12;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other ->";
            this.rdoOther.UseVisualStyleBackColor = true;
            this.rdoOther.CheckedChanged += new System.EventHandler(this.rdoOther_CheckedChanged);
            // 
            // rdoE
            // 
            this.rdoE.AutoSize = true;
            this.rdoE.Location = new System.Drawing.Point(89, 19);
            this.rdoE.Name = "rdoE";
            this.rdoE.Size = new System.Drawing.Size(40, 17);
            this.rdoE.TabIndex = 11;
            this.rdoE.TabStop = true;
            this.rdoE.Text = "E:\\";
            this.rdoE.UseVisualStyleBackColor = true;
            // 
            // rdoD
            // 
            this.rdoD.AutoSize = true;
            this.rdoD.Location = new System.Drawing.Point(47, 19);
            this.rdoD.Name = "rdoD";
            this.rdoD.Size = new System.Drawing.Size(41, 17);
            this.rdoD.TabIndex = 10;
            this.rdoD.TabStop = true;
            this.rdoD.Text = "D:\\";
            this.rdoD.UseVisualStyleBackColor = true;
            // 
            // groupOutput
            // 
            this.groupOutput.Controls.Add(this.rdoTextFile);
            this.groupOutput.Controls.Add(this.rdoTextBox);
            this.groupOutput.Location = new System.Drawing.Point(12, 12);
            this.groupOutput.Name = "groupOutput";
            this.groupOutput.Size = new System.Drawing.Size(150, 48);
            this.groupOutput.TabIndex = 11;
            this.groupOutput.TabStop = false;
            this.groupOutput.Text = "Output";
            // 
            // rdoTextFile
            // 
            this.rdoTextFile.AutoSize = true;
            this.rdoTextFile.Location = new System.Drawing.Point(75, 19);
            this.rdoTextFile.Name = "rdoTextFile";
            this.rdoTextFile.Size = new System.Drawing.Size(59, 17);
            this.rdoTextFile.TabIndex = 1;
            this.rdoTextFile.TabStop = true;
            this.rdoTextFile.Text = "Textfile";
            this.rdoTextFile.UseVisualStyleBackColor = true;
            this.rdoTextFile.CheckedChanged += new System.EventHandler(this.rdoTextFile_CheckedChanged);
            // 
            // rdoTextBox
            // 
            this.rdoTextBox.AutoSize = true;
            this.rdoTextBox.Location = new System.Drawing.Point(6, 19);
            this.rdoTextBox.Name = "rdoTextBox";
            this.rdoTextBox.Size = new System.Drawing.Size(63, 17);
            this.rdoTextBox.TabIndex = 0;
            this.rdoTextBox.TabStop = true;
            this.rdoTextBox.Text = "Textbox";
            this.rdoTextBox.UseVisualStyleBackColor = true;
            // 
            // groupOrder
            // 
            this.groupOrder.Controls.Add(this.cbLargestFirst);
            this.groupOrder.Location = new System.Drawing.Point(168, 12);
            this.groupOrder.Name = "groupOrder";
            this.groupOrder.Size = new System.Drawing.Size(120, 48);
            this.groupOrder.TabIndex = 12;
            this.groupOrder.TabStop = false;
            this.groupOrder.Text = "Order";
            // 
            // cbLargestFirst
            // 
            this.cbLargestFirst.AutoSize = true;
            this.cbLargestFirst.Location = new System.Drawing.Point(6, 20);
            this.cbLargestFirst.Name = "cbLargestFirst";
            this.cbLargestFirst.Size = new System.Drawing.Size(107, 17);
            this.cbLargestFirst.TabIndex = 0;
            this.cbLargestFirst.Text = "Largest Files First";
            this.cbLargestFirst.UseVisualStyleBackColor = true;
            // 
            // groupLimit
            // 
            this.groupLimit.Controls.Add(this.rdo1000);
            this.groupLimit.Controls.Add(this.rdo500);
            this.groupLimit.Controls.Add(this.rdo50);
            this.groupLimit.Location = new System.Drawing.Point(294, 12);
            this.groupLimit.Name = "groupLimit";
            this.groupLimit.Size = new System.Drawing.Size(153, 48);
            this.groupLimit.TabIndex = 13;
            this.groupLimit.TabStop = false;
            this.groupLimit.Text = "Output Limit Shown";
            // 
            // rdo1000
            // 
            this.rdo1000.AutoSize = true;
            this.rdo1000.Location = new System.Drawing.Point(98, 19);
            this.rdo1000.Name = "rdo1000";
            this.rdo1000.Size = new System.Drawing.Size(49, 17);
            this.rdo1000.TabIndex = 2;
            this.rdo1000.TabStop = true;
            this.rdo1000.Text = "1000";
            this.rdo1000.UseVisualStyleBackColor = true;
            // 
            // rdo500
            // 
            this.rdo500.AutoSize = true;
            this.rdo500.Location = new System.Drawing.Point(49, 20);
            this.rdo500.Name = "rdo500";
            this.rdo500.Size = new System.Drawing.Size(43, 17);
            this.rdo500.TabIndex = 1;
            this.rdo500.TabStop = true;
            this.rdo500.Text = "500";
            this.rdo500.UseVisualStyleBackColor = true;
            // 
            // rdo50
            // 
            this.rdo50.AutoSize = true;
            this.rdo50.Location = new System.Drawing.Point(6, 20);
            this.rdo50.Name = "rdo50";
            this.rdo50.Size = new System.Drawing.Size(37, 17);
            this.rdo50.TabIndex = 0;
            this.rdo50.TabStop = true;
            this.rdo50.Text = "50";
            this.rdo50.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Total Size...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupLimit);
            this.Controls.Add(this.groupOrder);
            this.Controls.Add(this.groupOutput);
            this.Controls.Add(this.groupStartDir);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Disk Usage     author: Nicholas Hershy";
            this.groupStartDir.ResumeLayout(false);
            this.groupStartDir.PerformLayout();
            this.groupOutput.ResumeLayout(false);
            this.groupOutput.PerformLayout();
            this.groupOrder.ResumeLayout(false);
            this.groupOrder.PerformLayout();
            this.groupLimit.ResumeLayout(false);
            this.groupLimit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.RadioButton rdoC;
        private System.Windows.Forms.GroupBox groupStartDir;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.RadioButton rdoE;
        private System.Windows.Forms.RadioButton rdoD;
        private System.Windows.Forms.GroupBox groupOutput;
        private System.Windows.Forms.RadioButton rdoTextBox;
        private System.Windows.Forms.RadioButton rdoTextFile;
        private System.Windows.Forms.GroupBox groupOrder;
        private System.Windows.Forms.CheckBox cbLargestFirst;
        private System.Windows.Forms.GroupBox groupLimit;
        private System.Windows.Forms.RadioButton rdo1000;
        private System.Windows.Forms.RadioButton rdo500;
        private System.Windows.Forms.RadioButton rdo50;
        private System.Windows.Forms.Label label1;
    }
}

