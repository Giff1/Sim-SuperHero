using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinklerSystem : MonoBehaviour {

    public bool sprinklerOnOff;
    private double costOfWater;
    public Animator[] animator;
    // Use this for initialization
    
	void Awake () {
        for (int i = 0; i < animator.Length; i++)
        {
            animator[i].Play("Sprinkler_Idle");
        }

    }
	
    
	// Update is called once per frame
	void Update () {


        
        

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        
        print("you are hitting the sprinklers");
        if (Input.GetKeyDown(KeyCode.F) && sprinklerOnOff == false)
        {
            print("You turned on the sprinklers.");
            for (int i = 0; i < animator.Length; i++)
            {
                animator[i].Play("Sprinkler_On");
            }
            // animator.Play("Sprinkler_On");
            sprinklerOnOff = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && sprinklerOnOff == true)
        {

            print("You turned off the sprinklers");
            //animator.Play("Sprinkler_Off");
            for (int i = 0; i < animator.Length; i++)
            {
                animator[i].Play("Sprinkler_Off");
            }

            sprinklerOnOff = false;
        }
    }

}
