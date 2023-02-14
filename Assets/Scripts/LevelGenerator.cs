using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GameObject blockPrefab;

    private void Awake()
    {
        StartCoroutine("WallSpawnerRoutine");
    }

    private IEnumerator WallSpawnerRoutine() 
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            GenerateLevel();
        }
    }
    private void GenerateLevel() 
    {
       Instantiate(blockPrefab, new Vector2(15f, Random.Range(-3f, 3f)), Quaternion.identity);
    }


}
