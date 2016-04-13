using UnityEngine;
using UnityEngine.UI;  
using System.Collections;

public class HealthScript : MonoBehaviour {

	public static int health=50;
	Text text;
	public int maxHealth = 100;
	
	void Awake(){
		text = GetComponent <Text> ();
		health = 50 ;
	}
	void Update(){
		text.text = "Health:" + health  ;
		if (health > 100) {
			health= maxHealth; 
		}
		
		
	}
	
}
