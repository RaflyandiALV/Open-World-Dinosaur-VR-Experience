using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakeMeshExample : MonoBehaviour
{
    void Start()
    {
        foreach (SkinnedMeshRenderer skinnedMeshRenderer in GetComponentsInChildren<SkinnedMeshRenderer>())
        {
            Mesh bakedMesh = new Mesh();
            skinnedMeshRenderer.BakeMesh(bakedMesh);
            skinnedMeshRenderer.gameObject.AddComponent<MeshFilter>().mesh = bakedMesh;
            skinnedMeshRenderer.enabled = false; // Disable the skinned mesh renderer
        }
    }
}
