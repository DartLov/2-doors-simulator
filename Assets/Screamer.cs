using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screamer : MonoBehaviour
{
    public GameObject videoPlayer;
	public int timeToStop;
	
	void start() {
		videoPlayer.SetActive(false);
}

void OnTriggerEnter (Collider player) {
	
	if (player.gameObject.tag == "Player")
	{
		videoPlayer.SetActive(true);
		Destroy(videoPlayer, timeToStop);
	}
}
}
