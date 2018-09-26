using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	public Animator animator;	
	private RigidbodyConstraints wiggling;
    public bool lockRotation;

	// Update is called once per frame
	void Update () {

		wiggling = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY;

		// If no key held, set to idle
        string animationTrigger = "Idle";
        // Else override with desired animation
        if (Input.GetKey (KeyCode.W)) {
			transform.position += new Vector3 (0, speed, 0);
            animationTrigger = "Up";
        } if (Input.GetKey(KeyCode.S)) {
            transform.position += new Vector3(0, -speed, 0);
            animationTrigger = "Down";
        // Left/Right after Up/Down to set direction for when combined
        } if (Input.GetKey (KeyCode.A)) {
			transform.position -= new Vector3 (speed, 0, 0);
            animationTrigger = "Left";
        } if (Input.GetKey (KeyCode.D)) {
			transform.position -= new Vector3 (-speed, 0, 0);
            animationTrigger = "Right";
        }
        // Set animation trigger as determined above
        animator.SetTrigger(animationTrigger);


        if (lockRotation)
        {
            transform.rotation = Quaternion.Euler(1, 1, 1);
        }
    }


}