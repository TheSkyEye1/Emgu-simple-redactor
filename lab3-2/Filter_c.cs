using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using Microsoft.CSharp.RuntimeBinder;

namespace lab3_2
{
    class Filter_c
    {
       public Image<Bgr, byte> grayfilter(Image<Bgr,byte> simage)
       {
            var grayImage = simage.Copy();

            for (int i = 0; i < 640; i++)
            {
                for (int j = 0; j < 480; j++)
                {
                    for (int c = 0; c <= 2; c++)
                    {
                        grayImage.Data[j, i, c] = Convert.ToByte(0.1 * grayImage.Data[j, i, 0] + 0.6 * grayImage.Data[j, i, 1] + 0.3 * grayImage.Data[j, i, 2]);
                    }
                }
            }
            return grayImage;
       }

        public Image<Bgr,byte> channelfilter(Image<Bgr,byte> simage, int i)
        {
            var channel = simage.Split()[i];
            Image<Bgr, byte> destImage = simage.CopyBlank();
            VectorOfMat vm = new VectorOfMat();
            switch (i)
            {
                case 0:
                    {
                        vm.Push(channel);
                        vm.Push(channel.CopyBlank());
                        vm.Push(channel.CopyBlank());
                        break;
                    }
                case 1:
                    {
                        vm.Push(channel.CopyBlank());
                        vm.Push(channel);
                        vm.Push(channel.CopyBlank());
                        break;
                    }
                case 2:
                    {
                        vm.Push(channel.CopyBlank());
                        vm.Push(channel.CopyBlank());
                        vm.Push(channel);
                        break;
                    }
            }
            CvInvoke.Merge(vm, destImage);
            return destImage;
        }

