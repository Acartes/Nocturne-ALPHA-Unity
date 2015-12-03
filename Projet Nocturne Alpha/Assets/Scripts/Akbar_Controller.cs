using UnityEngine;
using System.Collections;

public class Akbar_Controller : MonoBehaviour {

	private int speed = 10;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");				
		transform.Translate(Vector3.forward * moveVertical * speed * Time.deltaTime);
		transform.Rotate (0.0f, moveHorizontal * speed / 2.5f, 0.0f);
	}
}