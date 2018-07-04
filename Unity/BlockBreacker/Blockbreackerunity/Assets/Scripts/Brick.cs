using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    private LevelController levelController;
    public Sprite[] hitSprites;
    private int TimesHit;
    public static int CountBreakable=0;
    private bool isBreakable;
    // Use this for initialization
    void Start () {
        isBreakable = (this.tag == "Breakable");
        //keep track of breakable vricks
        if (isBreakable)
        {
            CountBreakable++;
        }
        TimesHit = 0;
        levelController = GameObject.FindObjectOfType<LevelController>();
        
    }
	
	// Update is called once per frame
	void Update () {
    

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (isBreakable)
        {
            handles();

        }
    }

    void handles()
    {
        TimesHit++;
        int maxHits = hitSprites.Length + 1;
        if (TimesHit >= maxHits)
        {
            CountBreakable--;
            levelController.BrickDestroy();
            Destroy(gameObject);
        }
        else
        {
            LoadSprites();
        }
    }    

    void LoadSprites()
    {
        int SpriteIndex = TimesHit - 1;
        if (hitSprites[SpriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[SpriteIndex];
        }
    }
    //TODO remove this method once we can actually win!

}
