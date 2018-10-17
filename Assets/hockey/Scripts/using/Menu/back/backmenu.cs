using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Com.MyCompany.MyGame
{
    public class backmenu : MonoBehaviour
    {
        public MenuManager menu;
        // Use this for initialization
        void Start()
        {
          
           
        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetKey("escape"))
            {

                Invoke("setback", 0.5f);

            }

        }
        void setback()
        {
            menu.Back();
        }
    }
}
