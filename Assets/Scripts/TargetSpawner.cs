using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField] private float _period;
    [SerializeField] private List<ClickableTarget> _prefabs;
    [SerializeField] private Score _score;
    [SerializeField] private GameOver _gameOver;
    private int _randomIndex;
    public bool IsPlaying { get; private set; }

    
    void Start()
    {
        IsPlaying = true;
        StartCoroutine(nameof(Spawn));
    }
    
    private IEnumerator Spawn()
    {
        while(IsPlaying)
        { 
            yield return new WaitForSeconds(_period);
            _randomIndex = Random.Range(0, _prefabs.Count);
            var target = Instantiate(_prefabs[_randomIndex]);
            target.GoodTargetClicked.AddListener(_score.Renew);
            target.BadTargetClicked.AddListener(_gameOver.End);
        }
    }

    public void StopPlaying()
    {
        IsPlaying = false;
    }
}
