using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jopa2 : MonoBehaviour
{
void OnTriggerEnter (Collider other) 
	{
	SceneManager.LoadScene ("SCENE main 1");
}
}