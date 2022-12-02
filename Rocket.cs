using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] private float turnPower = 1;
    [SerializeField] private float boostPower = 2;

    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        bool boost = Input.GetButton("Jump");
        if (h>0)
        {

            rigidbody.AddForce(turnPower * Vector3.right, ForceMode.Force);//new Vector3(transform.position.x+(h*turnPower),0);
            rigidbody.transform.Rotate(Vector3.forward * turnPower);
        }
        if (h < 0)
        {
            rigidbody.AddForce(turnPower * Vector3.left, ForceMode.Force);//new Vector3(transform.position.x+(h*turnPower),0);
            rigidbody.transform.Rotate(Vector3.back * turnPower);
        }
        if (boost)
        {
            rigidbody.AddForce(boostPower*Vector3.up,ForceMode.Force);//new Vector3(0, transform.position.y + (boostPower));
            
        }
    }
}
