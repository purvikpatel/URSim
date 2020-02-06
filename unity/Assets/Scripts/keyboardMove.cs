using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardMove : MonoBehaviour {

	public float mSpeed;
    public GameObject vehicle;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		mSpeed = 5f;
		// rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate () {
		float sway = Input.GetAxis ("sway");
		float heave = Input.GetAxis ("heave");
        float surge = Input.GetAxis ("surge");
        float yaw = Input.GetAxis ("yaw");
        float roll = Input.GetAxis("roll");
        float pitch = Input.GetAxis("pitch");

		Vector3 movement = new Vector3 (sway, heave, surge);
        rb.AddForce (movement * 2500f);
		rb.AddTorque(transform.up * 500 * yaw);
        rb.AddTorque(transform.right * 500 * roll);
        rb.AddTorque(transform.forward * 500 * pitch);
	}
	
	// Update is called once per frame
	// void Update () {
	// 	transform.Translate (mSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime * -1, -1 * mSpeed * Input.GetAxis ("Horizontalmove") * Time.deltaTime, mSpeed * Input.GetAxis ("Vertical") * -1 * Time.deltaTime);
	// }
}
