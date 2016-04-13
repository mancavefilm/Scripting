using UnityEngine;
using System.Collections;

public class WeaponBullets : MonoBehaviour {

	//calls on this class

	public BulletForce[] bullets;
	private int i = 0;
	private int restartBullets=0;
	public int basicBullet= 30;

	void FireBullets(){

		bullets[i].Reload ();
		bullets [i].Fire ();

		if (i < bullets.Length - 1) {
			i++;

		} else {
			i = restartBullets; 
		}
		 
	}

	void Update (){
		//checks to see if there are any bullets
		if(basicBullet >1){

			if (Input.GetKeyUp ("space")){ 
				FireBullets ();
				//this minuses the bullets from the basicbullet 
				basicBullet --;
			} 
		}

			
			
		
	}
}
