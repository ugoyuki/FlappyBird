using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigid;
    public float flapStrength;
    public LogicManager logic;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigid.velocity = Vector2.up * 10 * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
    }
}
