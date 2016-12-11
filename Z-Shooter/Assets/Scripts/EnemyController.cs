/*
 * Ramzi Haddad -100885168
 * Michael Jimma -100963147
*/
using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	[SerializeField]
	private Vector2 speed;
	private Transform EnemyTransform;
	private Vector2 Enemyposition;
	public int Direction =1;
	public EnemyCollision Collision = null;



	// Use this for initialization
	void Start () {
		Collision = gameObject.GetComponent<EnemyCollision> ();
		EnemyTransform = gameObject.GetComponent<Transform>();
		Enemyposition = EnemyTransform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Direction = Collision.direction;
		Enemyposition = EnemyTransform.position;
		gameObject.transform.localScale = new Vector3 (Direction*(float)6.41, (float)4.90, 1);//the casting of number is to keep the original size of the player
		Vector2 Enemyspeed = new Vector2 (speed.x*Direction, speed.y);// to make the enemy moves
		Enemyposition -= Enemyspeed;
		EnemyTransform.position = Enemyposition;



	}


}
