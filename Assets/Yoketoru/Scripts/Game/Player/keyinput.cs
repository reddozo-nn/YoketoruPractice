using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// キー入力を読み取って、返すクラス。
/// </summary>
public class KeyInput : IInput
{
    ///<summary>
    ///入力値を記録しておく変数
    ///</summary>
    Vector2 inputValue;

    public Vector2 GetValue()
    {
        return inputValue;
    }

    public void Update()
    {
        inputValue.x = input.GetAxis("Horizontal");
        inputValue.y = input.GetAxis("Vertical");
    }

    public void FixedUpdate()
    {
        UnityEngine.Debug.Log($"{inputValue.x}");
        UnityEngine.Debug.Log($"{inputValue.y()}");
    }
}
