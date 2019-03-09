using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class statusAdControll : MonoBehaviour {
    void OnGUI()
    {
        GUI.backgroundColor = Color.white;
        GUI.Button(new Rect(100, 70, 200, 200), mytext);
    }
    private  string mytext;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown("x")){
            Destroy(gameObject);
        }

        mytext = 
            "[a] view video 1 " +
            "\n[s] view video 2" +
            "\n[d] view video 3"+

            "\n------------status----------------"+
            "\n Dinosaur { " + Arduino_Initial.s1 + "," + Arduino_Initial.s2 + "," + Arduino_Initial.s3 + "}"+
            "\n Ship { " + Arduino_Initial.minitouch +" }"+
            "\n Rose { " + Arduino_Initial.rose + " }" +
            "\n---------------------------------" +

            "\n ####################\n [x] close [z] showStatus";
	}

}

