using UnityEngine;
using System.Collections;

public class PowerUpBase : MonoBehaviour {

	public int powerHealth;

		


	void OnTriggerEnter(){
		Debug.Log ("You gained" + powerHealth + " in health!");
		if (HealthScript.health < 100) {
			HealthScript.health += powerHealth; 
		}

		//Destroy (gameObject); 
		gameObject.SetActive (false); 
	}

}
