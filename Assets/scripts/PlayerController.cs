using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    private Rigidbody rb;
    private int score;

	// Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
        score = 0;
        SetCountText();
    }
	// Update is called once per frame
    void FixedUpdate() {
        // float moveHorizontal = Input.GetAxis("Horizontal");
        // float moveVertical = Input.GetAxis("Vertical");
        // //transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z);
        // transform.Translate(Vector3.forward);

        // Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        // rb.AddForce(movement * speed);
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
