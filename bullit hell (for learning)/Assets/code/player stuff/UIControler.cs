using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControler : MonoBehaviour {
    public int maxhealthl;
    public int health;

    public Image[] healthamount;
    public Image[] hotbar;

    public Sprite fullheart;
    public Sprite emptyheart;

    public GameObject player;
    public GameObject[] wepon;
    public Sprite normalmode;
    //------------------------
    public GameObject pistol;
    public Sprite pistolslot;
    //------------------------
    public GameObject shotgun;
    public Sprite shotgunSlot;
    //-----------------------
    public GameObject DioBlade;
    public Sprite DioBladeSlot;
    // Use this for initialization
    void Start() {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update() {
        wepon = GameObject.FindGameObjectsWithTag("wepons");
        for (int i = 0; i < player.GetComponent<hotbar>().wepons.Length; i++)
        {

        }
        for (int i = 0; i < healthamount.Length; i++)
        {
            if (i < health)
            {
                healthamount[i].sprite = fullheart;
            }
            else
            {
                healthamount[i].sprite = emptyheart;
            }
            if (i < maxhealthl)
            {
                healthamount[i].enabled = true;
            }
            else
            {
                healthamount[i].enabled = false;
            }
        }
        for (int r = 0; r < hotbar.Length; r++)
        {
            if (r < player.GetComponent<hotbar>().topslot-1)
            {
                hotbar[r].enabled = true;
            }
            else
            {
                hotbar[r].enabled = false;
            }
            if (player.GetComponent<hotbar>().wepons[r] != null)
            {
                if (player.GetComponent<hotbar>().wepons[r] == pistol)
              {
                    hotbar[r].sprite = pistolslot;
                } else if(player.GetComponent<hotbar>().wepons[r] == shotgun) 
                {
                    hotbar[r].sprite = shotgunSlot;
                } else if (player.GetComponent<hotbar>().wepons[r] == DioBlade)
                {
                    hotbar[r].sprite = DioBladeSlot;
                }
                else
                {
                    hotbar[r].sprite = normalmode;
                }
            }
        }
    }
} 

