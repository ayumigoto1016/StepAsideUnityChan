using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	private GameObject maincamera;



	/*void OnBecameInvisible(){

		Destroy (this.gameObject);

	}*/

	// Use this for initialization
	void Start () {

		this.maincamera = Camera.main.gameObject;

	
	}
	
	// Update is called once per frame
	void Update () {

		if (this.transform.position.z < maincamera.transform.position.z) {

			Destroy (this.gameObject);
		
		}
}
}

