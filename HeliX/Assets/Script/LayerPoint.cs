using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerPoint : MonoBehaviour
{
    // Start is called before the first frame update

    private Transform ball;
    private GameManager gm;
    
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
        ball = GameObject.Find("Ball").gameObject.GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y - 1f > ball.transform.position.y)
        {
            Destroy(gameObject);
            gm.GameScore();
            
        }
    }
}
