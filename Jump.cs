using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{
    //ジャンプ台
    public float Ypower = 10;
    public float Xpower = 10;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody rigid = collision.gameObject.GetComponent<Rigidbody>();
            rigid.AddForce(0, this.Ypower, this.Xpower);
        }
    }
}
