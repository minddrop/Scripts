using UnityEngine;
using System.Collections;

public class View : MonoBehaviour
{
    public float speed;
	// Update is called once per frame
	void Update ()
	{
	    transform.Translate(0, speed*Time.deltaTime, 0);
	}
}
