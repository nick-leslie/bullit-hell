using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AmmoText : MonoBehaviour
{
    public Text clipCounter;
    public Text overallAmmo;
    public GameObject player;
    // Use this for initialization
    void Start()
    {
        clipCounter = GameObject.Find("current clip").GetComponent<Text>();
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("pistol(Clone)") != null)
        {
            clipCounter.text = GameObject.Find("pistol(Clone)").GetComponent<pistol>().CurrentMagSize.ToString() + " | " + player.GetComponent<ammocount>().TotalLightAmmo.ToString(); 
        }
        if (GameObject.Find("shotgun(wip)(Clone)") != null)
        {
            clipCounter.text = GameObject.Find("shotgun(wip)(Clone)").GetComponent<shotgun>().CurrentClipSize.ToString() + " | " + player.GetComponent<ammocount>().TotalMediumAmmo.ToString();
        }
        if (GameObject.Find("Dio blade(Clone)") != null)
        {
            clipCounter.text = player.GetComponent<ammocount>().TotalSpecialAmmo.ToString();
        }
    }
}
