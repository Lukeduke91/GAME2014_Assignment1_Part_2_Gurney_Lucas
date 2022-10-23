using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// GameController.cs 
/// Lucas Gurney
/// 101313633 
/// October 23 2022 1:20 PM
/// This scripts is used to keep track of the enemies in the play scene

public class GameController : MonoBehaviour
{
    [Range(1, 4)]
    public int enemyNumber = 3;
    
    private List<GameObject> enemyList;
    private GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        enemyPrefab = Resources.Load<GameObject>("Prefabs/Enemy");
        BuildEnemyList();
    }


    public void BuildEnemyList()
    {
        enemyList = new List<GameObject>();

        for (var i = 0; i < enemyNumber; i++)
        {
            var enemy = Instantiate(enemyPrefab);
            enemyList.Add(enemy);
        }
    }
}
