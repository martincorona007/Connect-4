using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpace : MonoBehaviour
{
    private GameController gameController;
    public void SetGameControllerReference(GameController controller)
    {
        gameController = controller;
    }

}
