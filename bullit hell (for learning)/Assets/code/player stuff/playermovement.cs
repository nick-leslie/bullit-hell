using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playermovement : MonoBehaviour {
    public float moveimputlr;
    public float moveimputud;
    public float movespeed;
    public float MoveSpeedWithModifires;
    public float KillSpeedMod;
    public bool Rage=false;
    public float RageTime;
    private float RageTimeConsule;
    public Rigidbody2D rb;
    public float dashspeed;
    public GameObject ragepartcal;
    public GameObject player;
    public GameObject currentrage;
    // Use this for initialization
    void Start () {
        RageTimeConsule = RageTime;
        player = GameObject.FindWithTag("Player");
    }
    
    // Update is called once per frame
    void Update () {
       if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.Translate(dashspeed * moveimputlr, dashspeed * moveimputud,0);
        }
        MoveSpeedWithModifires = movespeed + KillSpeedMod;
        if (Rage)
        {
            if (currentrage==null)
            {
                Instantiate(ragepartcal, player.GetComponent<Transform>());
            }
        KillSpeedMod = 10;
            RageTimeConsule -= Time.fixedDeltaTime;
            if (RageTimeConsule <= 0)
            {
                Destroy(currentrage);
            KillSpeedMod = 0;
            RageTimeConsule = RageTime;
            Rage = false;
            }
        }
        currentrage = GameObject.FindWithTag("rage");
    }
    void FixedUpdate()
    {
        moveimputlr = Input.GetAxisRaw("Horizontal");
        moveimputud = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(movespeed * moveimputlr, MoveSpeedWithModifires * moveimputud);
    }

    }

