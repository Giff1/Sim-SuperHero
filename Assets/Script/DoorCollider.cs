using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollider : MonoBehaviour {

	GameObject door;
	GameObject doormat;

	void Start(){
		door = GameObject.Find ("Door");
		doormat = GameObject.Find ("Doormat");

	}

	void OnTriggerEnter2D (Collider2D trigger){
		GameObject.Find ("Door").SetActive(false); //this makes the door disappear when the player triggers it
		GameObject.Find ("Brick Wall").SetActive(false);
		GameObject.Find ("Windows").SetActive(false);
		GameObject.Find ("Roof").SetActive(false);

		doormat.SetActive (true);
		door.SetActive (false);



	}

}
