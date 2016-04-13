using UnityEngine;
using System.Collections;

public class ActiveCameraSwitch : MonoBehaviour {

	public Camera [] setActiveCamera;
	public int cameras=3;
	public int i=0;
	private int resetCam=0;
	// Use this for initialization
	void Update() {
		if (Input.GetKeyDown ("c")) {

			//this switches through the camera views
				switch(i){
				case 0 : print ("camera1");
					setActiveCamera[i].enabled =true;
					setActiveCamera[1].enabled =false;
					setActiveCamera[2].enabled =false;
					i++;
					break;
				case 1: 
					print ("camera2");
					setActiveCamera[i].enabled =true;
					setActiveCamera[0].enabled =false;
					setActiveCamera[2].enabled =false;
					i++;
					break;
				case 2: print ("camera3");
					setActiveCamera[i].enabled =true;
					setActiveCamera[0].enabled =false;
					setActiveCamera[1].enabled =false;
					i=resetCam; 
					break;


				}
			
		}
	}
}

