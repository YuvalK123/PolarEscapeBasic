using UnityEngine;

public class EndTrigger : MonoBehaviour {

	public GameManager gameManager;

	void OnTriggerEnter (Collider other)
	{
        Debug.Log("message from" + this.gameObject.name);
        Debug.Log("colided with " + other.gameObject.name);
		gameManager.CompleteLevel(other.gameObject);
	}

}
