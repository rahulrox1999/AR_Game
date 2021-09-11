using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScaleAndRotate : MonoBehaviour
{

    private Slider RotateSlider;
    private Slider ScaleSlider;

    public float MinScaleValue;
    public float MaxScaleValue;

    public float MinRotateValue;
    public float MaxRotateValue;


    // Start is called before the first frame update
    void Start()
    {
        ScaleSlider = GameObject.Find("scaleSlider").GetComponent<Slider>();
        ScaleSlider.minValue = MinScaleValue;
        ScaleSlider.maxValue = MaxScaleValue;

        ScaleSlider.onValueChanged.AddListener(ScaleSliderUpdate);


        RotateSlider = GameObject.Find("rotateSlider").GetComponent<Slider>();
        RotateSlider.minValue = MinRotateValue;
        RotateSlider.maxValue = MaxRotateValue;


        RotateSlider.onValueChanged.AddListener(RotateSliderUpdate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ScaleSliderUpdate(float value)
    {
        transform.localScale = new Vector3(value, value, value);
    }

    public void RotateSliderUpdate(float value)
    {
        transform.localEulerAngles = new Vector3(transform.rotation.x, value, transform.rotation.z);
    }
}
