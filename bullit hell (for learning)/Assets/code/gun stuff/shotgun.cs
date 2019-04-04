using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotgun : MonoBehaviour {
    public Transform shotpoint;
    public float attackrades;
    public LayerMask whatisenemy;
    public float distence;
    public GameObject pellets;
    public float spred;
    public int shots;
    //----------------------
    public int CurrentClipSize;
    public int MaxClipSize;
    public GameObject player;
    // Use this for initialization
    void Start() {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ);
        if (CurrentClipSize > 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                for (int i = 0; i < shots; i++)
                {
                    Instantiate(pellets, shotpoint.position, transform.rotation * Quaternion.Euler(0, 0, Random.Range(-spred, spred)));
                }
                CurrentClipSize -= 1;
            }
        }
            if (Input.GetKeyDown(KeyCode.R))
            {
                reload();
            }
    }
    public void reload()
    {
        while (CurrentClipSize < MaxClipSize)
        {
            CurrentClipSize++;
            player.GetComponent<ammocount>().TotalLightAmmo--;
        }
    }
}
