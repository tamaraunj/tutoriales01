using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 fuerzaAplicada;
    private float tiempoDesdeUltimaFuerza;
    private float intervaloTiempo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()   
    {
        fuerzaAplicada = new Vector3(0, 0, 300f);
        tiempoDesdeUltimaFuerza = 0f;
        intervaloTiempo = 2f;

    }
    //Logica para aplicar fuerzas
    private void FixedUpdate()
    {
        tiempoDesdeUltimaFuerza += Time.fixedDeltaTime;
        if (tiempoDesdeUltimaFuerza >= intervaloTiempo)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(fuerzaAplicada);
            tiempoDesdeUltimaFuerza = 0f;

        }
    }
}
