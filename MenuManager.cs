using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string nomeDoLevel;
    [SerializeField] private GameObject painelMenu;
    [SerializeField] private GameObject painelOp;
    [SerializeField] private AudioSource mybuttonsound;
  
    public void Jogar(){
        SceneManager.LoadScene(nomeDoLevel);
    }
    public void Abrirop(){
        mybuttonsound.Play();
        painelMenu.SetActive(false);
        painelOp.SetActive(true);
        
    }
    public void Fecharop()
    {
        
        painelOp.SetActive(false);
        painelMenu.SetActive(true);
        
    }
    public void Fecharjog(){
        Application.Quit();
        Debug.Log("sai");
    }

  

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
