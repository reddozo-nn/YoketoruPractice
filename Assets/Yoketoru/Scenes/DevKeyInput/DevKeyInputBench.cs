using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInputBench : MonoBehaviour
{
    KeyInput keyInput = new();

    void Update()
    {
        keyInput.Update();
    }

    private void FixedUpdate()
    {
        UnityEngine.Debug.Log($"{keyInput.GetValue()}");
    }
}
