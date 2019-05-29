using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveDeactiveStartObject : MonoBehaviour {

    public GameObject obiekt;
    public bool aktywacja = false;

	void Update () 
	{
        if (aktywacja && obiekt.activeSelf == false)
        {
            obiekt.SetActive(true);
        }
        if (!aktywacja && obiekt.activeSelf == true)
        {
            obiekt.SetActive(false);
        }
		
	}
}
