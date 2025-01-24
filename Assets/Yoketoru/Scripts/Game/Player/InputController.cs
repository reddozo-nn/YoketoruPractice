using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 入力デバイスを取りまとめて制御するクラス
/// </summary>

public class InputController
{
    ///<summary>
    ///対応する入力デバイスのインスタンスを定義
    ///</summary>
    IInput[] inputs =
    {

    };
    ///
    /// 
    ///


    ///<summary>
    ///更新処理を呼び出す。
    ///</summary>
    public void Update()
    {
        for(int i = 0; IInput[i]!='\0';i++)
        {
            inputs[i].Update();
            IInput[i].Update();
        }
    }

    ///<summary>
    ///FixedUpdateから呼び出して、入力デバイスから移動量を読み取って、返す。
    ///</summary>
    ///<returns>移動を指示するVector2の値</returns>
    public Vector2 GetValue()
    {
        return Vector2.zero;
    }
}
