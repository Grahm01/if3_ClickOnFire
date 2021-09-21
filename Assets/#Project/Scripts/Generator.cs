using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{

    public GameObject basicCube;
    public GameObject purpleCube;
    int timeLoop;
    public int min, max;

    public float Timer = 1;
    public int score;
    void Start()
    {

    }


    Vector3 GeneratedPosition()
    {
        int x, y, z;
        x = Random.Range(min, max);
        y = Random.Range(min, max);
        z = Random.Range(min, max);
        return new Vector3(x, y, z);
    }
    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            GameObject cube;
            timeLoop++;
            Timer = 1;
            if (timeLoop == 5)
            {
                cube = Instantiate(purpleCube, GeneratedPosition(), Quaternion.identity);
                cube.GetComponent<CubeBehaviour>().manager = this;
                timeLoop = 0;
            }
            else { cube = Instantiate(basicCube, GeneratedPosition(), Quaternion.identity); 
                cube.GetComponent<CubeBehaviour>().manager = this; }


        }

        //if (score >= 30)
        //{
        //    Debug.Log("Gagné!");
        //}

    }
}
