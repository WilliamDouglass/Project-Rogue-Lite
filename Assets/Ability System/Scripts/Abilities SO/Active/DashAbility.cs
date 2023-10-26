using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace William_Douglass
{
    [CreateAssetMenu]
    public class DashAbility : ActiveAbility
    {
        public float dashForce;
        public override void ActivateAbility(GameObject obj)
        {
            PlayerMovementScript movementScript = obj.GetComponent<PlayerMovementScript>();

            
        }
    }
}
