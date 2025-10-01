using UnityEngine;

public interface IMovementStrategy
{
    //Método que cada estrategia debe implementar
    public void Move(Transform transform, Player player, float direccion);
}
