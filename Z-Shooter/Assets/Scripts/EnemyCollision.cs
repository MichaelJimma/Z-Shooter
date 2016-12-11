/*
 * Ramzi Haddad -100885168
 * Michael Jimma -100963147
*/
using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour {


	public EnemyController enemyController= null;

	public int direction=1;


	void Start () {

		enemyController = gameObject.GetComponent<EnemyController> ();
	}

	void OnCollisionEnter2D(Collision2D other)
	{


		if(other.gameObject.tag=="verticalBoundry"||other.gameObject.tag=="enemyBoundry"){
	//	enemyController.Direction *= -1;
			direction *= -1;
	
		}



	}

}


