using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Com.MyCompany.MyGame
{

    public class clockTT : MonoBehaviour {

        public GameObject tutoplayer;
        public GameObject playerRed;
        public GameObject clickoff;
        public GameControler game;
        public GameObject Puck;
        public GameObject Ai;
       
        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }
        public void setTT() {
            clickoff.SetActive(false);
            tutoplayer.SetActive(false);
            playerRed.SetActive(true);
            game.ResetScores();
            Puck.GetComponent<Rigidbody2D>().transform.position = new Vector2(0, -0.7f);
            Ai.GetComponent<Rigidbody2D>().transform.position = new Vector2(0, 4f);
           

        }

        public void setRest()
        {
            Puck.GetComponent<Rigidbody2D>().transform.position = new Vector2(0, 1.9f);
            tutoplayer.GetComponent<Rigidbody2D>().transform.position = new Vector2(0, -3f);
           // Ai.GetComponent<Rigidbody2D>().transform.position = new Vector2(0, 4f);
            
        }
        

    }
}
