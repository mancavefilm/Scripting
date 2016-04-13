using UnityEngine;
using System.Collections;

public class PowerDeath : MonoBehaviour {




	public float lifeTime=4;
	public bool dead=false;

	public GameObject gameController;

	void Start()
	{

		Destroy (gameObject, lifeTime);

	}
	
	void OnTriggerEnter2D(Collider2D hit)
	{

		if (hit.gameObject.tag == "Player" ) 
		{  

			dead =true;
			Destroy (gameObject);
		}
		
		else
		{

		}
	}
	
}

