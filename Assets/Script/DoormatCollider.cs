using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoormatCollider : MonoBehaviour {

	GameObject door;
	GameObject doormat;
	GameObject brickWall;
	GameObject windows;
	GameObject roof;

	void Start(){

		door = GameObject.Find ("Door");
		doormat = GameObject.Find ("Doormat");
		brickWall = GameObject.Find ("Brick Wall");
		windows = GameObject.Find ("Windows");
		roof = GameObject.Find ("Roof");

		doormat.SetActive (false);

	}

	void OnTriggerEnter2D (Collider2D trigger){
		
		door.SetActive (true);
		doormat.SetActive (false);
		brickWall.SetActive (true);
		windows.SetActive (true);
		roof.SetActive (true);


	}

}
