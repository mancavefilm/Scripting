using UnityEngine;
using System.Collections;

public class RocketAdd : MonoBehaviour {

	public int rocketRefill=10;
	public int endThis=1;



	void OnEnable(){
		WeaponsBase.ammoAdd += AddRockets; 

	}

	void OnDisable(){
		WeaponsBase.ammoAdd -= AddRockets;  
	}




	void AddRockets(){
		
		WeaponArmary.rockets += rocketRefill;
		print ("10 Rockets added");

	}
	
}
