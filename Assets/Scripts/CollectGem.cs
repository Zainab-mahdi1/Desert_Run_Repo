using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGem : MonoBehaviour
{
    [SerializeField] AudioSource gemFx;
    

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            gemFx.Play();
            MasterInfo.gemCount += 1;
            gameObject.SetActive(false);
        }
    }
}

