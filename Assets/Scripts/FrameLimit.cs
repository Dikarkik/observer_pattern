using System;
using System.Reflection;
using UnityEngine;

public sealed class FrameLimit : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = 30;
    }

    private void Start()
    {
        Type t = typeof(int);
        Debug.Log(t);
        Assembly assem = Assembly.GetAssembly(t);
        Debug.Log(assem.Location);
    }
}