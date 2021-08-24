using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawner : MonoBehaviour
{
    public GameObject Pipes;
    void Start()
    {
        StartCoroutine(pipeSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator pipeSpawner()
    {
        while(true)
        {

            yield return new WaitForSeconds(1);
            float rand = Random.Range(-1f, 1.79f);
            GameObject newPipes =  Instantiate(Pipes, new Vector3(3f, rand, 0), Quaternion.identity);
            Destroy(newPipes, 5f);

        }

     
     }

}
