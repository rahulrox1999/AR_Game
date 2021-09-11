using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;

[RequireComponent(typeof(ARRaycastManager))]
public class TapToPlace : MonoBehaviour



{
    public GameObject ObjectCar;
    public GameObject PlaceButton;



    private GameObject spwanObject;
    private ARRaycastManager aRRaycastManager;
    private Vector2 touchPosition;


    static List<ARRaycastHit> hits = new List<ARRaycastHit>();


    // Start is called before the first frame update
    private void Awake()
    {
        aRRaycastManager = GetComponent<ARRaycastManager>();
        // Panel.SetActive(false);
    }

    bool TryGetTouchPosition(out Vector2 touchPosition)

    {
        if (Input.touchCount > 1)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;

        }

        touchPosition = default;
        return false;

    }
    // Update is called once per frame
    void Update()
    {


    }

    public void SpawnButton()
    {
        if (TryGetTouchPosition(out Vector2 touchPosition))
        {
            if (aRRaycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
            {

                var hitPose = hits[0].pose;

                if (spwanObject == null)
                {
                    spwanObject = Instantiate(ObjectCar, hitPose.position, hitPose.rotation);
                    //Panel.SetActive(true);
                    Destroy(PlaceButton, .2f);
                }

                else
                {
                    spwanObject.transform.position = hitPose.position;
                }
            }
        }
    }

 
}

