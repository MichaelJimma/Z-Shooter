/*
 * Ramzi Haddad -100885168
 * Michael Jimma -100963147
*/
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerCollider : MonoBehaviour {
	private Animator playerAnimator = null;

	void OnCollisionEnter2D(Collision2D other)
	{

		playerAnimator = gameObject.GetComponent<Animator> ();

		if (other.gameObject.tag == "Enemy1" || other.gameObject.tag == "Enemy2" || other.gameObject.tag == "Enemy3" || other.gameObject.tag == "Enemy4" || other.gameObject.tag == "Enemy5"|| other.gameObject.tag == "DeathLand") {
			playerAnimator.SetBool ("isDead",true);
			Player.Instance.isDead = true;
			// this code is to load the gameover scene
			SceneManager.LoadScene(2);
		}
		if(other.gameObject.tag=="Ground"){
			playerAnimator.SetBool ("onGround", true);
		}

		
		}
}
