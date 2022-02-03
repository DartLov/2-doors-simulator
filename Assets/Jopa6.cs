using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jopa6 : MonoBehaviour
{
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player")
			SceneManager.LoadScene ("SCENE gachi 1");
	}
}