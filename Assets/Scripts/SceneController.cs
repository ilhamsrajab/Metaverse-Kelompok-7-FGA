using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
  public CanvasGroup Konten;
  public CanvasGroup Black;
  public float Delay = 5;
  public Vector3 sizeZoom;
  private void Start()
  {
    Konten.alpha = 0;
    Black.alpha = 0;
    Black.transform.localScale = new Vector2(Screen.width, Screen.height);
  }

  public void PindahScene()
  {
    SceneManager.LoadScene(1);
    // Debug.Log("pindah scene");
  }

  private void Update()
  {
    Konten.transform.localScale += sizeZoom * Time.deltaTime;
    if (Konten.alpha >= 0)
    {
      Konten.alpha += Time.deltaTime;
      Delay -= Time.deltaTime;
      // Debug.Log(Delay);

      if (Konten.alpha >= 1 && Delay <= 0)
      {
        if (Black.alpha >= 0)
        {
          Black.alpha += Time.deltaTime;
          if (Black.alpha >= 1)
          {
            PindahScene();
          }
        }
      }
    }
  }
}
