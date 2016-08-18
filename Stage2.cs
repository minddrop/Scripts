using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Stage2 : MonoBehaviour {

    void OnCollisionEnter(Collision hit)
    {
        // 接触したオブジェクトのタグが"Player"の場合
        if (hit.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Mario2 Stage2");
        }
    }
}
