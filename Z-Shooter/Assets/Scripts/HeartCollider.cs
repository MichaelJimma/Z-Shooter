/*
 * Ramzi Haddad -100885168
 * Michael Jimma -100963147
*/
using UnityEngine;
using System.Collections;

public class HeartCollider : MonoBehaviour {

	public HeartController control=null;

	void OnTriggerEnter2D(Collider2D other)
	{

		control = gameObject.GetComponent<HeartController> ();



		if (other.gameObject.tag == "Player") {
			control.Reset ();
			Player.Instance.points += 5;
			if (Player.Instance.healthpoints <= 95) {
				Player.Instance.healthpoints += 5;

			}

		}

	}


}
