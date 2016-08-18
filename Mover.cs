using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour 
{
    public float speed;
    public float x,y,z;

    void Update()
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        //①forward方向に等速で移動
        //GetComponent<Rigidbody>().velocity= transform.forward * speed;

        ////②相対的に力を加えて、あとで等速になる
        //Rigidbody rigidbody = GetComponent<Rigidbody>();
        ////rigidbodyのｚ軸に力を加える
        //rigidbody.AddRelativeForce(x, y, z * speed * Time.deltaTime);

        ////③完全に任意の方向に等速で移動できる
        transform.position += new Vector3(0f, 0f, z*speed* Time.deltaTime);
        rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY;

    }
}
