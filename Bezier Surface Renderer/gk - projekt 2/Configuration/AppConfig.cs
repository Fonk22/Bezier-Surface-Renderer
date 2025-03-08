namespace gk___projekt_2.Configuration
{
    internal static class AppConfig
    {
        public static readonly int WindowWidth = 2160;
        public static readonly int WindowHeight = 1215;

        public static int CanvasWidth;
        public static int CanvasHeight;

        public static readonly string ControlPointsFile = "ControlPointsSamples/controlpoints2.txt";
        public static readonly string NormalMapsDirectory = "NormalMaps";
        public static readonly string TextureFilesDirectory = "Textures";

        public static readonly string DefaultTextureFile = "Textures/texture3.jpg";
        public static readonly string DefaultNormalMapFile = "NormalMaps/NormalMap(4).png";
    }
}
