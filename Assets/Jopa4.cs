using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jopa4 : MonoBehaviour
{
void OnTriggerEnter (Collider other) 
	{
	SceneManager.LoadScene ("SCENE inside 2");
}
}