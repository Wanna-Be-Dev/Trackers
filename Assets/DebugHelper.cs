using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using Valve.VR;

namespace Valve.VR
{
    public class DebugHelper : MonoBehaviour
    {
        public GameObject prefab;

        private GameObject spawnpoint;
        private void Start()
        {

            if (gameObject.GetComponent<NetworkObject>().IsLocalPlayer && !NetworkManager.Singleton.IsHost)
            {
                prefab.SetActive(false);
            }
        }

        public void Update()
        {
            spawnpoint = GameObject.FindGameObjectWithTag("Player");

            if (spawnpoint != null)
            {
                gameObject.transform.position = spawnpoint.transform.position;
                /*SteamVR_TrackedObject Child =  */
                gameObject.GetComponent<SteamVR_TrackedObject>().origin = spawnpoint.transform;
            }


        }
    }
}
