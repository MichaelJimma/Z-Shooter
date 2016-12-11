/*
 * Ramzi Haddad -100885168
 * Michael Jimma -100963147
*/
using UnityEngine;
using System.Collections;

public class Player
{

	private static Player instance = null;
	// to create the Player object contstant all over the game
	public static Player Instance {
		get { 
		
			if (instance == null) {
			
				instance = new Player ();

			}
			return instance;
		}
	}
	public Hud_Controller myhud=null;// to assign the hud





	// to keep track of health
	private int healtPoints = 100;

	public int healthpoints {
		get{return healtPoints;}
		set{healtPoints = value;
			myhud.updateHealth ();}
	}
	// to keep track of the player points
	private int Points = 0;
	public int points{
		get{ return Points;}
		set{ Points = value;
			myhud.updatePoints ();
		}
	}

	private int PlayerDirection = 0;// to keep track of the player for the traform purpose
	public int playerdirection{
		set{PlayerDirection = value; }
		get{return PlayerDirection; }
	}
	private bool IsDead = false;// to change the game scene and for the Dead State in the PlayerController as
	// well as the state of the player
	public bool isDead{
		set{IsDead = value; }
		get{return IsDead; }
	}










}