using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommandPattern.Character.Commands;

namespace CommandPattern.InputHandling
{
    public class InputHandler : MonoBehaviour
    {
        public Command LeftClick { get; set; }

        public Command HandleInput ()
        {
            if (Input.GetMouseButton(0))
            {
                return LeftClick;
            }

            return null;
        }
    }
}