using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipes;
    [SerializeField] private float spawnDuration;
    [SerializeField] private float posX, minY, maxY;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPipe());
    }

    // Update is called once per frame
    void Update()
    {
        
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
