using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jopa : MonoBehaviour
{
void OnTriggerEnter (Collider other) 
	{
		if (other.gameObject.tag == "Player")
			SceneManager.LoadScene ("SCENE inside 1");
	}
}