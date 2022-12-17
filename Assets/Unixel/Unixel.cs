using System.Collections.Generic;
using UnityEngine;

namespace Unixel
{
    public abstract class UnixelEngine : MonoBehaviour
    {
        private UnixelInitData unixelInitData;
        private Mesh mesh;

        private void Start()
        {
            Debug.Log("baseStart");
            unixelInitData = UnixelInit();
            mesh = new Mesh();
            Init();
        }

        private void Update()
        {
            MeshGenerate();
            Graphics.DrawMesh(mesh, Vector3.zero, Quaternion.identity, unixelInitData.material, 0);
        }

        private void MeshGenerate()
        {
            float height = unixelInitData.height / (float)unixelInitData.width;
            float width = 1;

            float m = width / height > Camera.main.aspect ? Camera.main.orthographicSize * Camera.main.aspect : Camera.main.orthographicSize / height;

            width *= m;
            height *= m;

            mesh.Clear();
            mesh.SetVertices(new Vector3[]
            {
                new Vector3(-width,-height),
                new Vector3(-width,height),
                new Vector3(width,height),
                new Vector3(width,-height),
            });
            mesh.SetTriangles(new int[]
            {
                0,1,2,
                0,2,3,
            }, 0);
            mesh.SetUVs(0, new List<Vector2>()
            {
                new Vector2(0,0),
                new Vector2(0,1),
                new Vector2(1,1),
                new Vector2(1,0),
            });
        }

        virtual protected void Init() { }

        virtual protected void Draw() { }

        protected abstract UnixelInitData UnixelInit();
    }
}