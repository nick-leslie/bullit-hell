using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour {
    public int health;
    public int maxhealth;
    public bool alive;
    private GameObject[] allenemys;
    private GameObject[] spawner;
    private GameObject player;
    private GameObject cam;
    public GameObject Respawner;
    private GameObject sceanManiger;
	void Start () {
       
        spawner = GameObject.FindGameObjectsWithTag("espawner");
        player = GameObject.FindWithTag("Player");
        player.GetComponent<UIControler>();
        cam = GameObject.FindWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
        Respawner = GameObject.FindGameObjectWithTag("pspawner");
        allenemys = GameObject.FindGameObjectsWithTag("Enemy");
        health = player.GetComponent<UIControler>().health; 
        if (health<=0)
        {
            for (int i = 0; i < allenemys.Length; i++)
            {
                allenemys[i].GetComponent<enemy>().edeath();
            }
            //     for (int i = 0; i < spawner.Length; i++)
            //   {
            //     spawner[i].GetComponent<enemyspawner>().spawngo=false;
            // }
            sceanManiger = GameObject.FindWithTag("scean swaper");
            sceanManiger.GetComponent<SeenManager>().back();
            cam.GetComponent<camcontroler>().stopfollow();
            alive = false;
            if (alive == false)
            {
                Destroy(gameObject);
            }
        }
    }
   
}

