using UnityEngine;
using System.Collections;

public class BulletForce : MonoBehaviour {

	public int bulletSpeed;
	private Rigidbody rB;
	//this is the respawnpoint
	public GameObject startLoc;
	private MeshRenderer onOff;
	public Vector3 force;


	// Use this for initialization
	void Start () {
		rB = GetComponent <Rigidbody > ();
		//this gets the meshrenderer component
		onOff = gameObject.GetComponent<MeshRenderer> ();  
		//this turns off the bullets on gamestart
		onOff.enabled = false;
		//this sets the position of the bullets to that of the gameobject respawn
		startLoc.transform.position= transform.position; 

	}


	public void Fire () {
		//this turns on the Meshrenderer

			onOff.enabled = true; 
			force = bulletSpeed * transform.forward; 
			rB.AddForce (force); 


	}

	public void Reload(){
		//this will stop all force on the rB
		rB.velocity  = Vector3.zero ; 
		rB.Sleep();
		//this sets the position and rotation for the bullet so it moves with the ship
		transform.position = startLoc.transform.position; 
		transform.rotation = startLoc.transform.rotation;   

	}
}

