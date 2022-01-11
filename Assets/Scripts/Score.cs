using System;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Text;
    private int _count;

    public void Renew()
    {
        _count++;
        Text.text = "Score: " + _count;
    }
}
