using UnityEngine;
using System.Collections;


public class Player : MonoBehaviour
{


    public float speed;
    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        Rigidbody rigitbody = GetComponent<Rigidbody>();
        rigitbody.AddForce(x * speed, 0, 0);
    }

    public void Speeddown()
    {
        speed -= 0.5f;
    }

}


