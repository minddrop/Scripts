using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{

    void OnCollisionEnter(Collision hit)
    {
        // 接触したオブジェクトのタグが"Player"の場合
        if (hit.gameObject.CompareTag("Player"))
        {
            //ApplicationUtils.ReloadLevel();
            //上のやつは今のシーンをよみこみなおすだけ
            //下のやつは好きなシーンを読み込めるから、超便利
            SceneManager.LoadScene("GameClear");
        }
    }
}
