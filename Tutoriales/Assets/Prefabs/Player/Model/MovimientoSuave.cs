using UnityEngine;

//Estrategia de movimiento lateral suave para el jugador
public class MovimientoSuave : IMovementStrategy
{
    //Metodo q implementa el movimiento suave
    public void Move(Transform transform, Player player, float direccion)
    {
        float moverEnX = direccion * player.Velocidad * Time.deltaTime;
        //Se traslada el transform en el eje X, generando un movimiento lineal sin acelracion
        transform.Translate(moverEnX, 0 , 0);
    }
}
