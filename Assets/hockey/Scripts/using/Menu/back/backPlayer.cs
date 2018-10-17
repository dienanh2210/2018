using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Com.MyCompany.MyGame
{
    public class backPlayer : MonoBehaviour
    {
        
        public GameControler game;
        public MenuManager menu;
        public AudioClip audio;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            
                if (Input.GetKey("escape"))
                {

               
                Invoke("setback", 0.1f);


            }
        }
        public void setback()
        {
            GetComponent<AudioSource>().PlayOneShot(audio);
            game.pause.SetActive(true);
            menu.paus.SetActive(true);
          //  pause.SetActive(true);
           // setpause.SetActive(false);


        }
    }
}