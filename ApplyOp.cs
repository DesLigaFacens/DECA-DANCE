using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ApplyOp : MonoBehaviour
{
    public Slider slid;

    public AudioSource menuost;

    public AudioSource buttonsound;
    // Start is called before the first frame update

    public void applicarOp()
    {
        menuost.volume = slid.value;
        buttonsound.volume = slid.value;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(slid.value);
    }
}
