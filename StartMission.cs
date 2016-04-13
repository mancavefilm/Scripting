using UnityEngine;
using System.Collections;

public class StartMission : MonoBehaviour {

	public void LoadScene(int level)
	{
		Application .LoadLevel(level);
	}
}
