using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomspawner : MonoBehaviour
{
  
        public int openingdirection;
        //1 bottom
        //2 top
        //3 left
        //4 right
        // Start is called before the first frame update
        private int rand;
        private roomtemplates templates;
        public bool spawned = false;
        void Start()
        {
            templates = GameObject.FindWithTag("rooms").GetComponent<roomtemplates>();
            Invoke("spawn", 0.1f);
        }

        // Update is called once per frame
        void spawn()
        {
            if (spawned == false)
            {
                if (openingdirection == 1)
                {
                    rand = Random.Range(0, templates.bottomrooms.Length);
                    Instantiate(templates.bottomrooms[3], transform.position, templates.bottomrooms[rand].transform.rotation);
                }
                else if (openingdirection == 2)
                {
                    rand = Random.Range(0, templates.toprooms.Length);
                    Instantiate(templates.toprooms[3], transform.position, templates.toprooms[rand].transform.rotation);
                }
                else if (openingdirection == 3)
                {
                    rand = Random.Range(0, templates.leftrooms.Length);
                    Instantiate(templates.leftrooms[3], transform.position, templates.leftrooms[rand].transform.rotation);
                }
                else if (openingdirection == 4)
                {
                    rand = Random.Range(0, templates.rightrooms.Length);
                    Instantiate(templates.rightrooms[3], transform.position, templates.rightrooms[rand].transform.rotation);
                }
                spawned = true;
            }
        }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("shart");
        if (other.CompareTag("Rspawnpoint"))
            {
            Debug.Log("shit balls");
            Destroy(gameObject);
        }
    }

        }



