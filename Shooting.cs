using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public Rigidbody2D projectile;
	
	public float speed = 20;
	public AudioClip shootSound;

	private AudioSource source;
	private float volLowRange = .5f;
	private float volHiRange = 1.0f;
	
	// Use this for initialization
	void Awake () {
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (Input.GetKeyDown(KeyCode.K))
		{
			source.PlayOneShot (shootSound, 1F);

			Rigidbody2D instantiatedProjectile = Instantiate(projectile,transform.position,transform.rotation)
				as Rigidbody2D;
			
			instantiatedProjectile.velocity = transform.TransformDirection(new Vector2(speed,0));

		}
	}
}
