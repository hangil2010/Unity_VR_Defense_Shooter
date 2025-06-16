using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] TextMeshProUGUI _killCountText;
    [SerializeField] TextMeshProUGUI _expText;
    [SerializeField] TextMeshProUGUI _nextLevelupRequireText;

    /// <summary>
    /// OnGUI is called for rendering and handling GUI events.
    /// This function can be called multiple times per frame (one call per event).
    /// </summary>
    private void OnGUI()
    {
        _killCountText.text = ScoreManager._main._score.ToString();
        _expText.text = (ExpManager._main._levelIndex + 1).ToString();
        _nextLevelupRequireText.text = ExpManager._main._requiredExp.ToString();
    }
}
