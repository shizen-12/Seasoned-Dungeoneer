using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GamepadExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // // ゲームパッドが接続されていないとnullになる。
        // if (Gamepad.current == null) return;

        // if (Gamepad.current.buttonNorth.wasPressedThisFrame)
        // {
        //     Debug.Log("Button Northが押された！");
        // }
        // if (Gamepad.current.buttonSouth.wasReleasedThisFrame)
        // {
        //     Debug.Log("Button Southが離された！");
        // }
    }
    void OnGUI()
    {
        if (Gamepad.current == null) return;
        GUILayout.Label($"leftStick: {Gamepad.current.leftStick.ReadValue()}");
        GUILayout.Label($"rightStick: {Gamepad.current.rightStick.ReadValue()}");
        GUILayout.Label($"dpad: {Gamepad.current.dpad.ReadValue()}");
        // Dpadの上下左右の入力状態をBool型で取得
        GUILayout.Label($"dpad up: {Gamepad.current.dpad.up.isPressed}");
        GUILayout.Label($"dpad down: {Gamepad.current.dpad.down.isPressed}");
        GUILayout.Label($"dpad left: {Gamepad.current.dpad.left.isPressed}");
        GUILayout.Label($"dpad right: {Gamepad.current.dpad.right.isPressed}");

        // // Dpadの上下左右の入力状態をfloat型で取得
        // GUILayout.Label($"dpad up value: {Gamepad.current.dpad.up.ReadValue()}");
        // GUILayout.Label($"dpad down value: {Gamepad.current.dpad.down.ReadValue()}");
        // GUILayout.Label($"dpad left value: {Gamepad.current.dpad.left.ReadValue()}");
        // GUILayout.Label($"dpad right value: {Gamepad.current.dpad.right.ReadValue()}");

        GUILayout.Label($"buttonNorth (Y): {Gamepad.current.buttonNorth.isPressed}");
        GUILayout.Label($"buttonSouth (A): {Gamepad.current.buttonSouth.isPressed}");
        GUILayout.Label($"buttonEast (B): {Gamepad.current.buttonEast.isPressed}");
        GUILayout.Label($"buttonWest (X): {Gamepad.current.buttonWest.isPressed}");
        GUILayout.Label($"leftShoulder (LB): {Gamepad.current.leftShoulder.ReadValue()}");
        GUILayout.Label($"rightShoulder (RB): {Gamepad.current.rightShoulder.ReadValue()}");
        GUILayout.Label($"leftTrigger (LT): {Gamepad.current.leftTrigger.ReadValue()}");
        GUILayout.Label($"rightTrigger (RT): {Gamepad.current.rightTrigger.ReadValue()}");
        GUILayout.Label($"startButton: {Gamepad.current.startButton.isPressed}");
        GUILayout.Label($"selectButton: {Gamepad.current.selectButton.isPressed}");
        GUILayout.Label($"leftStickButton (LS): {Gamepad.current.leftStickButton.isPressed}");
        GUILayout.Label($"rightStickButton (RS): {Gamepad.current.rightStickButton.isPressed}");
    }

}
