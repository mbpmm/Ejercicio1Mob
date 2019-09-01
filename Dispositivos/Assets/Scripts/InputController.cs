using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Mover();
        if (Input.GetButtonDown("Saltar")&& rb.velocity.y==0)
        {
            Saltar();
        }
    }

    private void Mover()
    {
        float x = Input.GetAxis("MovX");
        float y = Input.GetAxis("MovY");

        //transform.position += (Vector3.forward * y + Vector3.right * x)*Time.deltaTime*20;

        rb.AddForce((Vector3.forward * y + Vector3.right * x) * Time.deltaTime * 500);
    }

    private void Saltar()
    {
        rb.AddForce(new Vector3(0, 250, 0));
    }


}
