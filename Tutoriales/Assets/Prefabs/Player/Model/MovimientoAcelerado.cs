using UnityEngine;

//Estrategia de movimiento acelerado para el jugador
public class MovimientoAcelerado : IMovementStrategy
{
    //Metodo que implementa el movimiento acelerado
    public void Move(Transform transform, Player player, float direccion)
    {
        float movement = direccion * (player.Velocidad + player.Aceleracion) * Time.deltaTime;
        //Se aplica el movimiento en el eje x
        transform.Translate(movement, 0, 0);
    }
    
}
