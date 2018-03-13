using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PlugNChug
{
    public partial class MainForm : Form
    {

        public static string SoftwareNameString = "Plug N Chug (v1.00)";
        public SoundPlayer snd = new SoundPlayer(Properties.Resources.getlucky);
        public string LineCountString = "";

        public MainForm()
        {
            InitializeComponent();

            this.Text = SoftwareNameString;

            VarBox.Text = "{{IV}} Open Consc Extra Agree Neuro" + "\r\n" +
                          "{{DV}} Happiness Sadness Depression";

            


        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            //BenderBox.Image = null;
            //FryBox.Image = null;
            VarBox.Enabled = false;
            CodeBox.Enabled = false;
            StartButton.Enabled = false;

            BgWorkerInformation BgInfo = new BgWorkerInformation();

            BgInfo.VarText = VarBox.Text;
            BgInfo.CodeText = CodeBox.Text;

            BGWorker.RunWorkerAsync(BgInfo);
            
        }


        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            BgWorkerInformation BgData = (BgWorkerInformation)e.Argument;
            string[] VarLines = BgData.VarText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            

            int NumVars = 0;
            List<string> VarPlaceholders = new List<string>();

            //get all of the split out info into a list
            List<Array> VarList = new List<Array>();
            for (int i = 0; i < VarLines.Length; i++) {

                string[] VarList_Split = (VarLines[i].Trim().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries));
                if (VarList_Split.Length > 1)
                {
                    NumVars++;
                    VarList.Add(VarList_Split.ToList().GetRange(1, VarList_Split.Length - 1).ToArray());
                    VarPlaceholders.Add(VarList_Split[0]);
                }

            }


            try { 
               

                    StatusLabel.Invoke((MethodInvoker)delegate
                    {
                        StatusLabel.Text = "Recursing variable combinations... This might take a while...";
                    });

                //Set up our code


                    List<string> RecursedVars = Recursion(0, VarList).Distinct().ToList();


                    using (StreamWriter outputFile = new StreamWriter(new FileStream("PlugNChug_Code.txt", FileMode.Create, FileAccess.Write), Encoding.UTF8))
                    {

                    outputFile.WriteLine("Input Variable Data:");
                    outputFile.WriteLine(BgData.VarText + "\r\n\r\n");
                    outputFile.WriteLine("Input Code Data:");
                    outputFile.WriteLine(BgData.CodeText + "\r\n\r\n");
                    outputFile.WriteLine("Code Output:\r\n");

                    int LineCount = RecursedVars.Count;
                    LineCountString = LineCount.ToString();

                        for (int i = 0; i < LineCount; i++)
                        {

                            StringBuilder OutputCode = new StringBuilder();
                            OutputCode.Append(BgData.CodeText);

                        StatusLabel.Invoke((MethodInvoker)delegate {
                            StatusLabel.Text = "Writing line " + (i + 1).ToString() + " of " + LineCountString;
                            StatusLabel.Invalidate();
                            StatusLabel.Update();
                            StatusLabel.Refresh();
                            Application.DoEvents();
                        });

                        string[] Var_Replacements = RecursedVars[i].Split(' ');
                            for (int j =0; j < NumVars; j++)
                            {
                                OutputCode.Replace(VarPlaceholders[j], Var_Replacements[j]);
                            }

                            outputFile.WriteLine(OutputCode.ToString());

                    }



                }
                

            }
            catch
            {
                MessageBox.Show("An error occurred while building your code.", "Ruh-roh!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }



        public class BgWorkerInformation
        {
            public string VarText { get; set; }
            public string CodeText { get; set; }
            
        }

        
        //code borrowed / modified from here:
        //https://stackoverflow.com/a/710716
        static List<string> Recursion(int a, List<Array> x)
        {
            List<string> retval = new List<string>();

            if (a == x.Count)
            {
                retval.Add("");
                return retval;
            }

            foreach (Object y in x[a])
            {
                foreach (string x2 in Recursion(a + 1, x))
                {
                    retval.Add(y.ToString() + " " + x2.ToString());
                    
                }


            }
            return retval;
        }






        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            StatusLabel.Text = "Finished!   :)";
            DialogResult dialogResult = MessageBox.Show("Your code has been assembled!\r\n\r\nWould you like to open the output file?", "Finished!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
                {
                try
                {
                    System.Diagnostics.Process.Start("explorer.exe", "PlugNChug_Code.txt");
                }
                catch
                {
                    MessageBox.Show("There was a problem when trying to open your output file.", "Ruh-roh!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                

            CodeBox.Enabled = true;
            VarBox.Enabled = true;
            StartButton.Enabled = true;
            
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {

            try { 
            snd.Stop();
            snd.PlayLooping();
            }
            catch
            {

            }

            BenderBox.Image = Properties.Resources.Bender;
            FryBox.Image = Properties.Resources.Fry;

            MessageBox.Show(SoftwareNameString + " by Ryan L. Boyd, Ph.D." + "\r\n\r\n" +
                            "This software is explicitly for use in exploring your data and teaching about the dangers of multiple hypothesis testing. The onus is upon you, the user, to ensure that your statistical analyses / code are appropriate for your work and that all best standards / guidelines / practices are being followed with the utmost conscientiousness and rigor.",
                            "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

            

        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        
        }


    }
}
