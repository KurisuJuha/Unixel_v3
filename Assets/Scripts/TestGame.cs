using UnityEngine;
using Unixel;

namespace JuhaKurisu
{
    public class TestGame : UnixelEngine
    {
        public Material material;

        protected override void Init()
        {

        }

        protected override void Draw()
        {
            Debug.Log("draw");
        }

        protected override UnixelInitData UnixelInit()
        {
            return new UnixelInitData(128, 128, material);
        }
    }
}
