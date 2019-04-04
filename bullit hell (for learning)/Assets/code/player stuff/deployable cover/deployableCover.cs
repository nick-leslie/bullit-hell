using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployableCover : MonoBehaviour
{
    public float life;
    public GameObject cover;
    public Transform startpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ);
       
         if (Input.GetKeyDown(KeyCode.Q))
        {
            spwan();
        }
    }
   public void spwan()
    {
        Instantiate(cover, startpoint.position,transform.rotation);
    }
}
