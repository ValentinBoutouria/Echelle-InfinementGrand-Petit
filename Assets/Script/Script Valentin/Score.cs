using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int _score;
    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score : " + _score;
        
    }
}
