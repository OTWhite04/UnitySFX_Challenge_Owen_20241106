using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript1 : MonoBehaviour
{
    public AudioSource AudioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.Pause();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.Unpause();
        }
    }





}
