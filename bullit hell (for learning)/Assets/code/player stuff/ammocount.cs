using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammocount : MonoBehaviour {
   

      public int TotalLightAmmo;
    public int TotalMediumAmmo;
    public int TotalHeavyAmmo;
    public int TotalSpecialAmmo;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   public  void addammo(int addamount,string AmmoType) { 
   if (AmmoType=="light")
        {
            TotalLightAmmo += addamount;
        } else if(AmmoType== "medium")
        {
            TotalMediumAmmo += addamount;
        } else if (AmmoType=="heavy")
        {
            TotalHeavyAmmo += addamount;
        } else if (AmmoType=="special") 
        {
            TotalSpecialAmmo += addamount;
        }
    }

}
