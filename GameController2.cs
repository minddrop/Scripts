using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController2 : MonoBehaviour
{
    public static class ApplicationUtils
    {
        public static void ReloadLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    // Update is called once per frame
    public UnityEngine.UI.Text scoreLabel;
    public GameObject winnerLabelObject;
    public UnityEngine.UI.Text timer;
    public GameObject SlowObject;

    public void Update()
    {
        //残りスコアを数えてる
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreLabel.text = count.ToString();

        //スコアが零になったらおめでとうを表示させる
        if (count == 0)
        {
            winnerLabelObject.SetActive(true);
        }

        //再生してからの時間を取得
        float check_time = Time.timeSinceLevelLoad;
        //取得したfloat型を文字列型に変えて、テキストのa枠に入れられるように
        //クラス直下のpublic UnityEngine.UI.Text a;で枠を生成できる
        timer.text = check_time.ToString();

        //rを押したら、ゲームリセット、便利かと        
        //PS3コントローラーで設定したやつ
        if (Input.GetKeyDown("r") || Input.GetButtonDown("Reset"))
        {
            ApplicationUtils.ReloadLevel();
        }
        //qを押したら、ステージセレクトへ
        if (Input.GetKeyDown("q"))
        {
            SceneManager.LoadScene("StageSelect ver2");
        }

        //押している間スローモーションとハイスピード
        if (Input.GetKey("e"))
        {
            Time.timeScale = 0.5F;
        }
        else if (Input.GetKeyUp("e"))
            Time.timeScale = 1.2F;

        if (Input.GetKey("w"))
        {
            Time.timeScale = 2.5F;
        }
        else if (Input.GetKeyUp("w"))
            Time.timeScale = 1.2F;


        //スローモーションの証が出てくる
        //クラス直下のpublic GameObjectとセットで記述
        if (Input.GetKey("e") || Input.GetButtonDown("Fire3"))
        {
            //Debug.Log()のような間隔で使えるのか
            SlowObject.SetActive(true);
        }
        else if (Input.GetKeyUp("e") || Input.GetButtonUp("Fire3"))
            SlowObject.SetActive(false);

    }
}

