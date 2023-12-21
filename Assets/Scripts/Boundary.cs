using UnityEngine;
using UnityEngine.SceneManagement;

public class Boundary : MonoBehaviour
{
    public string sceneName; // 要重新加载的场景名称

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ReloadScene();
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
