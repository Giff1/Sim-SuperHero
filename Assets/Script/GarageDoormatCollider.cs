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

        GarageDoor = gameObject;
        GarageDoormat = GameObject.Find("Garage Doormat");
        GarageBrickWall = GameObject.Find("Garage Brick Walls");
        GarageRoof = GameObject.Find("Garage Roof");

        GarageDoormat.SetActive(false);

    }

    void OnTriggerEnter2D(Collider2D col)
    {

        GarageDoor.SetActive(true);
        GarageDoormat.SetActive(false);
        GarageBrickWall.SetActive(true);
        GarageRoof.SetActive(true);
    }
}
