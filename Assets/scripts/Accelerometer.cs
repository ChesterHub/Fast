using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Accelerometer : MonoBehaviour {

	public float speed = 30.0f;
	public Text countText;
	private Rigidbody rb;
	private int score;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		score = 0;
		SetCountText();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveX = Input.acceleration.x;
        // transform.Rotate(temp, 0,0);
        // transform.Translate(moveX, 0, 0);
		Vector3 movement = new Vector3(moveX, 0.0f, 0);
		rb.AddForce(movement * 300.0f);
		Debug.Log(speed);

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("pickups")) {
			other.gameObject.SetActive(false);
			score += 1;
			SetCountText();
		}
	}

	void SetCountText()
	{
		countText.text = "Count: " + score.ToString();
	}
}
