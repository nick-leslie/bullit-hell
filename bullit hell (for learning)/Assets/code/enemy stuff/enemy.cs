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
	void Start () {
      
        player = GameObject.FindWithTag("Player");
        ptarget = player.GetComponent<Transform>();
        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector2.MoveTowards(transform.position, ptarget.position, speed * Time.deltaTime);


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
    public void edeath()
    {
        player.GetComponent<playermovement>().Rage=true;
        alive = false;
        if (alive == false)
        {
            Destroy(gameObject);
        }
    }
}
