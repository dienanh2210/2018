using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu : MonoBehaviour {

    // Use this for initialization
    public GameObject tutori1;
   

    void Start() {
        Screen.orientation = ScreenOrientation.Portrait;
          // panel.GetComponent<Page>().enabled = false;
        if (PlayerPrefs.GetInt("hasPlayed", 0) == 1)
        {
            hasPlayed();
        }
        else
        {
            //Set hasPlayed to true
            PlayerPrefs.SetInt("hasPlayed", 1);
            PlayerPrefs.Save();

            notPlayed();
        }


    }


    void hasPlayed()
    {
        Debug.Log("Has Played");
        //Don't do anything
        SceneManager.LoadScene("Splash");
        tutori1.SetActive(false);
    }

    void notPlayed()
    {
        Debug.Log("Not Played");
        tutori1.SetActive(true);
        //Play your tutorial
    }

    public void tutorial1()
    {
         tutori1.SetActive(false);
        SceneManager.LoadScene("Splash");
        // panel.SetActive(true);
        // panel.GetComponent<Page>().enabled=true;

    }
}
