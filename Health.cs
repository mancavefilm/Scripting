using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float lifeTime=4;
	public bool dead=false;
	public int scoreValue=10;
	//public GameObject gameController;



	void Start()
	{
		Destroy (gameObject, lifeTime);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Lazer") 
		{

			dead =true;
			ScorePoints.score += scoreValue; 
			Destroy (gameObject);
			
		}
			
		else if (col.gameObject.tag == "Player")
			Destroy (gameObject);
	}

}
	


