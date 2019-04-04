using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DioBladeProjectile : MonoBehaviour {

    public float movespeed;
    public float life;
    public float distence;
    public LayerMask thigstohit;
    public int damage;
    public bool shoot=false;

    void Start()
    {
        Invoke("destroy", life);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            shoot = true;
        }
        RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, transform.up, distence, thigstohit);
        if (hitinfo.collider != null)
        {
            if (hitinfo.collider.CompareTag("Enemy"))
            {
                hitinfo.collider.GetComponent<enemy>().lowerhealth(damage);
            }
            destroy();
        }
        if (shoot == true)
        {
            transform.Translate(Vector2.right * movespeed * Time.deltaTime);
        }
    }
    void destroy()
    {
        Destroy(gameObject);
    }
}
