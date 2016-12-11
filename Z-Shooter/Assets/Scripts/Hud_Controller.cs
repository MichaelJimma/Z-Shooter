/*
 * Ramzi Haddad -100885168
 * Michael Jimma -100963147
*/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Hud_Controller : MonoBehaviour {

	[SerializeField] Text Points = null;// to capture the points label
	[SerializeField] Text health = null;//to caputure the health label


	void Start()
	{
		Player.Instance.myhud = this;
	}

	void Update (){

	}

	public void updatePoints(){
		Points.text = "Points :" + Player.Instance.points;
	}
	public void updateHealth(){
	

		health.text="Health :"+Player.Instance.healthpoints;
	}








}
