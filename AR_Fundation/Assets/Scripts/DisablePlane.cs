using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


[RequireComponent(typeof(ARPlaneManager))]
public class DisablePlane : MonoBehaviour
{
    private ARPlaneManager planeManager;




    private void Awake()
    {

        planeManager = GetComponent<ARPlaneManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TogglePlane()
    {
        planeManager.enabled = !planeManager.enabled;

        if(planeManager.enabled)
        {
            SetAllPlane(true);
        }
        else
        {
            SetAllPlane(false);
        }
    }

    private void SetAllPlane(bool value)
    {
        foreach(var  plane  in planeManager.trackables)
        {
            plane.gameObject.SetActive(value);
        }
    }

}
