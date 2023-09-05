using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class EnemyManager : MonoBehaviour
{
    public Transform[] m_spawnpoints;
    public GameObject m_EnemyPrefab;
    void Start()
    {
        SpawnNewEnemy();
    }
    void OnEnable()
    {
        enemycontroller.OnEnemyKilled += SpawnNewEnemy;
    }
    void SpawnNewEnemy()
    {
        Instantiate(m_EnemyPrefab, m_spawnpoints[0].transform.position, Quaternion.identity);
    }
}