using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
   private Transform _player;
   public float dist;
   NavMeshAgent nav;
   public float Radius = 30;
   public void Init(Transform player)
   {
	   _player = player;
	   nav = GetComponent<NavMeshAgent> ();
   }
   
   void Update () {
	   dist = Vector3.Distance(_player.position, transform.position);
	   if(dist > Radius){
		   nav.enabled = false;
	   }
	   if (dist < Radius) {
		   nav.enabled = true;
		   //nav.SetDestination(player.transform.position);
	   }
   }
   private void OnCollisionEnter(Collision other) {
	   nav.enabled = true;
	   StopCoroutine(RePath());
	   StartCoroutine(RePath());
   }
   private IEnumerator RePath()
   {
	   while (true)
	   {
			var velocity = nav.velocity;
			nav.Warp(transform.position);
			nav.SetDestination(_player.position);
			nav.velocity = velocity;
			yield return new WaitForSeconds(1);
	   }
   }
}