﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaceManager : MonoBehaviour
{
    public static FaceManager Singleton;

    [HideInInspector]
    public FaceBehaviour currentFaceBehaviour;
    public Text MyDebugText;

    public float MouthOpenValue;

    void OnEnable()
    {
        Singleton = this;
    }

    public void SetDefaultFaceVertices()
    {
        if(currentFaceBehaviour != null)
        {
            currentFaceBehaviour.SetDefaultFaceVertices();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}