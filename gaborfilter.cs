using Accord.Imaging;
using Accord.Imaging.Filters;
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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
        }
        string featuredata = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,class";
        private int label = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;

            }
            string[] file = Directory.GetFiles(path);

            foreach (string s in file)
            {


                gabordataextract(s);
            }
            label++;
            MessageBox.Show("Done");
        }
        private double Runal(GaborFilter gaborFilter, Bitmap b)
        {
            try
            {
                Bitmap output = gaborFilter.Apply(b);

                Accord.Imaging.ImageStatistics statistics = new Accord.Imaging.ImageStatistics(output);
                var histogram = statistics.Gray;
                return histogram.Mean;
            }
            catch (Exception e) { return 0; }
            //    featuredata = featuredata + mean + ",";
        }
        private void gabordataextract(string s)
        {
            string dupImagePath = s;
            featuredata = featuredata + "\n";
            Bitmap org1 = (Bitmap)Accord.Imaging.Image.FromFile(dupImagePath);

            Accord.Imaging.Filters.GrayscaleBT709 gr = new Accord.Imaging.Filters.GrayscaleBT709();
            org1 = gr.Apply(org1);
            //Bitmap org2 = (Bitmap)org1.Clone();
            //Accord.Imaging.Filters.Difference filter = new Accord.Imaging.Filters.Difference(org2);

            //var noisefilter = new Accord.Imaging.Filters.SimpleSkeletonization();
            //Bitmap org0 = noisefilter.Apply(org1);
            
            //var noisefilter2 = new Accord.Imaging.Filters.BilateralSmoothing();
            //org0 = noisefilter2.Apply(org0);
            //org0 = noisefilter2.Apply(org0);

            //org1 = filter.Apply(org0);


            GaborFilter gfilter = new GaborFilter();

            {
                gfilter.Sigma = 2;


                {
                    gfilter.Lambda = 5;
                    /////
                    gfilter.Theta = 15;
                    // Apply the filter
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 45;
                    // Apply the filter
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 90;
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 135;
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    ///////////
                }

                {
                    gfilter.Lambda = 25;
                    /////
                    gfilter.Theta = 0;
                    // Apply the filter
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 45;
                    // Apply the filter               
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 90;
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 135;
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    ///////////
                    ///
                }
                {
                    gfilter.Lambda = 40;
                    /////
                    gfilter.Theta = 0;
                    // Apply the filter
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 45;
                    // Apply the filter
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 90;
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 135;
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    ///////////

                }
            }


            {
                gfilter.Sigma = 4;


                {
                    gfilter.Lambda = 15;
                    /////
                    gfilter.Theta = 0;
                    // Apply the filter
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 45;
                    // Apply the filter
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 90;
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 135;
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    ///////////
                }

                {
                    gfilter.Lambda = 25;
                    /////
                    gfilter.Theta = 0;
                    // Apply the filter


                    featuredata = featuredata + Runal(gfilter, org1) + ",";

                    gfilter.Theta = 45;
                    // Apply the filter
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 90;
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 135;
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    ///////////
                    ///
                }
                {
                    gfilter.Lambda = 40;
                    /////
                    gfilter.Theta = 0;
                    // Apply the filter
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 45;
                    // Apply the filter
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 90;
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 135;
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    ///////////

                }
            }


            {
                gfilter.Sigma = 5;


                {
                    gfilter.Lambda = 15;
                    /////
                    gfilter.Theta = 0;
                    // Apply the filter
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 45;
                    // Apply the filter
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 90;
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 135;
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    ///////////
                }

                {
                    gfilter.Lambda = 25;
                    /////
                    gfilter.Theta = 0;
                    // Apply the filter
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 45;
                    // Apply the filter
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 90;
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 135;
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    ///////////
                    ///
                }
                {
                    gfilter.Lambda = 40;
                    /////
                    gfilter.Theta = 0;
                    // Apply the filter
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 45;
                    // Apply the filter
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 90;
                    featuredata = featuredata + Runal(gfilter, org1) + ",";
                    gfilter.Theta = 135;
                    featuredata = featuredata + Runal(gfilter, org1) + ",";

                }
            }


            featuredata = featuredata + label;
            Console.WriteLine(featuredata+ label);

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText("JSMA_diff.csv", featuredata);
        }
    }
}
