using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public bool isPlayer1;
    private static int pontuacaoPlayer1;
    private static int pontuacaoPlayer2;
    public TextMeshPro Pontuacao;
    public TextMesh Contador;
    public Transform Bola;
    public Transform Player1;
    public Transform Player2;
    public Ball ballScript;
    private readonly bool matchHasStarted = false;
    public int CountdownTime = 3;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IniciarContador(() => ballScript.Iniciar()));
    }

    IEnumerator IniciarContador(Action action)
    {
        while (CountdownTime > 0)
        {
            Contador.text = CountdownTime.ToString();
            yield return new WaitForSeconds(1f);
            CountdownTime--;
        }
        Contador.text = "Go!";
        yield return new WaitForSeconds(1f);
        Contador.gameObject.SetActive(false);
        action();        
    }
    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bola")
        {
            MarcarPontuacao();
        }
    }

    private void MarcarPontuacao()
    {
        if (isPlayer1)
            pontuacaoPlayer2++;
        else
            pontuacaoPlayer1++;

        Pontuacao.text = $"{pontuacaoPlayer1} x {pontuacaoPlayer2}";
        ResetarPartida();
    }

    private void ResetarPartida()
    {
        Player1.localPosition = new Vector3(-14f, 1f, 0f);
        Player2.localPosition = new Vector3(14f, 1f, 0f);
        Bola.localPosition = new Vector3(0f, 0.97f, 0f);
    }
}