        public Image<Bgr,byte> loadfunction(Image<Bgr, byte> image)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;*.png";
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                image = new Image<Bgr, byte>(fileName).Resize(640, 480, Inter.Linear);
            }
            return image;
        }

        public Image<Bgr, byte> additionsimple(Image<Bgr, byte> image, Image<Bgr, byte> secimage, int sum, double cf1, double cf2)
        {
            var brightimage = image.Copy();
            for (int i = 0; i < 640; i++)
            {
                for (int j = 0; j < 480; j++)
                {
                    for (int c = 0; c <= 2; c++)
                    {
                        if (secimage != null)
                        {
                            if ((image.Data[j, i, c] * cf1 + secimage.Data[j, i, c] * cf2) > 255)
                            {
                                brightimage.Data[j, i, c] = 255;
                            }
                            else
                            {
                                brightimage.Data[j, i, c] = Convert.ToByte(image.Data[j, i, c] * cf1 + secimage.Data[j, i, c] * cf2);
                            }
                        }
                        else
                        {
                            if ((brightimage.Data[j, i, c] + sum) > 255)
                            {
                                brightimage.Data[j, i, c] = 255;
                            }
                            else
                            {
                                brightimage.Data[j, i, c] += Convert.ToByte(sum);
                            }
                        }
                    }
                }
            }
            return brightimage;
        }

        public Image<Bgr, byte> exceptionsimple(Image<Bgr, byte> image,Image<Bgr, byte> secimage, int sum, double cf1, double cf2)
        {
            var brightimage = image.Copy();
            for (int i = 0; i < 640; i++)
            {
                for (int j = 0; j < 480; j++)
                {
                    for (int c = 0; c <= 2; c++)
                    {
                        if (secimage != null)
                        {
                            if (Convert.ToInt16(image.Data[j, i, c] * cf1 - secimage.Data[j, i, c] * cf2) < 0)
                            {
                                brightimage.Data[j, i, c] = 0;
                            }
                            else
                            {
                                brightimage.Data[j, i, c] = Convert.ToByte(image.Data[j, i, c] * cf1 - secimage.Data[j, i, c] * cf2);
                            }
                        }
                        else
                        {
                            if ((Convert.ToInt32(brightimage.Data[j, i, c]) + sum) < 0)
                            {
                                brightimage.Data[j, i, c] = 0;
                            }
                            else
                            {
                                brightimage.Data[j, i, c] = Convert.ToByte(Convert.ToInt16(brightimage.Data[j, i, c]) + sum);
                            }
                        }
                    }
                }
            }
            return brightimage;
        }

        public Image<Bgr, byte> intersectionsimple(Image<Bgr, byte> image, Image<Bgr, byte> secimage, double sum, double cf1, double cf2)
        {
            var contrastimage = image.Copy();
            for (int i = 0; i < 640; i++)
            {
                for (int j = 0; j < 480; j++)
                {
                    for (int c = 0; c <= 2; c++)
                    {
                        if (secimage != null)
                        {
                            if (Convert.ToDouble((image.Data[j, i, c] * cf1 /10) * (secimage.Data[j, i, c] * cf2/10)) > 255)
                            {
                                contrastimage.Data[j, i, c] = 255;
                            }
                            else
                            {
                                contrastimage.Data[j, i, c] = Convert.ToByte((image.Data[j, i, c] * cf1/10) * (secimage.Data[j, i, c] * cf2/10));
                            }
                        }
                        else
                        {
                            if ((contrastimage.Data[j, i, c] * Convert.ToDouble(sum/10)) > 255)
                            {
                                contrastimage.Data[j, i, c] = 255;
                            }
                            else
                            {
                                contrastimage.Data[j, i, c] = Convert.ToByte(contrastimage.Data[j, i, c] * Convert.ToDouble(sum / 10));
                            }
                        }
                    }
                }
            }
            return contrastimage;
        }

        public Image<Bgr,byte> blurfil(Image<Bgr,byte> image)
        {
            var blurimg = image;
            var finalimage = blurimg.CopyBlank();

            for (int i = 1; i < 639; i++)
            {
                for (int j = 1; j < 479; j++)
                {
                    for (int c = 0; c <= 2; c++)
                    {
                        List<byte> blurl = new List<byte>();
                        for (int x = -1; x < 2; x++)
                        {
                            for (int y = -1; y < 2; y++)
                            {
                                blurl.Add(blurimg.Data[j + y, i + x, c]);
                            }
                        }
                        blurl.Sort();
                        finalimage.Data[j, i, c] = blurl[4];
                    }
                }
            }
            return finalimage;
        }

        public Image<Bgr, byte> matrixfilter(Image<Bgr, byte> imgae, int[,] mat)
        {
            var sharpimage = imgae.Copy();
            var finalimage = sharpimage.CopyBlank();
            for (int i = 1; i < 639; i++)
            {
                for (int j = 1; j < 479; j++)
                {
                    for (int c = 0; c <= 2; c++)
                    {
                        int result = 0;
                        for (int x = -1; x < 2; x++)
                        {
                            for (int y = -1; y < 2; y++)
                            {
                                result += sharpimage.Data[j + y, i + x, c] * mat[x + 1, y + 1];
                            }
                        }

                        if (result > 255) result = 255; else if (result < 0) result = 0;
                        finalimage.Data[j, i, c] = Convert.ToByte(result);
                    }
                }
            }
            return finalimage;
        }

        public Image<Bgr, byte> samef(Image<Bgr, byte> image, Image<Bgr, byte> secimage, double cf1, double cf2)
        {
            var finalimage = image.CopyBlank();
            for (int i = 0; i < 640; i++)
            {
                for (int j = 0; j < 480; j++)
                {
                    for (int c = 0; c <= 2; c++)
                    {
                        if (secimage.Data[j,i,c] == 0)
                        {
                            finalimage.Data[j, i, c] = Convert.ToByte(secimage.Data[j, i, c] * cf2); 
                        }
                        else
                        {
                            finalimage.Data[j, i, c] = Convert.ToByte(image.Data[j, i, c] * cf1);
                        }
                    }
                }
                
            }
            return finalimage;
        }

        public Image<Bgr, byte> sepiah(Image<Bgr, byte> image)
        {
            var sepiahimage = image.Copy();
            for (int i = 0; i < 640; i++)
            {
                for (int j = 0; j < 480; j++)
                {
                    for (int c = 0; c <= 2; c++)
                    {
                        switch (c)
                        {
                            case 0:
                                {
                                    if ((0.131 * image.Data[j, i, 0] + 0.534 * image.Data[j, i, 1] + 0.279 * image.Data[j, i, 2]) > 255)
                                    {
                                        sepiahimage.Data[j, i, c] = 255;
                                    }
                                    else
                                    {
                                        sepiahimage.Data[j, i, c] = Convert.ToByte(0.131 * image.Data[j, i, 0] + 0.534 * image.Data[j, i, 1] + 0.279 * image.Data[j, i, 2]);
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    if ((0.168 * image.Data[j, i, 0] + 0.686 * image.Data[j, i, 1] + 0.168 * image.Data[j, i, 2]) > 255)
                                    {
                                        sepiahimage.Data[j, i, c] = 255;
                                    }
                                    else
                                    {
                                        sepiahimage.Data[j, i, c] = Convert.ToByte(0.168 * image.Data[j, i, 0] + 0.686 * image.Data[j, i, 1] + 0.168 * image.Data[j, i, 2]);
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    if ((0.189 * image.Data[j, i, 0] + 0.769 * image.Data[j, i, 1] + 0.393 * image.Data[j, i, 2]) > 255)
                                    {
                                        sepiahimage.Data[j, i, c] = 255;
                                    }
                                    else
                                    {
                                        sepiahimage.Data[j, i, c] = Convert.ToByte(0.189 * image.Data[j, i, 0] + 0.769 * image.Data[j, i, 1] + 0.393 * image.Data[j, i, 2]);
                                    }
                                    break;
                                }
                        }
                    }
                }
            }
            return sepiahimage;
        }

        public Image<Bgr, byte> edgefil(Image<Bgr,byte> image)
        {
            var edges = grayfilter(image);
            edges = edges.ThresholdAdaptive(new Gray(255), AdaptiveThresholdType.MeanC,ThresholdType.Binary, 3, new Gray(0.03));
            return edges;
        }

        public Image<Bgr, byte> samef1(Image<Bgr, byte> image, Image<Gray, byte> secimage, double cf1, double cf2)
        {
            var finalimage = image.CopyBlank();
            for (int i = 0; i < 640; i++)
            {
                for (int j = 0; j < 480; j++)
                {
                    for (int c = 0; c <= 2; c++)
                    {
                        if (secimage.Data[j, i, c] == 255)
                        {
                            finalimage.Data[j, i, c] = Convert.ToByte(image.Data[j, i, c] * cf1); 
                        }
                        else
                        {
                            finalimage.Data[j, i, c] = Convert.ToByte(secimage.Data[j, i, c] * cf2);
                        }
                    }
                }

            }
            return finalimage;
        }
    }
}
