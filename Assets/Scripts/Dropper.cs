using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer dropperMeshRender;
    Rigidbody dropperRigidBody;

    private void Awake() 
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        dropperMeshRender = GetComponent<MeshRenderer>();
        dropperRigidBody = GetComponent<Rigidbody>();
        dropperMeshRender.enabled = false;
        dropperRigidBody.useGravity = false;
    }
    void Update()
    {
            dropperMeshRender.enabled = true;
            dropperRigidBody.useGravity = true;
    }
}
