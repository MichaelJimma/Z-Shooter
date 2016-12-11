/*
 * Ramzi Haddad -100885168
 * Michael Jimma -100963147
*/
using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {
	[SerializeField] 
	float speed;
	private int direction=0;// to assign the direction


	// Use this for initialization
	void Start () {
	
		direction = Player.Instance.playerdirection;// to keep the direction of the bullet when it first fired


	}
	
	// Update is called once per frame
	void Update () {

		//


		// this for the cuurrent positon of the bullet
		Vector2 position = transform.position;



		//for the new position of the bullet
		if (direction == 1) {
			position = new Vector2 (position.x + speed * Time.deltaTime, position.y);

		} else {
			position = new Vector2 (position.x - speed * Time.deltaTime, position.y);
		}
		transform.position = position;// to assign the new location
}
}
