using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameControl : MonoBehaviour
{
    private int randomNumber;
    public int clickCounter;
  

    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(1, 11);

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AddOneToCouter();
        }

        if (Input.GetMouseButtonDown(1))
        {
            TakeOneOutCounter();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
           if( HaveIWon())
            {
                Debug.Log("Eres un maquina!");
            }
        }
    }

    //AQUI CREAM LES FUNCIONS
    private void AddOneToCouter()
    {
        clickCounter++;
        transform.localScale += Vector3.one;

    }

    private void TakeOneOutCounter()
    {
        clickCounter--;
        transform.localScale -= Vector3.one;
    }
    private bool HaveIWon()
    {
        if (clickCounter < randomNumber)
        {
            Debug.Log($"Te has quedado corto. Has hecho {clickCounter} clicks, pero el numero aleatorio era {randomNumber}");
            Destroy(gameObject);
            return false;
        }
        else if (clickCounter > randomNumber)
        {
            Debug.Log($"Te has pasado. Has hecho {clickCounter} clicks, pero el numero aleatorio era {randomNumber}");
            Destroy(gameObject);
            return false;
        }
        Debug.Log("¡Has ganado!");
            return true;

  
    }
}
