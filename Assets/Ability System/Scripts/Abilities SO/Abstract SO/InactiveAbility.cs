using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace William_Douglass
{
    public abstract class InactiveAbility : Ability
    {
        public string BuffType;
        public float Bonus;
        public abstract void ApplyAbility();
    }
}
