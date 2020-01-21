using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[CreateAssetMenu(fileName = "AllyStatus", menuName = "CreateAllyStatus")]
public class AllyStatus : CharacterStatus
{

    //　獲得経験値
    [SerializeField]
    private int earnedExperience = 0;

    public void SetEarnedExperience(int earnedExperience)
    {
        this.earnedExperience = earnedExperience;
    }

    public int GetEarnedExperience()
    {
        return earnedExperience;
    }
}
