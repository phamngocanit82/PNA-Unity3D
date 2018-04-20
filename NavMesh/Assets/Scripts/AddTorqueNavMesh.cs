using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTorqueNavMesh : MonoBehaviour {
	public float amount = 50f;
	Rigidbody rigidbody;
	void Awake (){
		rigidbody = GetComponent<Rigidbody> ();
	}

	void FixedUpdate ()
	{
		//float h = Input.GetAxis("Horizontal") * amount * Time.deltaTime;
		//float v = Input.GetAxis("Vertical") * amount * Time.deltaTime;
		float h =Random.Range(-1.0f, 1.0f);
		float v = Random.Range (-1.0f, 1.0f);
		Debug.Log ("h "+h+"v"+v);
		rigidbody.AddTorque(transform.up * h);
		rigidbody.AddTorque(transform.right * v);
	}
}
