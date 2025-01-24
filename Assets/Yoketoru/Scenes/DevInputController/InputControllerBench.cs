using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class InputControllerBench : MonoBehaviour
{
    InputController inputController = new();

    void Updata()
    {
        inputController.Update();
    }

    void FixedUpdate()
    {
        var move = inputController.GetValue();
        UnityEngine.Debug.Log($"{move}");
    }
}
