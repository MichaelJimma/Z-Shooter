/*
 * Ramzi Haddad -100885168
 * Michael Jimma -100963147
*/
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SwitchScenes : MonoBehaviour {
	

	public void StartScene(){
		SceneManager.UnloadScene (1);
		SceneManager.LoadScene (1);




	}


}
