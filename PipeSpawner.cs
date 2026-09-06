using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float spawnCD;
    public GameObject[] pipeVariants;

    private float startspawnCD;
    private void Start()
    {
        startspawnCD = spawnCD;
    }
    private void Update()
    {
        if(spawnCD <= 0)
        {
            var randomVariant = Random.Range(0, pipeVariants.Length);
            Vector3 pipeTransform = new Vector3(transform.position.x, pipeVariants[randomVariant].transform.position.y, transform.position.z);
            Instantiate(pipeVariants[randomVariant], pipeTransform, Quaternion.identity);
            spawnCD = startspawnCD -= 0.01F;

        }
        else
        {
            spawnCD -= Time.deltaTime;
        }
    }
}
