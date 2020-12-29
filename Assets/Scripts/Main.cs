using System;
using UnityEngine;

public class Main : MonoBehaviour {
    private void Update() {
        // 读取鼠标滚轮输入，修改 timeScale，主要用于观测人物状态
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (Math.Abs(scroll) > 1e-5) {
            Time.timeScale = Mathf.Clamp(Time.timeScale + scroll, 0.1F, 2);
        }
    }

    private void OnGUI() {
        // 显示当前 timeScale
        GUI.Label(new Rect(0, 0, 200, 100), $"timeScale: {Time.timeScale.ToString("F2")}", new GUIStyle {fontSize = 32});
    }
}