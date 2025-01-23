using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    /*
     * No hace falta que te explique esto sori, pero ps es un manager para los puntos sin tener que tocar
     * al jugador para poder usarlo en tienda o otras cosas para que consigas tus cosos o no sé, por ahora
     * este es el points manager
     */
    public static PointsManager Instance { get; private set; }
    public int m_points;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
    void Update()
    {
        //Esto es completamente temporal, porfavor borrarlo después de las pruebas
        if (Input.GetKeyDown(KeyCode.P))
        {
            m_points+=10;
        }
    }
    //Sumar puntos
    /*
     *Recuerda por si se te olvida como acceder a estas funciones desde otro script se hace asi
     *PointsManager.Instance.AddPoints(10); 
     */
    public void AddPoints(int amount)
    {
        m_points += amount;
    }

    // Quitar puntos
    public void SubtractPoints(int amount)
    {
        
        m_points -= amount;
    }

    public int GetPoints()
    {
        return m_points;
    }
    
}
