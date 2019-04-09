using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

    public int health;
    private Transform ptarget;
    private GameObject player;
    public float speed;
    //------------------------
    // damage stuff
    public int damage;
    public LayerMask whatisplayer;
    public float attackrange;
    public Transform attackpos;
    //------------------------------
    // deathstuff
    public bool alive;
    public int loweramount;
    //----------------------------
    public string state;
    public int maxdistensAway;
    public float estayaway;
    public GameObject[] enemys;
    //----------------------------
    public int SpawnChance;
    public GameObject Ammo;
    public int weponchance;
    public GameObject[] wepons;

	void Start () {
        player = GameObject.FindWithTag("Player");
        ptarget = player.GetComponent<Transform>();
        //------------------------s
        SpawnChance = Random.Range(1, 100);
        weponchance = Random.Range(0,wepons.Length);
	}
	
	// Update is called once per frames
	void Update () {
        //---------------------
        enemys = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < enemys.Length; i++)
        {
            if (enemys[i] != this.gameObject)
            {
                if (Vector2.Distance(transform.position, enemys[i].GetComponent<Transform>().position) < estayaway)
                {
                    transform.position = Vector2.MoveTowards(transform.position, ptarget.position, Random.Range(-estayaway,0) * Time.deltaTime);
                }
            }
        }
       
        //---------------------
        if (Vector2.Distance(transform.position,ptarget.position) < maxdistensAway )
        {
            state = "chase";
        }

        if (state == ("chase"))
        {
            transform.position = Vector2.MoveTowards(transform.position, ptarget.position, speed * Time.deltaTime);
        }

        Collider2D[] playerstodamage = Physics2D.OverlapCircleAll(attackpos.position, attackrange, whatisplayer);
        for (int i = 0; i < playerstodamage.Length; i++)
        {
            playerstodamage[i].GetComponent<UIControler>().health-=damage;
            edeath();
        }

        if (health<=0)
        {
            edeath();
        }
    }
    public void lowerhealth(int damage)
    {
        health -= damage;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackpos.position, attackrange);
    }
    //-----------------------
    public void edeath()
    {
        if (SpawnChance <26)
        {
            Instantiate(Ammo, transform.position, transform.rotation);
        } 
        if (SpawnChance < 13) 
        {
            Instantiate(wepons[weponchance], transform.position, transform.rotation);
        }

        player.GetComponent<playermovement>().Rage=true;
        alive = false;
        if (alive == false)
        {
            Destroy(gameObject);
        }
    }
    //---------------------------
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
        }
        else
        {
            Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>(), false);
        }
    }
}
