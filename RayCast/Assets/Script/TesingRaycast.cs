using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesingRaycast : MonoBehaviour {
	public float distance = 3.3f;
	LineRenderer lr;
	void FixedUpdate () {
		Ray ray = new Ray (transform.position, transform.forward);
		Debug.DrawLine (transform.position, transform.position + transform.forward*distance, Color.red);

		lr = gameObject.GetComponent<LineRenderer>();
		lr.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
		lr.SetColors(Color.blue, Color.blue);
		lr.SetWidth(0.01f, 0.01f);
		lr.SetPosition(0, transform.position);
		lr.SetPosition(1, transform.position + transform.forward*distance);
		lr.enabled = true;
		/*RaycastHit hit;
		if (Physics.Raycast (ray, out hit, distance)) {
			Debug.DrawLine (hit.point, hit.point + hit.transform.up, Color.green);
		}*/
		RaycastHit[] hits = Physics.RaycastAll(ray, distance);
		foreach (RaycastHit hit in hits) {
			//hit.transform.rotation = Quaternion.Euler(0, 0, 0);

			LineRenderer lr2;
			lr2 = hit.transform.gameObject.GetComponent<LineRenderer>();
			lr2.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
			lr2.SetColors(Color.blue, Color.blue);
			lr2.SetWidth(0.01f, 0.01f);
			lr2.SetPosition(0, hit.point);
			lr2.SetPosition(1, hit.point + hit.transform.up);
			lr2.enabled = true;
			Debug.DrawLine (hit.point, hit.point + hit.transform.up, Color.green);
		}
	}
}
