using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinklerSystem : MonoBehaviour {

    private bool sprinklerSystem;
    private double costOfWater;
    public GameObject sprinklers; 
    // Use this for initialization
    
	void Awake () {
        

    }
	
    
	// Update is called once per frame
	void Update () {
        sprinklers = GameObject.FindWithTag("Sprinkler Head");
        if (Input.GetKey(KeyCode.F))
        {
            print("You turned on the sprinklers.");
            sprinklers.SetActive(true);
        }

    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        print("you are hitting the sprinklers");
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        print("you walked away from sprinklers");   
    }
}
