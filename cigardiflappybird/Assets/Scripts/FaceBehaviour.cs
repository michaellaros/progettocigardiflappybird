using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class FaceBehaviour : MonoBehaviour
{
    MeshFilter myMeshFilter;
    // Start is called before the first frame update
    void Start()
    {
        myMeshFilter = GetComponent<MeshFilter>();
    }

    // Update is called once per frame
    void Update()
    {
        if(myMeshFilter.mesh != null)
        {
            print(myMeshFilter.mesh.vertexCount);
        }
    }
}
