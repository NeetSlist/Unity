using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class spawner : MonoBehaviour {



	Transform tr;
	public GameObject zombie;
	public Transform Camera;
	GameObject zomb;
	// Use this for initialization
	void Start () {
		InvokeRepeating("spawn", 10f,10f);

		tr = GetComponent<Transform> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void spawn() {
		
		zomb = Instantiate(zombie, tr.position, tr.rotation);
		zomb.GetComponent<NavMeshAgent>().SetDestination(Camera.position);


	}
}
