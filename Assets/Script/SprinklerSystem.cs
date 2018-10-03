using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinklerSystem : MonoBehaviour {

    public bool sprinklerOnOff;
    private double costOfWater;
    public GameObject[] sprinklers; 
    // Use this for initialization
    
	void Awake () {
        for(int i = 0; i < sprinklers.Length; i++)
        {
            sprinklers[i].SetActive(false);
        }

    }
	
    
	// Update is called once per frame
	void Update () {


        if (Input.GetKey(KeyCode.F) && sprinklerOnOff == false)
        {
            print("You turned on the sprinklers.");
            for (int i = 0; i < sprinklers.Length; i++)
            {
                sprinklers[i].SetActive(true);
            }
            sprinklerOnOff = true;
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
