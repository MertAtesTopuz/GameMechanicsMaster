using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeSetter : MonoBehaviour
{
    public static TimeSetter instance;

    public TextMeshProUGUI timeTxt;
    public float time;

    private void Awake()
    {
        instance = this;
    }


    void Update()
    {
        time += Time.deltaTime;
        timeTxt.text = time.ToString();
    }
}
