using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class FaceBehaviour : MonoBehaviour
{
    MeshFilter myMeshFilter;

    

    Vector3[] defaultFaceVertices;
    Vector3[] mouthOpenFaceVertices;


    private void OnEnable()
    {
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
        defaultFaceVertices = myMeshFilter.mesh.vertices;
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

            if(defaultFaceVertices.Length > 0) 
            {
                FaceManager.Singleton.MouthOpenValue = Mathf.Clamp01(Vector3.Distance(defaultFaceVertices[17], myMeshFilter.mesh.vertices[17]) / 0.016f);
            }


            //if (defaultFaceVertices.Length > 0 && mouthOpenFaceVertices.Length > 0)
            //{
            //    float maxMovement = 0;
            //    int currentMaxMovedVertex = 0;
            //    for (int i = 0; i < defaultFaceVertices.Length; i++)
            //    {
            //        float currentVertexMovement = Vector3.Distance(defaultFaceVertices[i], mouthOpenFaceVertices[i]);
            //        if (currentVertexMovement > maxMovement)
            //        {
            //            currentMaxMovedVertex = i;
            //            maxMovement = currentVertexMovement;
            //        }
            //    }

            //    FaceManager.Singleton.MyDebugText.text = currentMaxMovedVertex.ToString() + " " + maxMovement.ToString();
            //}
        }
    }
}
