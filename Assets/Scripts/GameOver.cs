using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _gameOverText;
    [SerializeField] private RestartButton _restartButton;
    [SerializeField] private TargetSpawner _targetSpawner;
    public void End()
    {
       _gameOverText.gameObject.SetActive(true);
       _restartButton.SetActive();
       _targetSpawner.StopPlaying();
    }
}
