using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager _main;

    public int _score = 0;

    private void Awake() => _main = this;
}
