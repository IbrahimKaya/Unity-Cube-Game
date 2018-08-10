using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public float restartDelay = 15;

    public GameObject completeLevelUI;
    public GameObject wastedUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public  void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            wastedUI.SetActive(true);
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }

        

    }

    void Restart()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
