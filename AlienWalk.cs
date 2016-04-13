using UnityEngine;
using System.Collections;

public class AlienWalk : MonoBehaviour {

	public float Speed =2;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis ("Horizontal")* Speed, Input.GetAxis ("Vertical")* Speed);

		anim.SetFloat ("HS", Mathf.Abs (GetComponent<Rigidbody2D>().velocity.x));


	}
}
