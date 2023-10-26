using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

namespace William_Douglass
{
    public class Ability : ScriptableObject
    {
        public new string name;
        public float cooldownTime;
        public float activeTime;

        public virtual void Activate(){}
    }   
}
