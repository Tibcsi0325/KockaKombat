using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float playerhealth;
    public float playerdamage;
    public float playerdamagemultiplyerboost;

    void UpgradeHealth(float count)
    {
        playerhealth += count;
    }

    void UpgradeDamage(float count)
    {
        playerdamage += count;
    }
    void Upgradeplayerdamagemultiplyerboost(float count)
    {
        playerdamagemultiplyerboost += count;
    }

}
