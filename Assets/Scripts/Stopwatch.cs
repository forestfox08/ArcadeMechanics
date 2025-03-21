using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    public Text timerText;
    private float elapsedTime;
    private bool isRunning;

    void Start()
    {
        isRunning = true;

        if (timerText == null)
        {
            GameObject textObject = new GameObject("StopwatchText");
            textObject.transform.SetParent(FindObjectOfType<Canvas>().transform);
            timerText = textObject.AddComponent<Text>();
            timerText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            timerText.alignment = TextAnchor.MiddleCenter;
            timerText.fontSize = 50;
            RectTransform rectTransform = timerText.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = Vector2.zero;
            rectTransform.sizeDelta = new Vector2(300, 100);
        }
    }

    void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
            UpdateTimerDisplay();
        }

        //Resume Timer

        if (Input.GetKey(KeyCode.T))
        {
            StartStopwatch();
        }

        //Stop Timer

        if (Input.GetKey(KeyCode.Y))
        {
            StopStopwatch();
        }
    }
    
    public void StartStopwatch()
    {
        isRunning = true;
    }

    public void StopStopwatch()
    {
        isRunning = false;
    }

    public void ResetStopwatch()
    {
        isRunning = false;
        elapsedTime = 0f;
        UpdateTimerDisplay();
    }

    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        int milliseconds = Mathf.FloorToInt((elapsedTime * 100) % 100);
        timerText.text = string.Format("{0:00}:{1:00}.{2:00}", minutes, seconds, milliseconds);
    }
}
