using UnityEngine;
using System.Collections;

public class Player : Character {
	public float speed = 1.0f;

	void Update () {

		Vector3 moveVector = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		if (moveVector.magnitude > 0.01f) {
		
			transform.position += moveVector * speed * Time.deltaTime;

			//transform.rotation = Quaternion.Euler (new Vector3 (transform.rotation.x, transform.rotation.y, (Mathf.Atan (moveVector.y / moveVector.x)) * Mathf.Rad2Deg));

		}


	}
}
