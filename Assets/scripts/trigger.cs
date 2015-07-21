using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {
	
	bool didITriggerYet = false;
	public ParticleSystem fireParticles; // assign on inspector
	
	// Update is called once per frame
	void Update () {
		if (didITriggerYet == true) {
			transform.Rotate (3f, 3f, 3f);
		}
	}
	//whenever an object with a rigid body enters the trigger, the code here will execute
	void OnTriggerEnter() {
		didITriggerYet = true;
		fireParticles.Play ();
	}
	
}
