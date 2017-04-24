using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommandPattern.InputHandling;
using CommandPattern.Character.Commands;

namespace CommandPattern.Character
{
    public class ActorController : MonoBehaviour
    {

        InputHandler ih;

        public float speed = 5.0f;
        public float jumpSpeed = 8.0f;
        public float gravity = 20.0f;
        public bool grounded = false;

        public CharacterController CharController {get; set;}
        public Vector3 MovementDirection;


        // Use this for initialization
        void Start()
        {
            CharController = this.GetComponent<CharacterController>();
            MovementDirection = Vector3.zero;

            ih = GameObject.Find("Input Handler").GetComponent<InputHandler>();
            ih.LeftClick = GameObject.Find("Input Handler").GetComponent<JumpCommand>();

        }

        // Update is called once per frame
        void FixedUpdate()
        {

            Vector3 down = Vector3.down;

            RaycastHit hit;

            if (Physics.Raycast(transform.position, down, out hit))
            {
                float distance = Vector3.Distance(this.transform.position, hit.point);
                Debug.DrawRay(transform.position, down * distance, Color.green);
            }


            Command command = ih.HandleInput();

            if (command)
            {
                command.Execute(this);
            }

            MovementDirection.y -= gravity * Time.deltaTime;

            CharController.Move(MovementDirection * Time.deltaTime);
            grounded = CharController.isGrounded;
        }
    }
}

