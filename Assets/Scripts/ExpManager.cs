using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ExpManager : MonoBehaviour
{
    public static ExpManager _main;

    [Header("Atteributes")]
    private int _exp;
    public int Exp
    {
        get { return _exp; }
        set
        {
            _exp = value;
            CheckExp();
        }
    }
    public int _levelIndex = 0;
    public int _maxLevel = 10;

    public int _requiredExp = 0;
    public List<int> _requiredExpList = new();
    private void Awake()
    {
        _main = this;
        _requiredExpList.Add(0);
        for (int i = 1; i <= _maxLevel; i++)
        {
            _requiredExpList.Add(GetLevelUpRequireExp(i));
        }
        _requiredExp = _requiredExpList[1] - _requiredExpList[0];
    }

    private void CheckExp()
    {
        if (_exp >= _requiredExpList[_levelIndex+1])
        {
            _levelIndex++;
            _requiredExp = _requiredExpList[_levelIndex+1] - _requiredExpList[_levelIndex] + 1;
        }
    }
    
    ///<summary>
    /// 경험치 수식은 초기값 + (회차-1*회차) / 2 라는 공식을 사용
    ///</summary>
    private int GetLevelUpRequireExp(int _startExp)
    {
        return _startExp * (_startExp - 1) / 2 + 2 * _startExp;
    }
}
