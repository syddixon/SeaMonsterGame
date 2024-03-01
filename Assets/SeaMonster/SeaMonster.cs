using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaMonster : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject monsterPrefab;
    [SerializeField] float randVarMax;
    [SerializeField] float randVarMin;

    //the boolean travelDirection is true when going up, false when going down
    bool travelDirection = true;
    float futureTime = 0; //time when we'll instantiate baby or demon

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.left);
        //if(transform.position.x <= -6)
        //{
        //    Instantiate(monsterPrefab);

        //}
        if (Time.time > futureTime) //if current time is greator than the futureTime variable
        {
            futureTime = Time.time + Random.Range(randVarMin, randVarMax);
            Instantiate(monsterPrefab, transform.position, transform.rotation);
        }
    }
}
