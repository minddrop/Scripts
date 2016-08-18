using UnityEngine;
using System.Collections;

public class ControllerItem1 : MonoBehaviour
{    
    //動く床のスクリプト
    //sinとかの三角関数の波を利用して、あの動きができている
    float t = 0;
    public float x = 0, y = 0, z = 0;

    void Update()
    {
        t += Time.deltaTime * 2;
        this.transform.position = new Vector3(x, -Mathf.Cos(t)+y , z);
    }
}
