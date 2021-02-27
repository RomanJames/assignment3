using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
   void OnTriggerEnter2D ()
    {
        Debug.Log("You Won!");
        Score.CurrentScore += 100;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        if (Score.CurrentScore >= 200)
        {
            SceneManager.LoadScene("Credits");
        }
    }

  

}
