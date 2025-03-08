using gk___projekt_2.FastGraphics;

namespace gk___projekt_2
{
    internal class Texture
    {
        private DirectBitmap TextureImage;
        private DirectBitmap? NormalMap;
        public Texture(Color TextureColor, string? NormalMapPath = null)
        {
            TextureImage = new DirectBitmap(16, 16);
            ChangeTextureColor(TextureColor);
            if(NormalMapPath is not null)
            {
                ChangeNormalMap(NormalMapPath);
            }
        }
        public Texture(string TextureImagePath, string? NormalMapPath = null)
        {
            TextureImage = new DirectBitmap(16, 16);
            ChangeTextureImage(TextureImagePath);
            if(NormalMapPath is not null)
            {
                ChangeNormalMap(NormalMapPath);
            }
        }
        public void ChangeTextureColor(Color TextureColor)
        {
            TextureImage.Dispose();
            TextureImage = new DirectBitmap(1, 1);
            using Graphics graphics = Graphics.FromImage(TextureImage.Bitmap);
            graphics.Clear(TextureColor);
        }
        public void ChangeTextureImage(string TextureImagePath)
        {
            TextureImage.Dispose();
            Bitmap bitmap = new Bitmap(TextureImagePath);
            TextureImage = new DirectBitmap(bitmap);
        }
        public void ChangeNormalMap(string NormalMapPath)
        {
            NormalMap?.Dispose();
            Bitmap normalMap = new Bitmap(NormalMapPath);
            NormalMap = new DirectBitmap(normalMap);
        }
        public void RemoveNormalMap()
        {
            NormalMap = null;
        }
        public Color GetTextureColor(float u, float v)
        {
            int x = (int)(u * (TextureImage.Width - 1));
            int y = (int)(v * (TextureImage.Height - 1));
            x = Math.Clamp(x, 0, TextureImage.Width - 1);
            y = Math.Clamp(y, 0, TextureImage.Height - 1);
            return TextureImage.GetPixel(x, y);
        }
        public bool HasNormalMap() { return NormalMap is not null; }
        public Color GetNormalMapColor(float u, float v)
        {
            if(NormalMap == null) {  return Color.FromArgb(127,127,255); }
            int x = (int)(u * (NormalMap.Width - 1));
            int y = (int)(v * (NormalMap.Height - 1));
            x = Math.Clamp(x, 0, NormalMap.Width - 1);
            y = Math.Clamp(y, 0, NormalMap.Height - 1);
            return NormalMap.GetPixel(x, y);
        }
    }
}
