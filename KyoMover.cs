using UnityEngine;
using System.Collections;

public class KyoMover : MonoBehaviour {


	
    float t = 0;
    public float x = 0, y = 0, z = 0;
    public float speed = 0;

    void Update()
    {
        t += Time.deltaTime * 2;
        this.transform.position = new Vector3(x, (-Mathf.Cos(t) + y) * speed, z);
    }

}
