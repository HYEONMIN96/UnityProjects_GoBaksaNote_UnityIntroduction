using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityEventFuncScripts : MonoBehaviour
{
    public void Awake()
    {
        Debug.Log("Awake");
    }
    public void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    public void Start()
    {
        Debug.Log("Start");
    }

    public void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    public void Update()
    {
        Debug.Log("Update");
    }
    public void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    public void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }

    public void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }
    public void OnDisable()
    {
        Debug.Log("OnDisable");
    }
}