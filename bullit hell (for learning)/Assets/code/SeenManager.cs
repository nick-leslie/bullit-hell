using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SeenManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void play()
    {
        SceneManager.LoadScene(1);
    }
    public void dev()
    {
        SceneManager.LoadScene(2);
    }
    public void back() 
    {
        SceneManager.LoadScene(0);
    }

}
