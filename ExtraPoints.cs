using UnityEngine;
using System.Collections;

public class ExtraPoints : MonoBehaviour {

	public Rigidbody2D projectile;
	public float speed= 10;
	public float enemy = 1000;
	public float countUp =0;
	float timer;
	
	void Start()
	{
		timer = 0;
	}
	
	void Update()
	{
		timer += Time.deltaTime;
		
		
		
		if ((timer > 15.0f)&&(countUp<=1000))
		{
			Rigidbody2D instantiatedProjectile = Instantiate(projectile,transform.position,transform.rotation)
				as Rigidbody2D;
			
			instantiatedProjectile.velocity = transform.TransformDirection(new Vector2(speed,0));
			countUp++;
			timer = 0;
		}
		
		
		
	}
}
