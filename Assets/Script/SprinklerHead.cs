using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinklerHead : MonoBehaviour {

    public GameObject sprinklers;

    // Use this for initialization
    void Awake () {
        sprinklers = GameObject.FindWithTag("Sprinkler Head");
        sprinklers.SetActive(false);
	}
	
}
