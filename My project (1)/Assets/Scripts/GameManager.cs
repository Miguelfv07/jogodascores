using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int corDaVez, acertos, erros;
    int[] sequencia;
    [SerializeField] string[] nomes;
    public GameManager instance;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
