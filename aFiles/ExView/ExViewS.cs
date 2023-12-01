using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ExViewS : MonoBehaviour
{
    public GameObject marker;
    private void OnEnable()
    {
        Application.logMessageReceived += HandleLogMessage;
    }

    private void OnDisable()
    {
        Application.logMessageReceived -= HandleLogMessage;
    }
    private void HandleLogMessage(string logString, string stackTrace, LogType type)
    {
        if (type == LogType.Exception || type == LogType.Error)
        {
            // ����� ����� ���������� ����������, ��������, �������� ��� � ��� ��� ��������� ����� �� ������.
            marker.SetActive(true);
            Transform texter = marker.transform.Find("texter");
            texter.GetComponent<TextMeshProUGUI>().text = logString;
            
        }
    }
}
