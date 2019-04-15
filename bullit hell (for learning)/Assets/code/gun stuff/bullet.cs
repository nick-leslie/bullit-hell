using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    public float movespeed;
    public float life;
    public float distence;
    public LayerMask thigstohit;
    public int damage;


	void Start () {
       Invoke("destroy", life);
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, transform.right, distence, thigstohit);
        if (hitinfo.collider != null)
        {
            if (hitinfo.collider.CompareTag("rock"))
            {
                Debug.Log("damm it");
            }
            if (hitinfo.collider.CompareTag("Enemy"))
            {
               hitinfo.collider.GetComponent<enemy>().lowerhealth(damage);
            }
            destroy();
        }
        transform.Translate(Vector2.right * movespeed * Time.deltaTime);
	}
    void destroy()
    {
        Destroy(gameObject);
    }

}

