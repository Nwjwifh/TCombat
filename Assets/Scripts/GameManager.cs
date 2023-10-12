using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private float timeLimit = 120.0f; 

    private float currentTime;

    private void Start()
    {
        currentTime = timeLimit;

        UpdateTimerText();
    }

    void Update()
    {
        int childCount = transform.childCount;

        currentTime -= Time.deltaTime;

        if (childCount == 0 || currentTime <= 0)
        {
            currentTime = 0;
            gameOverUI.SetActive(true);
        }

        UpdateTimerText();
    }

    void UpdateTimerText()
    {
        timerText.text = currentTime.ToString("F2");
    }
}
