using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DrawMeshInstancedExample : MonoBehaviour
{
    public Mesh mesh;
    public Material material;
    public int instanceCount = 10;

    void Update()
    {
        Matrix4x4[] matrices = new Matrix4x4[instanceCount];
        for (int i = 0; i < instanceCount; i++)
        {
            matrices[i] = Matrix4x4.TRS(
                new Vector3(i * 2.0f, 0, 0),
                Quaternion.identity,
                Vector3.one
            );
        }

        foreach (Transform child in transform)
        {
            Graphics.DrawMeshInstanced(mesh, 0, material, matrices);
        }
    }
}
