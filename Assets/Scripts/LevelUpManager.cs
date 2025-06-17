using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpManager : MonoBehaviour
{
    public static LevelUpManager _main;

    private void Awake() => _main = this;

    public int _bulletDamageScale = 2;
}
