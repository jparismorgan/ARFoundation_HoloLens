using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class Main : MonoBehaviour
{
    protected Camera mainCamera;

    protected ARCameraManager arCameraManager = null;
    protected ARSession arSession = null;
    //internal static ARAnchorManager arAnchorManager = null;
    internal static ARReferencePointManager aRReferencePointManager = null;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        arCameraManager = FindObjectOfType<ARCameraManager>();
        arSession = FindObjectOfType<ARSession>();
        //  arAnchorManager = FindObjectOfType<ARAnchorManager>();
        aRReferencePointManager = FindObjectOfType<ARReferencePointManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
