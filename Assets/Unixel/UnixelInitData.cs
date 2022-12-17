using UnityEngine;

namespace Unixel
{
    public class UnixelInitData
    {
        public readonly int width;
        public readonly int height;
        public readonly int fps;
        public readonly Material material;

        public UnixelInitData(int width, int height, Material material, int fps = 30)
        {
            this.width = width;
            this.height = height;
            this.fps = fps;
            this.material = material;
        }
    }
}
