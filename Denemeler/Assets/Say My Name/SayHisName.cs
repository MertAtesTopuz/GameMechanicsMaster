using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SayHisName : MonoBehaviour
{
    public TextMeshProUGUI sayTxt;

    public void SayBtn()
    {
        sayTxt.text = SystemInfo.deviceName;
    }
}
