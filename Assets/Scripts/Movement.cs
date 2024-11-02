using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal");
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical");
        transform.Translate(xValue, yValue, zValue);
    }
}
