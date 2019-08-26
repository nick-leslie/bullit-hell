using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class enemySpawer : MonoBehaviour
{
    public Transform position;
    public GameObject mapCreator;
    public float x;
    public float topx;
    public float y;
    public float topy;
    public bool spawn=false;
    public float timetillgo;
    public Tilemap topmap;
    public GameObject enemy;
    public int enemyamount;
    public int amountofruns;
    public float distence;
    public LayerMask thigstohit;
    public bool goodToGo=false;
    // Start is called before the first frame update
    void Start()
    {

    }
          
    // Update is called once per frame
    void Update()
    {
        if (goodToGo == false)
        {
            timetillgo -= Time.deltaTime;
        }
        if (timetillgo<=0)
        {
            spawn = true;
            goodToGo = true;
        }
        if (spawn == true)
        {
            randompos();
            for (int g = 0; g < amountofruns; g++)
            {
                RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, transform.right, distence, thigstohit);
                Debug.Log(hitinfo.collider);
                if (hitinfo.collider != null)
                {
                    if (hitinfo.collider.CompareTag("rock"))
                    {
                        Debug.Log("yo");
                        randompos();
                    }
                }
                else
                {
                    enemySpawn();
                }
            }
            spawn = false;
        }
    }
    public void randompos()
    {
            topx = mapCreator.GetComponent<TileAutomator>().width * 20 / 2;
            topy = mapCreator.GetComponent<TileAutomator>().hight * 20 / 2;
            x = Random.Range(-topx, topx);
            y = Random.Range(-topy, topy);
            position.position = new Vector3(x, y, 0);
            
        }

    public void enemySpawn()
    {
        enemyamount = Random.Range(1, 10);
        for (int i = 0; i < enemyamount; i++)
        {
            enemyamount = Random.Range(1, 10);
            Instantiate(enemy, transform.position + new Vector3(Random.Range(-20, 20), Random.Range(-20, 20), 0), transform.rotation);

        }
        goodToGo = false;
    }

      
           
    }

