using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillVolume : MonoBehaviour
{
       private void OnTriggerEnter(Collider other)
    {
        //other.gameObject.SetActive(false);
        PlayerController playerController = other.GetComponent<PlayerController>();
        if(playerController != null)
        {
            playerController.Die();
        }
    }

}
