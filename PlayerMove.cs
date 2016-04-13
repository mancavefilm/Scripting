using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {


	private CharacterController ship;
	private Vector3 moveShip;
	public float shipSpeed = 5;
	public float turnSpeed =2;

	// Use this for initialization
	void Start () {
		ship = GetComponent<CharacterController> ();

	
	}
	
	// Update is called once per frame
	void Update () {
		ShipMove (Input.GetAxis("Vertical"));
		PlayerTurn (Input.GetAxis ("Horizontal"));  

	}

	void ShipMove(float _playerInput)
	{
		moveShip.z = _playerInput;
		moveShip = transform.TransformDirection (moveShip * shipSpeed * Time.deltaTime);
		ship.Move (moveShip);
	}

	void PlayerTurn(float _playerinput)
	{
		transform.Rotate (0, _playerinput * turnSpeed, 0); 

	}
}
