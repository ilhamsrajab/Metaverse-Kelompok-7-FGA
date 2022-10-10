using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayController : MonoBehaviour
{
  public void Home()
  {
    Debug.Log("Menuju scene MainMenu");
    SceneManager.LoadScene("MainMenu");
  }
}
