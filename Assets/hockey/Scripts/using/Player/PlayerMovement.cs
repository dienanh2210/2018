﻿using UnityEngine;
namespace Com.MyCompany.MyGame
{
    public class PlayerMovement : MonoBehaviour
    {

        Rigidbody2D rb;
        Vector2 startingPosition;

        public Transform BoundaryHolder;

        Boundary playerBoundary;

        public Collider2D PlayerCollider { get; private set; }

        public PlayerController Controller;

        public int? LockedFingerID { get; set; }
        public float scale;
        public float distanceTouch;
       
        // Use this for initialization
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            startingPosition = rb.position;
            PlayerCollider = GetComponent<Collider2D>();

            playerBoundary = new Boundary(BoundaryHolder.GetChild(0).position.y,
                                          BoundaryHolder.GetChild(1).position.y,
                                          BoundaryHolder.GetChild(2).position.x,
                                          BoundaryHolder.GetChild(3).position.x);

        }
        
        private void OnEnable()
        {
            Controller.Players.Add(this);
        }
        private void OnDisable()
        {
            Controller.Players.Remove(this);
        }

        public void MoveToPosition(Vector2 position)
        {


            Vector2 clampedMousePos = new Vector2(Mathf.Clamp(position.x, playerBoundary.Left,
                                                       playerBoundary.Right),
                                           Mathf.Clamp(position.y + distanceTouch, playerBoundary.Down,
                                                       playerBoundary.Up));
            rb.MovePosition(clampedMousePos);

        }
        public void ResetPosition()
        {
            rb.position = startingPosition;
        }
    }
}