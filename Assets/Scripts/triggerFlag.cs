using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerFlag : MonoBehaviour {

	public GameObject gameObjectToEnable;
	public string tagToCheck;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider otherCollider){

		if (otherCollider.gameObject.CompareTag (tagToCheck)) {

			gameObjectToEnable.SetActive (true);
		}

		
	}

}
