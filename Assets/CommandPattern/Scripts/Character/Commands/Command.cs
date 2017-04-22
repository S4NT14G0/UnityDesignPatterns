using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.Character.Commands
{
    public abstract class Command : MonoBehaviour
    {
        public abstract void Execute(ActorController actor);

    }
}


