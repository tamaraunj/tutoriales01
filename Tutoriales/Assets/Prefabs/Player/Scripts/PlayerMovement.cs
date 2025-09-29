using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 fuerzaAplicada;
    private float tiempoDesdeUltimaFuerza;
    private float intervaloTiempo;
    private IMovementStrategy movementStrategy;
    private Player player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()   
    {
        fuerzaAplicada = new Vector3(0, 0, 300f);
        tiempoDesdeUltimaFuerza = 0f;
        intervaloTiempo = 2f;
        player = new Player(5f, 5f);

        SetMovementStrategy(new MovimientoAcelerado());

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
    public void SetMovementStrategy(IMovementStrategy movementStrategy)
    {
        this.movementStrategy = movementStrategy;
    }

    private void Update()
    {
        MoverJugador();
    }
    public void MoverJugador()
    {
        movementStrategy.Move(transform, player);
    }
}
