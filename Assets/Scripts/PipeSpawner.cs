using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipes;
    [SerializeField] private float spawnDuration;
    [SerializeField] private float posX, minY, maxY;

    void Start()
    {
        StartCoroutine(SpawnPipe());
    }

    private IEnumerator SpawnPipe()
    {
        for(; ;)
        {
            Instantiate(pipes, new Vector2(posX, Random.Range(minY, maxY)), Quaternion.identity);
            yield return new WaitForSeconds(spawnDuration);
        }
    }
}
