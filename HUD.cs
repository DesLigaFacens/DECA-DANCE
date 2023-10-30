using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField] private GameObject menuHUD;
    public bool menuactive = false;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            menuactive = !menuactive;
            menuHUD.SetActive(menuactive);
            
        }
        else if(menuactive == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
