using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderVal : MonoBehaviour
{

    public GameObject goScript;
    public Slider slider;

    public int i;
    public float val;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i = goScript.GetComponent<transitionEchelle>().i;
        val = 1 / i;
        slider.value = val;
    }
}
