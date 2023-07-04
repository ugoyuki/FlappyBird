using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddle : MonoBehaviour
{



    public LogicManager logic;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
            logic.addScore();
    }
}
