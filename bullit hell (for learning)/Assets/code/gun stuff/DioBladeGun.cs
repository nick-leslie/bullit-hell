using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DioBladeGun : MonoBehaviour
{


    public GameObject knife;
    public Transform startpoint;
    public float startwaittime;
    private float waittime;
    public GameObject player;
    // Use this for initialization
    void Start()
    {
        waittime = startwaittime;
    }


    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ);
        if (player.GetComponent<ammocount>().TotalSpecialAmmo > 0)
        {
            if (waittime <= 0)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    player.GetComponent<ammocount>().TotalSpecialAmmo -= 1;
                    Instantiate(knife, startpoint.position, transform.rotation);
                    waittime = startwaittime;
                }
            }
            else
            {
                waittime -= Time.deltaTime;
            }
        }
    }
}