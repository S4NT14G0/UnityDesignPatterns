using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace CommandPattern.Character.Commands
{
    class JumpCommand : Command
    {
        public override void Execute(ActorController actor)
        {

            if (actor.CharController.isGrounded)
            {
                actor.MovementDirection.y = actor.jumpSpeed;
            }
        }
    }
}
