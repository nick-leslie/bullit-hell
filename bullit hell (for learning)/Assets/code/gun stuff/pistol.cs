using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class pistol : MonoBehaviour
{
    public float offset;

    public GameObject bullet;
    public Transform startpoint;
    public float startwaittime;
    private float waittime;
    //------------------------
    //reload stuff
    public int CurrentMagSize;
    public int MaxMagsize;
    public int TotalReserve;
    public int diffrence;
    //------------------------
    public GameObject player;
    public string guntype;
    public GameObject ShotText;
    // Use this for initialization
    void Start()
    {
        waittime = startwaittime;
        player = GameObject.FindGameObjectWithTag("Player");

    }


    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
        if (CurrentMagSize > 0)
        {
            if (waittime <= 0)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    CurrentMagSize-=1;
                    Instantiate(bullet, startpoint.position, transform.rotation);
                    waittime = startwaittime;
                }
            }
            else
            {
                waittime -= Time.deltaTime;
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            reload();
        }
    }
    public void reload()
     {
        while (CurrentMagSize < MaxMagsize) 
        {
            CurrentMagSize++;
            player.GetComponent<ammocount>().TotalLightAmmo--;
        }


    }

}
