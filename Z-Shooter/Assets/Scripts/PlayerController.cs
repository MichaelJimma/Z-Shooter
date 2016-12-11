/*
 * Ramzi Haddad -100885168
 * Michael Jimma -100963147
*/
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

	[SerializeField]
	private float force = 1f;
// the amount of input force
	[SerializeField]
	//private float jump = 30;// the force to add in jumping

	private Rigidbody2D Player_rigidBody;
	// to assign the rigid body of the player
	// Use this for initialization
	private Animator playerAnimator = null;
	//for bullets and bullets sounds and animations

	public GameObject Bullet;
//this is the bullet prefab
	public GameObject BulletPosition;
	public GameObject BulletAnimation;
// to create the shoot animation
	public GameObject AnimationPosition;






	void Start ()
	{
		// to assign the rigid body
		Player_rigidBody = gameObject.GetComponent<Rigidbody2D> ();
		playerAnimator = gameObject.GetComponent<Animator> ();
		Player.Instance.healthpoints = 100;
		Player.Instance.points = 0;
		Player.Instance.isDead = false;


	}

	// Update is called once per frame
	void FixedUpdate ()
	{

		if (Player.Instance.healthpoints <= 0)// to go to the endgame if life equals zero
			SceneManager.LoadScene (2);


		float jump = Input.GetAxis ("Jump");
		//------------------------If player is still alive
		if (Player.Instance.isDead == false) {
			//---to create the bullets
			if (Input.GetKeyDown (KeyCode.Space)) {
				AudioSource BulletMusica = gameObject.GetComponent<AudioSource> ();
				BulletMusica.Play ();// to play the firing sound
				GameObject bullet = (GameObject)Instantiate (Bullet);//to creat the bullet 
				bullet.transform.position = BulletPosition.transform.position;//keep the bullet in the correct place
				GameObject Animate = (GameObject)Instantiate (BulletAnimation);//to creat the animation 
				Animate.transform.position = AnimationPosition.transform.position;//keep the animation in the correct place

			}
			//-- end of shooting

			// to keep of the player direction
			if (Player_rigidBody.velocity.x < 0) {
		
				Player.Instance.playerdirection = -1;
			} else {
				Player.Instance.playerdirection = 1;
			}


			if (jump > 0) {

				Player_rigidBody.AddForce (Vector2.up * 30);
				playerAnimator.SetBool ("onGround", false);
			}
			playerAnimator.SetInteger ("soldierSpeed", (int)(Player_rigidBody.velocity.x) * 10000);// to check if the player is moving or standing

			Player_rigidBody.velocity = new Vector2(Input.GetAxis ("Horizontal")*force , Player_rigidBody.velocity.y);


	
	//to flip the player directon and keep the same size
			if (Player_rigidBody.velocity.x < 0)
				gameObject.transform.localScale = new Vector3 (-(float)0.41, (float)0.39, 1);//the casting of number is to keep the original size of the player
		else
				gameObject.transform.localScale = new Vector3 ((float)0.41, (float)0.39, (float)1);//the casting of number is to keep the original size of the player
			//-------------------------- End fo alive functions
		} else {
		
			SceneManager.LoadScene (2);

		
		}



	}
}
