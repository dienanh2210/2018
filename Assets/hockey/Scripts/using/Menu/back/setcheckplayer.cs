﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Com.MyCompany.MyGame
{
    public class setcheckplayer : MonoBehaviour
    {

        public GameControler game;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
           
            game.checkall = false;
        }
    }
}
