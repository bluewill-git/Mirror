using UnityEngine;
using Mirror;
using System.Collections.Generic;

namespace WeaverSyncVarTests.SyncVarsCantBeArray
{
    class SyncVarsCantBeArray : NetworkBehaviour
    {
        [SyncVar]
        int health;

        [SyncVar]
        int[] thisShouldntWork = new int[100];

        public void TakeDamage(int amount)
        {
            if (!isServer)
                return;

            health -= amount;
        }
    }
}
