using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane_Control : MonoBehaviour {

    public MovieTexture[] myVDO;
    public AudioSource[] myAudio;
    private int VDOplaying;
    private float time;
    private float[] timeVDO = { 54.0f , 118.0f , 91.0f };

	void Start () {
        playVDO(VDOplaying);
	}
	
	void Update () {


        autoPlayVDO();
		
        if(Input.GetKeyDown("a") ||  Arduino_Initial.s1 > 0 || Arduino_Initial.s2 > 0 || Arduino_Initial.s3 > 0 ) {
            if (VDOplaying != 0) {
                VDOplaying = 0;
                playVDO(VDOplaying);
            }
        } 
        else if (Input.GetKeyDown("s") ||  Arduino_Initial.minitouch > 0) {
            if (VDOplaying != 1)
            {
                VDOplaying = 1;
                playVDO(VDOplaying);

            }
        }
        else if (Input.GetKeyDown("d")) {
            if (VDOplaying != 2)
            {
                VDOplaying = 2;
                playVDO(VDOplaying);

            }
        }
	}

    void playVDO(int vdo) {
        
        for (int i = 0; i < myVDO.Length; i++)
        {
            myVDO[i].Stop();
            myAudio[i].Stop();
        }
        myVDO[vdo].Play();
        myAudio[vdo].Play();
        GetComponent<Renderer>().material.mainTexture = myVDO[vdo] as MovieTexture;
        time = 0;
    }


    void autoPlayVDO() {
        time += Time.deltaTime;
        if (VDOplaying == 0)
        {
            if (time > timeVDO[0])
            {
                VDOplaying = 1;
                playVDO(VDOplaying);
            }
        }
        else if (VDOplaying == 1)
        {
            if (time > timeVDO[1])
            {
                VDOplaying = 2;
                playVDO(VDOplaying);
            }
        }
        else if (VDOplaying == 2)
        {
            if (time > timeVDO[2])
            {
                VDOplaying = 0;
                playVDO(VDOplaying);
            }
        }
    }

}
