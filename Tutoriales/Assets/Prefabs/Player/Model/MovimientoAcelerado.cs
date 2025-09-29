using UnityEngine;

public class MovimientoAcelerado : IMovementStrategy
{
    private float speedActual = 0f;
    public void Move(Transform transform, Player player)
    {
        speedActual += Input.GetAxis("Horizontal") * player.Aceleracion * Time.deltaTime;
        player.Velocidad = Mathf.Clamp(speedActual, -player.Velocidad, player.Velocidad);
        transform.Translate(speedActual * Time.deltaTime, 0, 0);
    }
    
}
