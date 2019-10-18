using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;
    GameObject winner;
	public float restartDelay = 1f;

	public GameObject completeLevelUIPlayer1;
    public GameObject completeLevelUIPlayer2;

	public void CompleteLevel (GameObject player)
	{
        if (player.name=="Player01")
        {
		    completeLevelUIPlayer1.SetActive(true);
        }
        else
        {
            completeLevelUIPlayer2.SetActive(true);
        }
	}

	public void EndGame ()
	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			Debug.Log("GAME OVER");
			Invoke("Restart", restartDelay);
		}
	}

	void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
