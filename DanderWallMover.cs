using UnityEngine;
using System.Collections;

public class DanderWallMover : MonoBehaviour
{
    //動く床
    float t1 = 0;
    public float yure1,yure2,yure3;

    void Update()
    {   
        //posで現在座標取得、yure変数でどっち方向に動かすか決める
        Vector3 pos = transform.position;
        t1 += Time.deltaTime * 2;
        this.transform.position = new Vector3(-Mathf.Cos(t1)*yure1 +pos.x, -Mathf.Cos(t1) * yure2 +pos.y , -Mathf.Cos(t1) * yure3 +pos.z);
    }
}
