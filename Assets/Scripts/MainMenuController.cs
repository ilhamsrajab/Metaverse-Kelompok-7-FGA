using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
  public GameObject PanelAbout;
  public void Main()
  {
    Debug.Log("Menuju scene Gameplay");
    SceneManager.LoadScene("Gameplay");
  }
  public void TentangKami()
  {
    PanelAbout.SetActive(true);
  }
  public void CloseTentangKami()
  {
    PanelAbout.SetActive(false);
  }
  public void Keluar()
  {
#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
#endif

    Application.Quit();
  }
}
