using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jopa5 : MonoBehaviour
{
void OnTriggerEnter (Collider other) 
	{
	SceneManager.LoadScene ("SCENE gachi 2");
}
}