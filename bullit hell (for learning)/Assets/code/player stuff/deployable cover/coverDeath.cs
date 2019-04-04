using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coverDeath : MonoBehaviour
{
    public float life;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DieDieDie", life);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DieDieDie()
    {
        Destroy(gameObject);
    }
}
