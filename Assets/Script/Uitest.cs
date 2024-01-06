using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Uitest : MonoBehaviour
{
    /// <summary>
    /// UI
    /// </summary>
    [SerializeField] private Text nameText;
    [SerializeField] private Text hpText;
    [SerializeField] private Text isDeadText;

    /// <summary>
    /// ScriptableObject
    /// </summary>
    [SerializeField] private MonstersData monsterData;
    private void Awake()
    {
        // ScriptableObjectからデータを設定
        nameText.text = monsterData.dataList[0].monsterName;
        hpText.text = monsterData.dataList[0].hp.ToString();
        isDeadText.text = monsterData.dataList[0].isDead.ToString();
    }
}