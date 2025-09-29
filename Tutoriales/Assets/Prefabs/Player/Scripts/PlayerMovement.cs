using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Fuerza que se aplica al jugador en el eje Z
    private Vector3 fuerzaAplicada;
    //Contador de tiempo desde la ultima vez que se aplicó la fuerza
    private float tiempoDesdeUltimaFuerza;
    //Intervalo entre cada aplicacion de fuerza
    private float intervaloTiempo;

    //Estrategia de movimiento
    //Permite cambiar como se mueve el player
    private IMovementStrategy movementStrategy;

    //Aceleracion y velocidad del jugador
    private Player player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()   
    {
        //Definimos la fuerza hacia adelamte 
        fuerzaAplicada = new Vector3(0, 0, 300f);
        //Inicializar el contador de tiempo
        tiempoDesdeUltimaFuerza = 0f;
        //Cada 2 segundo se aplica la fuerza
        intervaloTiempo = 2f;
        //Se crea al jugador con velocidad y aceleracion iniciales
        player = new Player(5f, 5f);

        //Se define la estrategia de movimiento inicial (acelerado)
        SetMovementStrategy(new MovimientoAcelerado());

    }
    //Logica para aplicar fuerzas
    private void FixedUpdate()
    {
        //Aumentar el contador de tiempo
        tiempoDesdeUltimaFuerza += Time.fixedDeltaTime;
        
        //Si pasa el intervalo se aplica fuerza hacia adelante
        if (tiempoDesdeUltimaFuerza >= intervaloTiempo)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(fuerzaAplicada);
            //Reinicar contador
            tiempoDesdeUltimaFuerza = 0f;

        }
    }

    //cambia la estrategia de movimiiento en tiempo de ejecucion
    public void SetMovementStrategy(IMovementStrategy movementStrategy)
    {
        this.movementStrategy = movementStrategy;
    }

    private void Update()
    {
        MoverJugador();
    }

    //llama a la estregia de movimiento actual
    public void MoverJugador()
    {
        movementStrategy.Move(transform, player);
    }
}
