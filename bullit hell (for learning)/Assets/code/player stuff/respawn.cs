using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour {
    public GameObject player;
    private GameObject[] spawner;
    public GameObject spawnpoint;
    private GameObject MainCammra;
    public GameObject respawnButton;
    // Use this for initialization
    void Start () {
        spawner = GameObject.FindGameObjectsWithTag("espawner");
        MainCammra = GameObject.FindWithTag("MainCamera");
    }
	
	// Update is called once per frame
	void Update () {

	}
public void respawning() {
        Instantiate(player);
            respawnButton.SetActive(false);
            MainCammra.GetComponent<camcontroler>().watchplayer = true;
            for (int i = 0; i < spawner.Length; i++)
            {
                spawner[i].GetComponent<enemyspawner>().spawngo = true;
            }
        
    }
    public void buttonappers()
    {
        respawnButton.SetActive(true);
    }
}
