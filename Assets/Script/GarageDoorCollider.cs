using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageDoorCollider : MonoBehaviour
{

    GameObject garageDoor;
    GameObject garageDoormat;

    void Start()
    {
        garageDoor = gameObject;
        garageDoormat = GameObject.Find("Garage Doormat");
        garageDoormat.SetActive(false);
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        GameObject.Find("Garage Door").SetActive(false); //this makes the door disappear when the player triggers it
        GameObject.Find("Garage Brick Walls").SetActive(false);
        GameObject.Find("Garage Roof").SetActive(false);

        print(garageDoormat.activeSelf);
        garageDoormat.SetActive(true);
        print(garageDoormat.activeSelf);

        garageDoor.SetActive(false);
        
    }

}
