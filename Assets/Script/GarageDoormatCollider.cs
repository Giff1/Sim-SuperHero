using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageDoormatCollider : MonoBehaviour {


    GameObject GarageDoor;
    GameObject GarageDoormat;
    GameObject GarageBrickWall;
    GameObject GarageRoof;

    void Start()
    {

        GarageDoor = GameObject.Find("Garage Door");
        GarageDoormat = gameObject;
        GarageBrickWall = GameObject.Find("Garage Brick Walls");
        GarageRoof = GameObject.Find("Garage Roof");
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        GarageDoor.SetActive(true);
        GarageDoormat.SetActive(false);
        GarageBrickWall.SetActive(true);
        GarageRoof.SetActive(true);
    }
}
