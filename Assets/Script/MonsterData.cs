using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MonstersData", menuName = "SampleGame/MonstersData")]
public class MonstersData : ScriptableObject
{
    public List<MonsterData> dataList;

    [Serializable]
    public class MonsterData
    {
        /// <summary>
        /// 名前
        /// </summary>
        public string monsterName;

        /// <summary>
        /// HP
        /// </summary>
        public int hp;

        /// <summary>
        /// 死亡しているか？
        /// </summary>
        public bool isDead;
    }
}