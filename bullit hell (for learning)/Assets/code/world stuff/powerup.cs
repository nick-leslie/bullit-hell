using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour {
    public string ammotype;
    public int addamount;
    private bool timetodie = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
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
