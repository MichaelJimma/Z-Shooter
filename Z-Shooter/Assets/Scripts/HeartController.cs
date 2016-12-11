/*
 * Ramzi Haddad -100885168
 * Michael Jimma -100963147
*/
using UnityEngine;
using System.Collections;

public class HeartController : MonoBehaviour
{

	private Transform hearTransform;
	private Vector2 heartPosition;
	private int Selector;

	public GameObject Position1;
	public GameObject Position2;
	public GameObject Position3;
	public GameObject Position4;
	public GameObject Position5;
	public GameObject Position6;
	public GameObject Position7;
	public GameObject Position8;
	public GameObject Position9;

	// Use this for initialization
	void Start ()
	{
		hearTransform = gameObject.GetComponent<Transform> ();
		heartPosition = hearTransform.position;
		StartCoroutine ("Replace");
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void Reset ()// to use with colliction with player
	{
		Selector = Random.Range (1, 10);
		Debug.Log ("" + Selector);
		switch (Selector) {
		case 1:
			heartPosition = Position1.transform.position;
			hearTransform.position = heartPosition;
			break;
		case 2:
			heartPosition = Position2.transform.position;
			hearTransform.position = heartPosition;
			break;
		case 3:
			heartPosition = Position3.transform.position;
			hearTransform.position = heartPosition;
			break;
		case 4:
			heartPosition = Position4.transform.position;
			hearTransform.position = heartPosition;
			break;
		case 5:
			heartPosition = Position5.transform.position;
			hearTransform.position = heartPosition;
			break;
		case 6:
			heartPosition = Position6.transform.position;
			hearTransform.position = heartPosition;
			break;
		case 7:
			heartPosition = Position7.transform.position;
			hearTransform.position = heartPosition;
			break;
		case 8:
			heartPosition = Position8.transform.position;
			hearTransform.position = heartPosition;
			break;
		case 9:
			heartPosition = Position9.transform.position;
			hearTransform.position = heartPosition;
			break;
		}


	}
// to keep time gap betwwen changing the heart ploace

	private IEnumerator Replace ()// to keep changing the healthkit every while
	{
		while(Player.Instance.healthpoints>0)
		{
			yield return new WaitForSeconds (5f);
			Player.Instance.healthpoints -= 5;//reduces the player life and force the player to catch more heathkits
			//to select a position
			Selector = Random.Range (1, 10);
			Debug.Log ("" + Selector);
			switch (Selector) {
			case 1:
				heartPosition = Position1.transform.position;
				hearTransform.position = heartPosition;

				break;
			case 2:
				heartPosition = Position2.transform.position;
				hearTransform.position = heartPosition;

				break;
			case 3:
				heartPosition = Position3.transform.position;
				hearTransform.position = heartPosition;

				break;
			case 4:
				heartPosition = Position4.transform.position;
				hearTransform.position = heartPosition;

				break;
			case 5:
				heartPosition = Position5.transform.position;
				hearTransform.position = heartPosition;

				break;
			case 6:
				heartPosition = Position6.transform.position;
				hearTransform.position = heartPosition;
			
				break;
			case 7:
				heartPosition = Position7.transform.position;
				hearTransform.position = heartPosition;

				break;
			case 8:
				heartPosition = Position8.transform.position;
				hearTransform.position = heartPosition;
				yield return new WaitForSeconds (5f);
				break;
			case 9:
				heartPosition = Position9.transform.position;
				hearTransform.position = heartPosition;
				break;
			}

			//--
				
	
	
			}


	}
}






