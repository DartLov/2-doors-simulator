using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player")
			SceneManager.LoadScene ("SCENE gachi 1");
		if (other.gameObject.tag == "Death")
			Destroy(other.gameObject);
	}
}