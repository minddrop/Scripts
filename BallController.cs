using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    //speedを制御する、speed変数を用意する
    public float speed;
    void FixedUpdate()
    {
        // 入力をｘとｚに代入
        //input.は型（クラス）また、薄緑は全部型

        float z = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");

        //同一のGameObjectがもつRigidbodyコンポーネントを取得
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        //rigidbodyのｘ軸とｚ軸に力を加える
        rigidbody.AddForce(z*speed, 0, x*speed);

        ////等速アニメーション
        //this.transform.position += new Vector3(1, 0, 0);
    }
}
