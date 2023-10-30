using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//pegar o dropdown TMP
using TMPro;
using Unity.VisualScripting;

public class ScreenResolution : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private TMP_Dropdown resolutionDropdown;

    public void SetScreenFull()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    public void ChangeScreen()
    {
        if (Screen.fullScreen == false)
        {
            if (resolutionDropdown.value == 0)
            {
                Screen.SetResolution(1920, 1080, false);
            }
            else if (resolutionDropdown.value == 1)
            {
                Screen.SetResolution(1280, 720, false);
            }
            else if (resolutionDropdown.value == 2)
            {
                Screen.SetResolution(854, 480, false);
            }
        }
        else
        {
            if (resolutionDropdown.value == 0)
            {
                Screen.SetResolution(1920, 1080, true);
            }
            else if (resolutionDropdown.value == 1)
            {
                Screen.SetResolution(1280, 720, true);
            }
            else if (resolutionDropdown.value == 2)
            {
                Screen.SetResolution(854, 480, true);
            }
        }
    }

    void Start()
    {
       
    }
    
    // Update is called once per frame
    void Update()
    {
    }
}
