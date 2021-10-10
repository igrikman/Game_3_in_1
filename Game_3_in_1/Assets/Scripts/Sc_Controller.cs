using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Controller : MonoBehaviour
{
    private float spawnTime = 3f;
    [SerializeField] private List<Sc_Enemy> enemyList;
    [SerializeField] private Transform[] spawnPoint;
    [SerializeField] private Transform player;
    [SerializeField] private Sc_Enemy enemyPrefab;


    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        enemyList = new List<Sc_Enemy>();
    }
    void Update()
    {
        foreach (var enemy in enemyList)
        {
            if (enemy.isDestroy)
            {
                RemoveEnemy(enemy);
            }
        }
    }
    public void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoint.Length);
        var enemy = Instantiate(enemyPrefab, spawnPoint[spawnPointIndex].position, spawnPoint[spawnPointIndex].rotation);
        enemyList.Add(enemy);
    }

    public void RemoveEnemy(Sc_Enemy enemy)
    {
        Debug.Log("Destroy enemy");
        enemyList.Remove(enemy);

        Destroy(enemy.gameObject);
    }


}
