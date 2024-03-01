using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish1 : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject fishPrefab;
    [SerializeField] float randVarMax;
    [SerializeField] float randVarMin;

   // bool travelDirection = true;
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

        if (Time.time > futureTime) //if current time is greator than the futureTime variable
        {
            futureTime = Time.time + Random.Range(randVarMin, randVarMax);
            Instantiate(fishPrefab, transform.position, transform.rotation);
        }
    }
}
