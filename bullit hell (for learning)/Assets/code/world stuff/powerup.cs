using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour {
    public string ammotype;
    public int addamount;
    private bool timetodie = false;
    public int chance;
	// Use this for initialization
	void Start () {
        chance = Random.Range(1, 4);
	}
	
	// Update is called once per frame
	void Update () {
	switch (chance)
    {
            case 1:
                ammotype = "light";
                break;
            case 2:
                ammotype = "medium";
                break;
            case 3:
                ammotype = "heavy";
                break;
            case 4:
                ammotype = "special";
                break;

    }


    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            applypowerup(other);
        }
      
    }
    void applypowerup(Collider2D player)
    {
        player.GetComponent<ammocount>().addammo(addamount,ammotype);
        timetodie = true;
        if (timetodie)
        {
            Destroy(gameObject);
        }
    }
}
