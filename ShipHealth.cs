using UnityEngine;
using System.Collections;

public class ShipHealth : MonoBehaviour {
     
	//healthPoints
	public float hP =5;
	public float hPReset =6;
	public bool isShip =true;

	public AudioClip shootSound;
	
	private AudioSource source;

	private float volLowRange = .5f;
	private float volHiRange = 1.0f;
	public AudioClip DeadSound;
	
	private AudioSource dead;


	public AudioClip blip;
	private AudioSource source2;

	public AudioClip bling;
	private AudioSource starsound;

	void Awake() {
		starsound = GetComponent<AudioSource> ();
		source = GetComponent<AudioSource> ();
		source2 = GetComponent<AudioSource> ();  
	}



	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.CompareTag ("rock")) {
			if (hP > 0) {
				hP--;
				source.PlayOneShot (shootSound, 1F);
				Debug.Log ("hit"); 
			} else if (hP <= 0) {
				source.PlayOneShot (DeadSound, 1F);
				if (hP <= 0) {
					Destroy (gameObject);
					Debug.Log ("YouDead");
				}
			}
			//resets the health if this health is picked up
		} else if (col.gameObject .CompareTag ("health")) {

			hP = hPReset;
			if (hP > 0) {
				source2.PlayOneShot (blip, 1F);
			}
		} else if (col.gameObject .CompareTag ("star")) {
			starsound.PlayOneShot (bling , 1F);
		}
		 

	}

}
	
