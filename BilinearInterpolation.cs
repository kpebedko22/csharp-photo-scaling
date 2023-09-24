using System.Drawing;

namespace PhotoCorrection {
	class BilinearInterpolation {
		/// <summary>
		/// Создание нового изображения на основе исходного с новыми размерами ширины и высоты
		/// </summary>
		/// <param name="original"></param>
		/// <param name="scaleX"></param>
		/// <param name="scaleY"></param>
		/// <returns></returns>
		public static Bitmap Scale(Bitmap original, float scaleX, float scaleY) {

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

					Color rgb = Color.FromArgb(red, green, blue);

					modified.SetPixel(x, y, rgb);
				}
			}

			return modified;
		}

		/// <summary>
		/// Интерполяция два раза по оси X
		/// <para>1. c00, c10</para> 
		/// <para>2. c01, c11</para>
		/// и по оси Y для вычисленных значений по оси X
		/// </summary>
		/// <param name="c00"></param>
		/// <param name="c10"></param>
		/// <param name="c01"></param>
		/// <param name="c11"></param>
		/// <param name="tx"></param>
		/// <param name="ty"></param>
		/// <returns></returns>
		private static float Blerp(float c00, float c10, float c01, float c11, float tx, float ty) {
			return Lerp(
				Lerp(c00, c10, tx),
				Lerp(c01, c11, tx),
				ty
			);
		}

		/// <summary>
		/// Интерполяция
		/// </summary>
		/// <param name="s">значение в точке 1</param>
		/// <param name="e">значение в точке 2</param>
		/// <param name="t">расстояние между точками</param>
		/// <returns></returns>
		private static float Lerp(float s, float e, float t) {
			return s + (e - s) * t;
		}
	}
}
