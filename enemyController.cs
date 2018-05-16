using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyController : MonoBehaviour {
	NavMeshAgent nav;
	public Transform target;
	Animator anim;
	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
		anim = GetComponent<Animator> ();
	}


	// Update is called once per frame
	void Update () {
		GetComponent<NavMeshAgent> ().SetDestination(target.position);

	}
	void OnCollisionEnter(Collision arg){
		if (arg.gameObject.tag == "bullet") {
			Destroy (arg.gameObject);
			anim.SetFloat ("dead", 1.5f);
		}
		if (arg.gameObject.tag == "MainCamera") {
			Destroy (arg.gameObject);
		}
		if (arg.gameObject.tag == "dd") {
			Destroy (arg.gameObject);
		}
	}
}
