using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GrassDying : MonoBehaviour {

    public Sprite greenGrass;
    public Sprite yellowGrass;
    public Sprite deadGrass;
    private static float day;
    private SpriteRenderer spriteRenderer;
 
	// Use this for initialization
	void Start () {

        day = InGameClock.day;

        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer.sprite == null)
        {
            spriteRenderer.sprite = greenGrass;
        }
        
}

// Update is called once per frame
    void Update () {

        if (day == 1)
        {
            spriteRenderer.sprite = yellowGrass;
        }
		
	}

    void changeGrassColor()
    {
        
        if (spriteRenderer.sprite == greenGrass)
        {
            spriteRenderer.sprite = yellowGrass;
        }
        if(spriteRenderer.sprite == yellowGrass)
        {
            spriteRenderer.sprite = deadGrass;
        }

        
    }
}
