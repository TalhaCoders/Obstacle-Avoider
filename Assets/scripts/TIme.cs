using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIme : MonoBehaviour
{
    [SerializeField] private float Time_to_wait;

    Rigidbody rb;
    MeshRenderer mesh;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        mesh = GetComponent<MeshRenderer>();

        rb.useGravity = false;
        mesh.enabled = false;
    }

    private void Update()
    {
        if(Time.time > Time_to_wait)
        {
            rb.useGravity = true;
            mesh.enabled = true;
        }
    }
}
