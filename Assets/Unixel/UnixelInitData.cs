using UnityEngine;

namespace Unixel
{
    public class UnixelInitData
    {
        public readonly int width;
        public readonly int height;
        public readonly Material material;

        public UnixelInitData(int width, int height, Material material)
        {
            this.width = width;
            this.height = height;
            this.material = material;
        }
    }
}
