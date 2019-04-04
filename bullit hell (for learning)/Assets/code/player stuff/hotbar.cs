using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hotbar : MonoBehaviour
{
    public GameObject[] wepons;
    public GameObject currenntwepon;
    public GameObject startpoint;
    private KeyCode[] keyCodes = {
         KeyCode.Alpha1,
         KeyCode.Alpha2,
         KeyCode.Alpha3,
         KeyCode.Alpha4,
         KeyCode.Alpha5,
         KeyCode.Alpha6,
         KeyCode.Alpha7,
         KeyCode.Alpha8,
         KeyCode.Alpha9,
     };
    public int slot;
    public int topslot;
    // Use this for initialization
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < keyCodes.Length; i++)
        {
            if (Input.GetKeyDown(keyCodes[i]))
            {
                slot = i+1;
            }

        }
        for (int o = 0; o < wepons.Length; o++)
        {
            if (wepons[o] == null)
            {
                topslot = o+1;
                break;
            }
        }
        switch (slot)
        {
            case 1:
                Destroy(currenntwepon);
                Instantiate(wepons[0], startpoint.transform);
                slot = 0;
                break;
            case 2:
                if (wepons[1] != null)
                {
                    Destroy(currenntwepon);
                    Instantiate(wepons[1], startpoint.transform);
                    slot = 0;
                }
                else
                {
                    slot = topslot - 1;
                }
                break;
            case 3:
                if (wepons[2] != null)
                {
                    Destroy(currenntwepon);
                    Instantiate(wepons[2], startpoint.transform);
                    slot = 0;
                }
                else
                {
                    slot = topslot - 1;
                }
                break;
            case 4:
                if (wepons[3] != null)
                {
                    Destroy(currenntwepon);
                    Instantiate(wepons[3], startpoint.transform);
                    slot = 0;
                }
                else
                {
                    slot = topslot - 1;
                }
                break;
            case 5:
                if (wepons[4] != null)
                {
                    Destroy(currenntwepon);
                    Instantiate(wepons[4], startpoint.transform);
                    slot = 0;
                }
                else
                {
                    slot = topslot - 1;
                }
                break;
            case 6:

                if (wepons[5] != null)
                {
                    Destroy(currenntwepon);
                    Instantiate(wepons[5], startpoint.transform);
                    slot = 0;
                }
                else
                {
                    slot = topslot - 1;
                }
                break;
            case 7:

                if (wepons[6] != null)
                {
                    Destroy(currenntwepon);
                    Instantiate(wepons[6], startpoint.transform);
                    slot = 0;
                }
                else
                {
                    slot = topslot - 1;
                }
                break;
            case 8:
                if (wepons[7] != null)
                {
                    Destroy(currenntwepon);
                    Instantiate(wepons[7], startpoint.transform);
                    slot = 0;
                }
                else
                {
                    slot = topslot - 1;
                }
                break;
            case 9:

                if (wepons[9] != null)
                {
                    Destroy(currenntwepon);
                    Instantiate(wepons[9], startpoint.transform);
                    slot = 0;
                }
                else
                {
                    slot = topslot - 1;
                }
                break;
        }
        currenntwepon = GameObject.FindWithTag("wepons");
    }
}
