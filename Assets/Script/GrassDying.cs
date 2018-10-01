using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GrassDying : MonoBehaviour {

    public Sprite[] grass;
    private Sprite greenGrass;
    private Sprite yellowGrass;
    private Sprite brownGrass;
    private static int day;
    private SpriteRenderer spriteRenderer;
 
	// Use this for initialization
	void Start () {
        day = InGameClock.day; //pulls day from InGameClock Class

        print(day);
  
        
        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = grass[day % grass.Length];
    
        
}

// Update is called once per frame
    void Update () {
        day = InGameClock.day; //pulls day from InGameClock Class
        print(day);

        if(day == 1)
        {
            spriteRenderer.sprite = grass[0];
        }else if(day == 2)
        {
            spriteRenderer.sprite = grass[1];
        }else
        {
            spriteRenderer.sprite = grass[2];

        }


        /*
        if ((day - 1) < (grass.Length - 1))
            spriteRenderer.sprite = grass[day - 1];
        else
            spriteRenderer.sprite = grass[grass.Length - 1];
    */
    }



}
