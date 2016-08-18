using UnityEngine;
using System.Collections;

public class Scale : MonoBehaviour
{

	void Update () {
        //物体のスケール拡大縮小
        if (Input.GetButtonDown("Fire1"))
        {
            transform.localScale += new Vector3(0.3f, 0.3f, 0.3f);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            transform.localScale += new Vector3(-0.3f, -0.3f, -0.3f);
        }
        //押している間スローモーションとハイスピード
        //PS3版
        if (Input.GetButton("Fire3"))
        {
            Time.timeScale = 0.5F;
        }
        else if (Input.GetButtonUp("Fire3"))
            Time.timeScale = 1.2F;

        //押しているハイだ半重力発生
        {
            if (Input.GetButton("Gravity"))
            {
                Physics.gravity = new Vector3(0, 4.4f, 0);
            }
            else if (Input.GetButtonUp("Gravity"))
            {
                Physics.gravity = new Vector3(0, -9.8f, 0);
            }
        }
    }
}
