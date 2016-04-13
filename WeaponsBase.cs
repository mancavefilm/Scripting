using UnityEngine;
using System.Collections;

public class WeaponsBase : MonoBehaviour {

	public delegate void AmmoAdd();
	public static event AmmoAdd ammoAdd;


	void OnTriggerEnter (Collider other) {
		print ("trigger");
		if(other.gameObject.tag =="rocket"){
			print ("rocket");
			if (ammoAdd != null) {
				print ("not null");
				ammoAdd();
				Destroy (other.gameObject ); 
			}
		}
	
	}
}
