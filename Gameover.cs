using UnityEngine;
using System.Collections;

public class Gameover : MonoBehaviour {

	public GameObject player;
	private ShipHealth health;
	public float gameOver=1;
	Animator anim;
	public GameObject endGame;
	public float speed = 20;

	
	// Use this for initialization
	//call animator
	//call playerscript

	void Start () {
		anim = GetComponent<Animator> ();
		health = player .GetComponent<ShipHealth>  (); 
	}
	
	// Update is called once per frame
	void Update () {


		//checks to see if player is not destroyed
		if (player!=null) {
			
			gameOver = 1;
			anim.SetFloat ("GameDone", Mathf.Abs (gameOver));
		}
		//checks to see if player is destroyed
		else if( player==null)
		{
			gameOver = 0;
			anim.SetFloat("GameDone", Mathf.Abs (gameOver)); 
			Debug .Log ("GAMEOVER");

			endGame.SetActive(true);
		}
	}
}
