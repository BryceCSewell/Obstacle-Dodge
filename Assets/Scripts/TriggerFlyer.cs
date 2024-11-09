using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFlyer : MonoBehaviour
{
    [SerializeField] GameObject flyer1;
    [SerializeField] GameObject flyer2;
    [SerializeField] GameObject flyer3;
    [SerializeField] GameObject flyer4;
    [SerializeField] GameObject flyer5;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            flyer1.SetActive(true);
            flyer2.SetActive(true);
            flyer3.SetActive(true);
            flyer4.SetActive(true);
            flyer5.SetActive(true);
        }
    }
}