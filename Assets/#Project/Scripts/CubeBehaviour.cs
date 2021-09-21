using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    public int id = -1;
    public Generator manager;
    public int points;

    private float lifeSpan;

    bool mouseOver = false;
    
    void Start()
    {
        lifeSpan = Random.Range(2f, 4f);

    }

    // Update is called once per frame
    void Update()
    {
        lifeSpan -= 0.001f;
        //Debug.Log(lifeSpan);

        if (Input.GetMouseButtonUp(0) && mouseOver)
        {
            //score += gameObject.GetComponent<CubeBehaviour>().points;
            manager.score+= points;
            Debug.Log(manager.score);
            Destroy(gameObject);


            //Debug.Log("BOOM");
        }

        if (lifeSpan <=0f)
        {
            Destroy(gameObject);
        }




    }
    void OnMouseOver()
    {
        //transform.localScale = new Vector3(1, 2, 1);
        mouseOver = true;

    }

    void OnMouseExit()
    {
        //transform.localScale = Vector3.one;
        mouseOver = false;
    }
}