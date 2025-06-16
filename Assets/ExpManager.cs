using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ExpManager : MonoBehaviour
{
    public static ExpManager _main;

    [Header("Atteributes")]
    public int _exp = 0;

    private void Awake() => _main = this;
}
