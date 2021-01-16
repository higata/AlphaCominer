using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlpaCombiner
{
    internal class AlphaCombinerLogic
    {

        public Image Combine(Image src, Image gray, bool isKeepSrcAlpha)
        {
            if (src == null || gray == null)
            {
                return null;
            }

            Bitmap srcB = new Bitmap(src);
            Bitmap grayB = new Bitmap(gray);
            if (srcB.Width != grayB.Width || srcB.Height != grayB.Height)
            {
                return null;
            }

            Bitmap ret = new Bitmap(srcB.Width, srcB.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (int x = 0; x < srcB.Width; x++)
            {
                for (int y = 0; y < srcB.Height; y++)
                {
                    var a = srcB.GetPixel(x, y);
                    var b = grayB.GetPixel(x, y);
                    if (isKeepSrcAlpha)
                    {
                        if (a.A == 0)
                        {
                            ret.SetPixel(x, y, Color.FromArgb(0, a.R, a.G, a.B));
                        }
                        else
                        {
                            ret.SetPixel(x, y, Color.FromArgb(b.R, a.R, a.G, a.B));
                        }
                    }
                    else
                    {
                        ret.SetPixel(x, y, Color.FromArgb(b.R, a.R, a.G, a.B));
                    }

                }
            }
            return ret;
        }
    }
}
