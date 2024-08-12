
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int corDaVez, acertos, erros;
    public int[] sequencia;
    [SerializeField]public string[] nomes;
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        GerarSequencia();
    }

 public void GerarSequencia()
    {
        corDaVez = 0;
        sequencia =   
        UIManager.instance.LimparTexto();
        for(int i = 0; i < sequencia.Length;i++)
        {
            sequencia[i] = Random.Range(0, nomes.Length);
            UIManager.instance.AtualizarSequencia();
        }
    }
    
}
