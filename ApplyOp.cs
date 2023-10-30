using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ApplyOp : MonoBehaviour
{
    public Slider slid;

    public AudioSource menuost;

    public AudioSource buttonsound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        menuost.volume = slid.value;
        buttonsound.volume = slid.value;
    }
}
