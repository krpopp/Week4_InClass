using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxClick : MonoBehaviour
{

    GameManager myManager;

    bool selected = false;

    // Start is called before the first frame update
    void Start()
    {
        myManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {

        if(myManager.playerOneTurn == true && selected == false)
        {
            gameObject.GetComponent<Renderer>().material = myManager.playerOneMat;
            myManager.playerOneTurn = false;
            selected = true;
        } else if(myManager.playerOneTurn == false && selected == false)
        {
            gameObject.GetComponent<Renderer>().material = myManager.playerTwoMat;
            myManager.playerOneTurn = true;
            selected = true;
        }

        Debug.Log(gameObject.name);
    }
}
