/* Stephen Randall
 * 03/16/18
 * This script is responsible for ball, putting ball in play, etc.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public float ballInitialVelocity = 600f; // Sets balls velocity
	private Rigidbody rb; 
	private bool BallInPlay; // Flag for when the ball is in play.


	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody> (); // Makes it a rigidbody


	}
	void Update (){
		Debug.Log ("Enter Update");
		if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began)){
			Debug.Log ("Touched");
			//Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			//RaycastHit raycastHit = new RaycastHit();
			//if (Physics.Raycast (raycast, out raycastHit)) {
				//transform.LookAt (raycastHit.point);
				//rb.AddRelativeForce(Vector3.forward* 100);
				//Serve();
			}



		}

	// Update is called once per frame
	 void Serve () {
		
			transform.parent = null;
			BallInPlay = true;
			rb.isKinematic = false;
			rb.AddForce(new Vector3(-ballInitialVelocity, ballInitialVelocity, 0));
			
		}
	}


	