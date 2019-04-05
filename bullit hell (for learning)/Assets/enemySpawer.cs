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
    public bool spawn=true;
    public Tilemap rocks;
    public GameObject enemy;
    public int enemyamount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (spawn == false)
        {
            randompos();
            enemyamount = Random.Range(1, 10);
            for (int i = 0; i < enemyamount; i++)
            {
                enemyamount = Random.Range(1, 10);
                Instantiate(enemy, transform.position + new Vector3(Random.Range(-20,20), Random.Range(-20, 20), 0), transform.rotation);

            }
            spawn = true;
        }
        if (Input.GetKey(KeyCode.G))
        {
            spawn = false;

        }

    }
    public void OnTriggerStay2D(Collider2D other)
    {
      //  Debug.Log("fuck dude");
        if (other.gameObject.CompareTag("wall"))
        {
            randompos();
            Debug.Log("ayy shit bro");
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
}
