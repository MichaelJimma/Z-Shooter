/*
 * Ramzi Haddad -100885168
 * Michael Jimma -100963147
*/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {

	public Text Highscore=null;

	void Start(){
	
		Highscore.text = "Score is :" + Player.Instance.points;
	}




}
