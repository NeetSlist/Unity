using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
	Rigidbody rb;
	Transform tr;
	float v;
	public Rigidbody obj;
	Rigidbody clone;
	float f;
	float h;
	float mv;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		tr = GetComponent<Transform> ();

	}
	
	// Update is called once per frame
	void Update () {
		v = Input.GetAxis ("Vertical");
		rb.AddForce (tr.forward * v * 150f);
		h = Input.GetAxis ("Horizontal");


		f = Input.GetAxis ("Fire1");

		mv = Input.GetAxis ("Mouse X");
		Vector3 rotation = new Vector3(0, mv, 0);
		tr.Rotate (rotation*5f);
		if (f > 0) {
			clone = Instantiate (obj, tr.position, tr.rotation);
			clone.AddForce (tr.forward * 5000f);

		}
	}
}
