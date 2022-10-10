using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Agent/MovementData")]
public class MovementDataSO : ScriptableObject
{
    [Range(1, 10)] public float maxSpeed = 10;

    [Range(0.1f, 100)] public float accelaration = 50, deaccelaration = 50;
}
