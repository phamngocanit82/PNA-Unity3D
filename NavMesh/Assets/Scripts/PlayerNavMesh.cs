using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PlayerNavMesh : MonoBehaviour {
	public Camera camera;
	public NavMeshAgent navMeshAgent;
	void Start(){
		camera = Camera.main;
		navMeshAgent = GetComponent<NavMeshAgent> ();
	}
	void Update(){
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit raycastHit;
			if (Physics.Raycast (ray, out raycastHit)) {
				navMeshAgent.enabled = true;
				navMeshAgent.SetDestination (raycastHit.point);
			}
		}
	}
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Enemy") {
			navMeshAgent.enabled = false;
		}
	}
}
