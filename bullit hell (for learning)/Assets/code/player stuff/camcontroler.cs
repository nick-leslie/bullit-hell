using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camcontroler : MonoBehaviour {

    public Vector3 offset;
    public bool watchplayer;
    public GameObject playerG;
    // Use this for initialization
    void Start()
    {
        watchplayer = true;
    }

    // Update is called once per frame
    void Update()
    {
        playerG = GameObject.FindWithTag("Player");
        if (watchplayer)
        {
            transform.position = playerG.transform.position + offset;
        }
    }
   public  void stopfollow()
    {
        watchplayer = false;
    }
}
