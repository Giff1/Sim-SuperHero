using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GrassDying : MonoBehaviour {

    public Sprite greenGrass;
    public Sprite yellowGrass;
    public Sprite brownGrass;
    private static int day;
    private SpriteRenderer spriteRenderer;
 
	// Use this for initialization
	void Start () {
        day = InGameClock.day; //pulls day from InGameClock Class

        spriteRenderer = GetComponent<SpriteRenderer>();

       // spriteRenderer.sprite = grass[day % grass.Length];
       // print(grass[day % grass.Length]);
        
}

// Update is called once per frame
    void Update () {
        day = InGameClock.day; //pulls day from InGameClock Class

        if (day == 1)
        {
            spriteRenderer.sprite = greenGrass;
            
        }else if(day == 2)
        {
            spriteRenderer.sprite = yellowGrass;
        }else
        {
            spriteRenderer.sprite = brownGrass;
        }


        /*
        if ((day - 1) < (grass.Length - 1))
            spriteRenderer.sprite = grass[day - 1];
        else
            spriteRenderer.sprite = grass[grass.Length - 1];
    */
    }



}
