using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class FaceBehaviour : MonoBehaviour
{
    MeshFilter myMeshFilter;

    Vector3[] defautFaceVertices;
    Vector3[] mouthOpenFaceVertices;

    private void OnEnable()
    {
        FaceManager.Singleton.SetDefaultFaceVertices();
        FaceManager.Singleton.currentFaceBehaviour = this;
    }

    private void OnDisable()
    {
        FaceManager.Singleton.currentFaceBehaviour = null;
    }

    // Start is called before the first frame update
    void Start()
    {
        myMeshFilter = GetComponent<MeshFilter>();
    }

    public void SetDefaultFaceVertices()
    {
        defautFaceVertices = myMeshFilter.mesh.vertices;
    }

    //public void SetOpenMouthFaceVertices()
    //{
    //    mouthOpenFaceVertices = myMeshFilter.mesh.vertices;
    //}
    // Update is called once per frame
    void Update()
    {
        if(myMeshFilter.mesh != null)
        {
            if(defautFaceVertices.Length > 0)
            {
                Bird.Singleton.MouthOpenValue = Mathf.Clamp01(Vector3.Distance(defautFaceVertices[17], myMeshFilter.mesh.vertices[17]) / 0.016f);
            }
        }
    }
}
