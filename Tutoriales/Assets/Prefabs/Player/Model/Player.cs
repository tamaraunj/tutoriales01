using UnityEngine;

public class Player
{
    //Velocidad actual del jugador
    private float velocidad;
    //Aceleracion del jugador
    private float aceleracion;

    public Player(float velocidad, float aceleracion)
    {
        this.velocidad = velocidad;
        this.aceleracion = aceleracion;
    }
    //Para acceder y modificar la velocidad
    public float Velocidad { get => velocidad; set => velocidad = value; }
    //Para acceder y modificar la aceleracion
    public float Aceleracion { get => aceleracion; set => aceleracion = value; }
}
