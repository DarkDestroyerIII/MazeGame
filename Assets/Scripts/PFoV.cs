using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PFoV : MonoBehaviour {
	public GameObject box;
	float timeLeft = 38.0f;

	RaycastHit hit;

	int Reach   = 200;
	int count   = 0;
	bool Rayhit = false;
	bool enter = false;
		void Start () {
		
	}

	void OnTriggerEnter(Collider box){
		enter = true;
	}

	// Update is called once per frame
	void Update () {
		//if (timeLeft < 0) {

		if (enter) {
			var fwd = transform.InverseTransformDirection (Vector3.forward);
			Debug.DrawRay (transform.position, fwd * Reach, Color.red);

			if (Physics.Raycast (transform.position, fwd, out hit, Reach) && hit.transform.tag == "Finish") {
				Debug.Log (Rayhit = true);
			} else {
				Debug.Log (Rayhit = false);
			}
		}
		//}
	}
}
