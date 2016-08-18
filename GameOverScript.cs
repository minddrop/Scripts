using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {


	void Update ()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene("Title");
        }
    }
}
