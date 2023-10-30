using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Image teste;
    [SerializeField] private float heart = 50;
    [SerializeField] private float maxhealth = 50;
    public float lifechange;
    void Start()
    {
        //GetObjects();
        
    }

    // Update is called once per frame
    void Update()
    {
        lifechange = (heart / maxhealth) * 100;
        teste.fillAmount = lifechange/100;
    }
    
}
