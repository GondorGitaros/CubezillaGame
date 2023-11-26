using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool GameHasEnded = false;
    public float TimeInSeconds = 1.5f;
    public GameObject CompleteLevelUI;
    public void Won()
    {
        CompleteLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("JÁTÉK VÉGE");
            Invoke("Restart", TimeInSeconds);
        }

    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
