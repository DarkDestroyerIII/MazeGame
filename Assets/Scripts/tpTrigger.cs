using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tpTrigger : MonoBehaviour {

	public string tagToCheck;

	public Vector3 positionOffset;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider otherCollider){

		if (otherCollider.gameObject.CompareTag (tagToCheck)) {

			otherCollider.transform.position = otherCollider.transform.position + positionOffset;


		}


	}
}
