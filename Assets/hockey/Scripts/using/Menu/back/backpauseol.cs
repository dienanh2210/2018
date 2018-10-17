using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Com.MyCompany.MyGame
{
    public class backpauseol : MonoBehaviour
    {

        public Pause pausee;
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
            pausee.pause1.SetActive(false);
            pausee.pausepause.SetActive(false);
            pausee.pausepauseol.SetActive(true);
            // pause.SetActive(false);
            //  setpause.SetActive(true);
            // game.pause.SetActive(true);
            // game.pauseol.SetActive(true);

        }
    }
}
