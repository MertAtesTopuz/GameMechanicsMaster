using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class UseData : MonoBehaviour
{
    private string path;
    private string txt;
    public Button btnClick;
    public TMP_InputField inputUser;

    void Start()
    {
        path = "../../../../Oyun/Sa.txt";
        btnClick.onClick.AddListener(NewText);
    }

    void Update()
    {
       txt = File.ReadAllText(path);
        Debug.Log(txt);
    }

    public void NewText()
    {
        File.WriteAllText(path, inputUser.text);
    }
    
}
