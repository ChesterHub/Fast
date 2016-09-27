using UnityEngine;
using System.Collections;

public class Accelerometer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float moveX = Input.acceleration.x;
        // transform.Rotate(temp, 0,0);
        transform.Translate(moveX, 0, 0);
        Debug.Log(moveX);
	
	}
}
