using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDropper : MonoBehaviour
{
    [SerializeField] GameObject dropper1;
    [SerializeField] GameObject dropper2;
    [SerializeField] GameObject dropper3;
    [SerializeField] GameObject dropper4;
    [SerializeField] GameObject dropper5;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            dropper1.SetActive(true);
            dropper2.SetActive(true);
            dropper3.SetActive(true);
            dropper4.SetActive(true);
            dropper5.SetActive(true);
        }
    }
}