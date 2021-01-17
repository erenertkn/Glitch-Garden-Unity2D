using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] Attacker attackerPrefab;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        do
        {
            yield return StartCoroutine(AttackerSpawner());
        }
        while (spawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AttackerSpawner()
    {
        int rndnum = Random.Range(1,5);
        yield return new WaitForSeconds(rndnum);
        Attacker go = Instantiate(attackerPrefab, transform.position,Quaternion.identity);
        go.transform.parent = transform;
       
    }
}
