using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderVal : MonoBehaviour
{

    public GameObject goScript;
    public Slider slider;

    public int i;
    public double val;
    // Start is called before the first frame update
    void Start()
    {
        slider = GameObject.FindObjectOfType<Slider>();
        //Debug.Log(slider.name);
    }

    // Update is called once per frame
    void Update()
    {
        i = goScript.GetComponent<transitionEchelle>().i;
        val = 0.1 * i;
        slider.value = (float)val;
    }
}
