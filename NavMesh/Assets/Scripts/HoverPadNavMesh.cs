using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HoverPadNavMesh : MonoBehaviour {
	public float hoverForce = 12f;
	void OnTriggerStay(Collider other){
		if(other.gameObject.tag!="Player")
			other.attachedRigidbody.AddForce (Vector3.up*hoverForce, ForceMode.Acceleration );
	}
}
