using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireMissle : MonoBehaviour {
    bool hasShip = false;
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void fireMissle(Tile tile)
    {
        if (hasShip)
        {
            tile.GetComponent<Image>().color = Color.red;
            
        }
        else
        {
            tile.GetComponent<Image>().color = Color.black;
        }
        
    }


}
