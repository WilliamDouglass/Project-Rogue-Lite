using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace William_Douglass
{
    public class AbilityHolder : MonoBehaviour
    {
        public Ability ability;
        float cooldownTime;
        float activeTime;

        enum AbilityState
        {
            ready,
            active,
            cooldown
        }

        // AbilityState state = AbilityState.ready;

        #region Input


        #endregion
        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
