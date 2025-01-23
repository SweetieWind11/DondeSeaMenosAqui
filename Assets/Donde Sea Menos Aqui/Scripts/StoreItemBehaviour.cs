using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class StoreItemBehaviour : MonoBehaviour
{
    //Para que le pongas el costo del item
    public int m_ItemCost;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            comparePoints();
        }
    }
    void comparePoints()
    {
        int playerPoints = PointsManager.Instance.GetPoints();
        if (playerPoints >= m_ItemCost)
        {
            gameObject.SetActive(false);
            //Aqui implementar la función del buff o lo que sea
            PointsManager.Instance.SubtractPoints(10);
        }
    }
}
