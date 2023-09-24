using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PhotoCorrection {
	class BilinearInterpolation {

		public static Bitmap Scale(Bitmap original, float scaleX, float scaleY) {
            /* Функция создания нового изображения на основе исходного
             * с новыми размерами ширины и высоты
             */

            int newWidth = (int)(original.Width * scaleX);
            int newHeight = (int)(original.Height * scaleY);

            Bitmap modified = new Bitmap(newWidth, newHeight, original.PixelFormat);

            for (int x = 0; x < newWidth; x++) {
                for (int y = 0; y < newHeight; y++) {
                    float gx = ((float)x) / newWidth * (original.Width - 1);
                    float gy = ((float)y) / newHeight * (original.Height - 1);
                    int gxi = (int)gx;
                    int gyi = (int)gy;
                    Color c00 = original.GetPixel(gxi, gyi);
                    Color c10 = original.GetPixel(gxi + 1, gyi);
                    Color c01 = original.GetPixel(gxi, gyi + 1);
                    Color c11 = original.GetPixel(gxi + 1, gyi + 1);

                    int red = (int)Blerp(c00.R, c10.R, c01.R, c11.R, gx - gxi, gy - gyi);
                    int green = (int)Blerp(c00.G, c10.G, c01.G, c11.G, gx - gxi, gy - gyi);
                    int blue = (int)Blerp(c00.B, c10.B, c01.B, c11.B, gx - gxi, gy - gyi);

                    if (red < 0) Console.Write("r < 0"); else if (red > 255) Console.Write("r >255");
                    if (green < 0) Console.Write("g < 0"); else if (green > 255) Console.Write("g >255");
                    if (blue < 0) Console.Write("b < 0"); else if (blue > 255) Console.Write("b >255");


                    Color rgb = Color.FromArgb(red, green, blue);
                    modified.SetPixel(x, y, rgb);
                }
            }

            return modified;
        }

        private static float Blerp(float c00, float c10, float c01, float c11, float tx, float ty) {
            /* Интерполяция два раза по оси X:
             * 1. c00, c10
             * 2. c01, c11
             * и по оси Y для вычисленных значений по оси X
             */
            return Lerp(Lerp(c00, c10, tx), Lerp(c01, c11, tx), ty);
        }
        
        private static float Lerp(float s, float e, float t) {
            /* Интерполяция 
             * s - значение в точке 1
             * e - значение в точке 2
             * t - расстояние между точками
             */
            return s + (e - s) * t;
        }
    }
}
