using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Microsoft.Azure.SpatialAnchors.Unity.Examples;

public class SliderScaler : MonoBehaviour
{
    public GameObject obj;
    public DemoScriptBase demoscript;
    public Slider slider;

    // Update is called once per frame
    void Start(){
        obj = demoscript.getSpawnedObject();
    }

    void Update(){
        obj.transform.localScale = new Vector3(slider.value, slider.value, slider.value);
        demoscript.setSpawnedObject(obj);
    }
}
