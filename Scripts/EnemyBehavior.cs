using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

    private float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right*speed*Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            other.transform.position = new Vector3(-12.3f, 0.82f, -8.88f);
            other.transform.rotation = new Quaternion(0, 180f,0,0);
        }
        else if(other.gameObject.tag=="Obstacle")
        {
            speed *= -1;
        }
    }
}
