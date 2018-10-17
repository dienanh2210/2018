using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Com.MyCompany.MyGame
{
    public class Pause : MonoBehaviour {

        public GameObject pause;
        public GameObject pause1;
        public GameControler gam;
        public GameObject playerrestart;
        public GameObject Ai;
        public GameObject playerBlue;
        public GameObject maps;
        public AudioClip audio;
        public GameObject pausepause;
        public GameObject pausepauseol;

        private void Start()
        {
            
           // SG_AdManager.ads.RequestIntertitial();
            //SG_AdManager.ads.ShowIntertitial();
            //StartCoroutine(ShowBanner());
        }

      /*  private IEnumerator ShowBanner()
        {
            yield return new WaitForSeconds(2f);
            SG_AdManager.ads.ShowBanner();
        }*/
       
        public void Restart() {
            Time.timeScale = 1;
            pause.SetActive(false);
            GetComponent<AudioSource>().PlayOneShot(audio);
            pausepause.SetActive(true);
            pausepauseol.SetActive(false);
            
        }
        public void Restartol()
        {
            GetComponent<AudioSource>().PlayOneShot(audio);
            Time.timeScale = 1;
            pause1.SetActive(false);
            pausepause.SetActive(false);
            pausepauseol.SetActive(true);
        }
        public GameObject canvasmenu;
        public GameObject PlayerAI;
       
        public void Quited() {
            //  SceneManager.LoadScene("map1");
            GetComponent<AudioSource>().PlayOneShot(audio);
            playerrestart.GetComponent<Rigidbody2D>().transform.position = new Vector2(0, -3f);
            Ai.GetComponent<Rigidbody2D>().transform.position = new Vector2(0, 4f);
            playerBlue.GetComponent<Rigidbody2D>().transform.position = new Vector2(0, 4f);
            canvasmenu.SetActive(true);
            pause.SetActive(false);
            PlayerAI.SetActive(false);
            maps.SetActive(false);
          
        }
      
        public void quitphoton() {

            //  SceneManager.LoadScene("Menu");
            
        }
        public GameObject panelLoading;
        public GameObject section2;
        public ActivarModelos acti;
       
        public MenuManager MenuManager;
        public void nextOnline()
        {
            GetComponent<AudioSource>().PlayOneShot(audio);

            panelLoading.SetActive(true);
            acti.ContadorTiempo = 0;
            section2.SetActive(false);
             Invoke("Online", 4f);
            
        }
       void Online()
        {           
            panelLoading.SetActive(false);
            
            MenuManager.PlayGame0();
        }

    }
}
