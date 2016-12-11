/*
 * Ramzi Haddad -100885168
 * Michael Jimma -100963147
*/

using UnityEngine;
using System.Collections;
using System.Threading;

public class BulletCollider : MonoBehaviour {
	// to assign the enemy creation positions
	public GameObject Position1;
	public GameObject Position2;
	public GameObject Position3;
	public GameObject Position4;
	public GameObject Position5;
	// to create the  Correct enemy in correct place
	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject enemy4;
	public GameObject enemy5;

	void OnCollisionEnter2D(Collision2D other)
	{
		
		Player.Instance.points += 10;
	

		// to create the new instance of enemy with respect to there location 
		if (other.gameObject.tag == "Enemy1") {
			Destroy (other.gameObject);
			Destroy (gameObject);
			GameObject enemy = (GameObject)Instantiate (enemy1);//to creat the Enemy 
			enemy.transform.position = Position1.transform.position;//keep the Enemy in the correct place
		}
		if (other.gameObject.tag == "Enemy2") {
			Destroy (other.gameObject);
			Destroy (gameObject);
			GameObject enemy = (GameObject)Instantiate (enemy2);//to creat the Enemy 
			enemy.transform.position = Position2.transform.position;//keep the Enemy in the correct place

		}
		if (other.gameObject.tag == "Enemy3") {
			Destroy (other.gameObject);
			Destroy (gameObject);
			GameObject enemy = (GameObject)Instantiate (enemy3);//to creat the Enemy 
			enemy.transform.position = Position3.transform.position;//keep the Enemy in the correct place

		}
		if (other.gameObject.tag == "Enemy4") {
			Destroy (other.gameObject);
			Destroy (gameObject);
			GameObject enemy = (GameObject)Instantiate (enemy4);//to creat the Enemy 
			enemy.transform.position = Position4.transform.position;//keep the Enemy in the correct place

		}
		if (other.gameObject.tag == "Enemy5") {
			Destroy (other.gameObject);
			Destroy (gameObject);
			GameObject enemy = (GameObject)Instantiate (enemy5);//to creat the Enemy 
			enemy.transform.position = Position5.transform.position;//keep the Enemy in the correct place

		}
		if (other.gameObject.tag == "verticalBoundry") {
			Destroy (gameObject);

		}
			
	
			
	}// end of the collision function
}
