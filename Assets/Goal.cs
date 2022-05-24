using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText;
    public GameObject nextButtom;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ÉSÅ[Éã!");

        clearText.SetActive(true);
        nextButtom.SetActive(true);
        audioSource.Play();
    }
}
