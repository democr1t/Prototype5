using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField] private float _period;
    [SerializeField] private List<ClickableTarget> _prefabs;
    [SerializeField] private Score _score;
    private int _randomIndex;
    private bool _isPlaying = true;

    void Start()
    {
        StartCoroutine(nameof(Spawn));
    }
    
    private IEnumerator Spawn()
    {
        while(_isPlaying)
        { 
            yield return new WaitForSeconds(_period);
            _randomIndex = Random.Range(0, _prefabs.Count);
            var target = Instantiate(_prefabs[_randomIndex]);
            target.TargetClicked.AddListener(_score.Renew);
        }
    }
}
