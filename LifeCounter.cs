using UnityEngine;
using System.Collections;

public class LifeCounter : MonoBehaviour {

	public GameObject player;
	private ShipHealth health;
	public float livesM =6;
	public float meter;
	Animator anim;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		health = player .GetComponent<ShipHealth>  (); 
	}
	
	// Update is called once per frame
	void Update () 
	{
		

	    meter = health.hP; 
		if (player!=null) 
		{
			livesM = meter + 1;
			anim.SetFloat ("lives", Mathf.Abs (livesM));
		} 
		else if (player==null) 
		{
			livesM = 0;
			anim.SetFloat ("lives", Mathf.Abs (livesM));
	
		}
	}
}





