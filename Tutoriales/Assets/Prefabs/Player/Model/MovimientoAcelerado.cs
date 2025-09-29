using UnityEngine;
//Estrategia de movimiento acelerado para el jugador
public class MovimientoAcelerado : IMovementStrategy
{
    //Velocidad actual en el eje horizontal
    private float speedActual = 0f;

    //Metodo que implementa el movimiento acelerado
    public void Move(Transform transform, Player player)
    {
        //Se detecta las teclas A/D y se acumula em la velocidad actual por la aceleración
        speedActual += Input.GetAxis("Horizontal") * player.Aceleracion * Time.deltaTime;
        //Se limita la velocidad para que no supere el máximo definido en el player
        player.Velocidad = Mathf.Clamp(speedActual, -player.Velocidad, player.Velocidad);
        //Se aplica el movimiento en el eje x
        transform.Translate(speedActual * Time.deltaTime, 0, 0);
    }
    
}
