using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DangerWall : MonoBehaviour
{
    void Start() { }
    public static class ApplicationUtils
    {
        public static void ReloadLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // オブジェクトと接触した時に呼ばれるコールバック
    void OnCollisionEnter(Collision hit)
    {
        // 接触したオブジェクトのタグが"Player"の場合
        if (hit.gameObject.CompareTag("Player"))
        {
            //ApplicationUtils.ReloadLevel();
            //上のやつは今のシーンをよみこみなおすだけ
            //下のやつは好きなシーンを読み込めるから、超便利
            SceneManager.LoadScene("GameOver");


            //// 現在のシーン番号を取得
            // int scenINdexにはscenemanagerクラスのGetActiveSceneのbuildIndexというある数値を取得

            //int sceneIndex = SceneManager.GetActiveScene().buildIndex;

            //上でとってきた、sceneIndexの数値をLoadSceneメソッドに代入すると最初のシーンになる
            //// 現在のシーンを再読込する
            //SceneManager.LoadScene(sceneIndex);
        }
    }
}