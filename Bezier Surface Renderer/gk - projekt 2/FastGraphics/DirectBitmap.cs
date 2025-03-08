using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace gk___projekt_2.FastGraphics
{
    // source: https://stackoverflow.com/a/34801225
    public class DirectBitmap : IDisposable
    {
        public Bitmap Bitmap { get; private set; }
        public int[] Bits { get; private set; }
        public bool Disposed { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }

        protected GCHandle BitsHandle { get; private set; }

        public DirectBitmap(int width, int height)
        {
            Width = width;
            Height = height;

            Bits = new int[width * height];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppPArgb, BitsHandle.AddrOfPinnedObject());
        }
        public DirectBitmap(Bitmap bitmap) : this(bitmap.Width, bitmap.Height)
        {
            using Graphics graphics = Graphics.FromImage(Bitmap);
            graphics.DrawImage(bitmap, new Point(0, 0));
        }

        public void SafeSetPixel(int x, int y, Color colour)
        {
            int index = x + y * Width;
            int col = colour.ToArgb();
            if (0 <= index && index < Bits.Length)
            {
                Bits[index] = col;
            }
        }
        public void SetPixel(int x, int y, Color colour)
        {
            int index = x + y * Width;
            int col = colour.ToArgb();
            Bits[index] = col;
        }

        public Color SafeGetPixel(int x, int y)
        {
            int index = x + y * Width;
            if (index < Bits.Length)
            {
                int col = Bits[index];
                Color result = Color.FromArgb(col);
                return result;
            }
            return Color.Black;
        }
        public Color GetPixel(int x, int y)
        {
            int index = x + y * Width;
            int col = Bits[index];
            Color result = Color.FromArgb(col);
            return result;
        }

        public void Dispose()
        {
            if (Disposed) return;
            Disposed = true;
            Bitmap.Dispose();
            BitsHandle.Free();
        }
    }
}
