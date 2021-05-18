using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int EnemyHealth = 5;
   
    void DeductPoints(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    void Update()
    {
        if (EnemyHealth <= 0)
        {
            transform.position = TargetBounds.Instance.GetRandomPosition();
            EnemyHealth += 5;
            GlobalScore.CurrentScore += 50;
        }
    }
}
