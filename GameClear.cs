using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
 void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Title");
        }
    }
    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 128, 32), "ゲームクリア");
    }
}