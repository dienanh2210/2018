using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Page : MonoBehaviour
{
   
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        
    }

    // Update is called once per frame
    void Update()
    {

        Invoke("nextMenu", 3f);

    }
    void nextMenu()
    {
           SceneManager.LoadScene("Menu");
       
    }
   


}
