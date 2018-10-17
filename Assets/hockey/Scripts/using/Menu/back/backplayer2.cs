using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Com.MyCompany.MyGame
{
    public class backplayer2 : MonoBehaviour
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
            game.pauseol.SetActive(true);
            menu.pausol.SetActive(true);
            //  pause.SetActive(true);
            // setpause.SetActive(false);


        }
    }
}

