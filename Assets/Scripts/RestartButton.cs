using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SetActive()
    {
        _button.gameObject.SetActive(true);
    }
}
