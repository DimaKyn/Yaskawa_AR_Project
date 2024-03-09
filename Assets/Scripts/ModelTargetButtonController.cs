#if UNITY_EDITOR
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
  public int sceneToLoad; // Public variable to set the scene index in Inspector

  public void LoadScene()
  {
    SceneManager.LoadScene(sceneToLoad);
  }
}
#endif