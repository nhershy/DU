using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DU
{
    public partial class Form1 : Form
    {
        List<FolderOrFile> fofs = new List<FolderOrFile>();
        long totalSpaceUsed = 0;
        string outputTextfilePath = "";
        int limit = 2147483647;

        public Form1()
        {
            InitializeComponent();
            rdoC.Checked = true;
            rdoTextBox.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string startDir = getStartDir();
            DirSearch(startDir);
            if (cbLargestFirst.Checked)
                fofs.Sort();
            checkForLimit();
            print();
        }

        private void checkForLimit()
        {
            if (rdo50.Checked)
                limit = 50;
            if (rdo500.Checked)
                limit = 500;
            if (rdo1000.Checked)
                limit = 1000;
        }

        private void print()
        {
            if (rdoTextBox.Checked)
                printToTextbox();
            else
                printToFile();
        }

        private void printToTextbox()
        {
            int count = 0;
            foreach (var fof in fofs)
            {
                if (count >= limit)
                    break;
                if (fof.Dir)
                {
                    txtOutput.AppendText(fof.Name + "\n");
                }
                else
                {
                    string output = Helper.getSize(fof.Bytes) + fof.Name + "\n";
                    txtOutput.AppendText(output);
                }
                count++;
            }
            txtOutput.AppendText("Total space used: " + Helper.humanReadableSize(totalSpaceUsed));
        }

        private void printToFile()
        {
            int count = 0;
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(outputTextfilePath + "\\DiskUsageResults.txt"))
            {
                foreach (var fof in fofs)
                {
                    if (count >= limit)
                        break;
                    if (fof.Dir)
                    {
                        file.WriteLine(fof.Name);
                    }
                    else
                    {
                        file.WriteLine(Helper.getSize(fof.Bytes) + fof.Name);
                    }
                    count++;
                }
                file.WriteLine("Total space used: " + Helper.humanReadableSize(totalSpaceUsed));
                txtOutput.AppendText("file: DiskUsageResults.txt\n");
                txtOutput.AppendText("placed on: " + outputTextfilePath);
            }
        }

        private string getStartDir()
        {
            if (rdoC.Checked)
                return rdoC.Text;
            else if (rdoD.Checked)
                return rdoD.Text;
            else if (rdoE.Checked)
                return rdoE.Text;
            else
                return txtOther.Text;
        }

        private void DirSearch(string startDir)
        {
            try
            {
                foreach (string file in Directory.GetFiles(startDir))
                {
                    long size = Helper.getBytes(file);
                    totalSpaceUsed += size;
                    label1.Text = Helper.humanReadableSize(totalSpaceUsed).ToString();
                    FolderOrFile fof = new FolderOrFile(file, size, false);
                    fofs.Add(fof);
                }

                foreach (string dir in Directory.GetDirectories(startDir))
                {
                    FolderOrFile fof = new FolderOrFile(dir, 0, true);
                    fofs.Add(fof);
                    DirSearch(dir);
                }
            }
            catch (System.Exception ex)
            {
                txtOutput.AppendText(ex.Message + "\n");
            }
        }

        private void rdoOther_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOther.Checked)
            {
                FolderBrowserDialog fdb = new FolderBrowserDialog();
                if (fdb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtOther.Text = fdb.SelectedPath;
                }
            }
        }

        private void rdoTextFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTextFile.Checked)
            {
                FolderBrowserDialog fdb = new FolderBrowserDialog();
                if (fdb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    outputTextfilePath = fdb.SelectedPath;
                }
            }
        }
    }
}
