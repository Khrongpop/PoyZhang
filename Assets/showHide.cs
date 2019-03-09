using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showHide : MonoBehaviour {
    public GameObject statusarduino;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      

      if (Input.GetKeyDown("z"))
        {
            Instantiate(statusarduino,statusarduino.transform.position,transform.rotation);
        }
	}
}
