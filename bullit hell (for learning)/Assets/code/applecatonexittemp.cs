using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class applecatonexittemp : MonoBehaviour
{
    public Text frameCounter;
    public int framerate;
    // Start is called before the first frame update
    void Start()
    {
        frameCounter = GameObject.Find("frameCounter").GetComponent<Text>();
        Application.targetFrameRate = 300;

    }

    // Update is called once per frame
    void Update()
    {
        framerate = Mathf.RoundToInt(1.0f / Time.deltaTime);
        frameCounter.text = framerate.ToString();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
