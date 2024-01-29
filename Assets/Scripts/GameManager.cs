using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject pipePrefab;
    [SerializeField] float spawnInterval = 0;
    [SerializeField] Vector3 spawnPos;  
    [SerializeField] int score;
    public static GameManager Instance;

    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
    }
    // Update is called once per frame
    void Start()
    {
        StartCoroutine(SpawnPipe());
    }

    public IEnumerator SpawnPipe()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            Debug.Log("here");
            Instantiate(pipePrefab/*, spawnPos, Quaternion.identity*/);

        }
    }

    public void ScoreUpdate()
    {
        score++;
        UIManager.Instance.UpdateScore(score);
    }
}
