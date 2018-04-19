using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	
    public GvrEditorEmulator gvr;


    public void moveCamera()
    {
        gvr.transform.position = new Vector3(transform.position.x+1, transform.position.y , transform.position.z);


    }
    // Update is called once per frame
    void Update () {
		
	}
}
