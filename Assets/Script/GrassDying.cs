using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GrassDying : MonoBehaviour {

    public Sprite[] grass;
    private static Text day;
    private Random randomGrass;
    private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
        day = InGameClock.dayText;
        //spriteRenderer = GetComponent<SpriteRenderer>();
        //if (spriteRenderer.sprite == null)
        //{
           // spriteRenderer.sprite = grassGreen;
        //}
        
	}
	
	// Update is called once per frame
	void Update () {

        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            spriteRenderer.sprite = grassLiteGreen;
        }
		*/
	}

    void changeGrassColor()
    {

        //if (spriteRenderer.sprite == grassGreen)
        //{
         //   spriteRenderer.sprite = grassLiteGreen;
        //}
    }
}
