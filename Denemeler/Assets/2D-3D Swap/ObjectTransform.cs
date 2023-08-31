using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransform : MonoBehaviour
{
    public static ObjectTransform instance;

    public GameObject[] worldObjects;

    private void Awake()
    {
        instance = this;
    }
}
