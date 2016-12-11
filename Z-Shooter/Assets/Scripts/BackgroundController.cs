/*
 * Ramzi Haddad -100885168
 * Michael Jimma -100963147
*/
using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		AudioSource Background = gameObject.GetComponent<AudioSource> ();
		Background.Play ();// to play the background sound


	}
	
	// Update is called once per frame
	void Update () {
	}







}
