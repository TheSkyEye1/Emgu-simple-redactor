using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace lab3_2
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> sourceImage;
        private int chaneln;
        private Image<Bgr, byte> opImage;
        private int logicop = 1;
        private Image<Bgr, byte> maskImage;
        Filter_c fil = new Filter_c();
        public Form1()
        {
            InitializeComponent();
            chaneln = chnltrack.Value;
        }

        private void loadbutton_Click(object sender, EventArgs e)
        {
            sourceImage = fil.loadfunction(sourceImage);
            if (sourceImage != null)
            {
                IMG1.Image = sourceImage;
                IMG2.Image = sourceImage;
            }
        }
        private void channelb_Click(object sender, EventArgs e)
        {
            IMG2.Image = fil.channelfilter(sourceImage, chnltrack.Value);
        }

        private void chnltrack_ValueChanged(object sender, EventArgs e)
        {
            chaneln = chnltrack.Value;
            int i = chnltrack.Value;
            switch (i)
            {
                case 0:
                    {
                        cnn.Text = "Channel: blue";
                        break;
                    }
                case 1:
                    {
                        cnn.Text = "Channel: green";
                        break;
                    }
                case 2:
                    {
                        cnn.Text = "Channel: red";
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IMG2.Image = fil.grayfilter(sourceImage);
        }

        private void brt_Scroll(object sender, EventArgs e)
        {
            brtl.Text = Convert.ToString(brt.Value - 255);
        }

        private void bright_Click(object sender, EventArgs e)
        {
            if(brt.Value > 255)
            {
                IMG2.Image = fil.additionsimple(sourceImage,null, brt.Value - 255, 1, 1);
            }
            else
            {
                IMG2.Image = fil.exceptionsimple(sourceImage,null, brt.Value - 255, 1, 1);
            }
            
        }

        private void cnt_Scroll(object sender, EventArgs e)
        {
            conl.Text = Convert.ToString(Convert.ToDouble(cont.Value) / 10);
        }

        private void contra_Click(object sender, EventArgs e)
        {
            
            IMG2.Image = fil.intersectionsimple(sourceImage,null, cont.Value,1,1);
        }

        private void sepiah_Click(object sender, EventArgs e)
        {
            IMG2.Image = fil.sepiah(sourceImage);
        }
        private void rb1_Click(object sender, EventArgs e)
        {
            logicop = 1;
            rb1.Checked = true;
            rb2.Checked = false;
            rb3.Checked = false;
        }

        private void rb2_Click(object sender, EventArgs e)
        {

            logicop = 2;
            rb1.Checked = false;
            rb2.Checked = true;
            rb3.Checked = false;
        }

        private void rb3_Click(object sender, EventArgs e)
        {
            logicop = 3;
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = true;
        }

        private void img1c_Scroll(object sender, EventArgs e)
        {
            img1l.Text = Convert.ToString(Convert.ToDouble(img1c.Value) / 10);
            img2c.Value = 10 - img1c.Value;
            img2l.Text = Convert.ToString(Convert.ToDouble(img2c.Value) / 10);
        }

        private void img2c_Scroll(object sender, EventArgs e)
        {
            img2l.Text = Convert.ToString(Convert.ToDouble(img2c.Value) / 10);
            img1c.Value = 10 - img2c.Value;
            img1l.Text = Convert.ToString(Convert.ToDouble(img1c.Value) / 10);
        }

        private void opb_Click(object sender, EventArgs e)
        {
            var cf1 = (Convert.ToDouble(img1c.Value)) / 10;
            var cf2 = (Convert.ToDouble(img2c.Value)) / 10;
            switch (logicop)
            {
                case 1:
                    {
                        IMG2.Image = fil.additionsimple(sourceImage,opImage,1,cf1,cf2);
                        break;
                    }
                case 2:
                    {
                        IMG2.Image = fil.exceptionsimple(sourceImage, opImage, 1, cf1, cf2);
                        break;
                    }
                case 3:
                    {
                        IMG2.Image = fil.samef(sourceImage, opImage, cf1, cf2);
                        break;
                    }
            }
        }

        private void loadsecond_Click(object sender, EventArgs e)
        {
            opImage = fil.loadfunction(opImage);
        }

        private void medblur_Click(object sender, EventArgs e)
        {
            IMG2.Image = fil.blurfil(sourceImage);
        }

        private void sharp_Click(object sender, EventArgs e)
        {
            int[,] mass = new int[3, 3]
            {
                {-1,-1,-1},
                {-1,9,-1 },
                { -1,-1,-1}
            };            
            IMG2.Image = fil.matrixfilter(sourceImage,mass);
        }

        private void embosb_Click(object sender, EventArgs e)
        {
            int[,] mass = new int[3, 3]
            {
                {-4,-2,0},
                {-2,1,2 },
                { 0,2,4}
            };
            IMG2.Image = fil.matrixfilter(sourceImage, mass);
        }

        private void edgeb_Click(object sender, EventArgs e)
        {
            int[,] mass = new int[3, 3]
            {
                {0,0,0},
                {-4,4,0 },
                { 0,0,0}
            };
            IMG2.Image = fil.matrixfilter(sourceImage, mass);
        }

        private void mask1_Click(object sender, EventArgs e)
        {
            maskImage = fil.loadfunction(maskImage);
        }

        private void mask2_Click(object sender, EventArgs e)
        {
            maskImage = fil.loadfunction(maskImage);
        }

        private void mask3_Click(object sender, EventArgs e)
        {
            maskImage = fil.loadfunction(maskImage);
        }

        private void aquabut_Click(object sender, EventArgs e)
        {
            IMG2.Image = fil.additionsimple(fil.blurfil(fil.intersectionsimple(fil.additionsimple(sourceImage, null, 10, 1, 1), null, 14, 1, 1)), maskImage, 1, 0.7, 0.3);
        }

        private void edg_Click(object sender, EventArgs e)
        {
            IMG2.Image = fil.edgefil(sourceImage);
        }

        private void cartfb_Click(object sender, EventArgs e)
        {
            IMG2.Image = fil.carton(sourceImage);
        }

        private void hsvbtn_Click(object sender, EventArgs e)
        {
            IMG2.Image = fil.hsvconvert(sourceImage);
        }

        private void hsvc_Click(object sender, EventArgs e)
        {
            
            IMG2.Image = fil.hsvadd(sourceImage, hsvch.Value, hsvtr.Value);
        }

        
    }
}
