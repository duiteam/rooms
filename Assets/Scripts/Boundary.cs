using UnityEngine;
using UnityEngine.SceneManagement;

public class Boundary : MonoBehaviour
{
    public string sceneName; // Ҫ���¼��صĳ�������

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
