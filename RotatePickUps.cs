using UnityEngine;
using System.Collections;

public class RotatePickUps : MonoBehaviour {

	public Transform [] pickups;

	void Update(){
		foreach (Transform sphere in pickups) {
			sphere.Rotate (5,6,2);
		}
	}
}
