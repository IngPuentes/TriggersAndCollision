using UnityEngine;
using System.Collections;

public class OnCollider : MonoBehaviour {
	public float haveforce= 12f;
	
	void OnCollisionEnter(Collision collider){
		Debug.Log ("enter Collision");
	}
	void OnCollisionStay(Collision collider){
		Debug.Log ("Stay Collision");
	}
	void OnCollisionExit(Collision collider){
		Debug.Log ("Exit Collision");
	}
	
	void OnTriggerEnter(Collider collider){
		Debug.Log ("enter Collider");
	}
	void OnTriggerStay(Collider collider){
		collider.rigidbody.AddForce (Vector3.up * haveforce, ForceMode.Acceleration);
		Debug.Log ("Stay Collider");
	}
	void OnTriggerExit(Collider collider){
		Debug.Log ("Exit Collider");
	}
}