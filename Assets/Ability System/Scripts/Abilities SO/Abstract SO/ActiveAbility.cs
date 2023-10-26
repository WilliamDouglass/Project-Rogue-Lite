using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace William_Douglass
{
    public abstract class ActiveAbility : Ability
    {
        public float cooldownTime;
        public float activeTime;
        public abstract void ActivateAbility(GameObject obj);
    }
}
