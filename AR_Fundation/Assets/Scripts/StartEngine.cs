using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartEngine : MonoBehaviour
{

    //This implies a delay of 2 seconds.

   
    public GameObject Car;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Destroy(gameObject, 0.01f);
    }

    public void AllEnable()
    {
        Car.SetActive(true);

        Destroy(this.gameObject, 0.5f);
    
       
    }
    
}
