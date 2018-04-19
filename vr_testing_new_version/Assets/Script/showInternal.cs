using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showInternal : MonoBehaviour {

    public Canvas internalpage;
    public bool showed = false;
	// Use this for initialization
	void Start () {
        internalpage.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void haha()
    {
        if(showed == false)
        {
            showed = true;
            internalpage.enabled = true;
        }

        else 
        {
            showed = false;
            internalpage.enabled = false;
        }
    }

}
