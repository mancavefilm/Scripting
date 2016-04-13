using UnityEngine;
using System.Collections;

public class StarDeathPoints : MonoBehaviour {

	public float lifeTime=4;
	public bool dead=false;
	public int scoreValue=100;


	

	
	void Start()
	{
		Destroy (gameObject, lifeTime);
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") 
		{
			
			dead =true;
			//adds score value to GUI score
			ScorePoints.score += scoreValue; 
			Destroy (gameObject);
			
		}
		
		else 
		{

		}
	}
}
