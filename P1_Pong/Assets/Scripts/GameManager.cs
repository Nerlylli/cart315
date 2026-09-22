using UnityEngine;
using UnityEngine.EventSystems;

//responsible for starting the game
public class GameManager : MonoBehaviour
{
    //int means integer value: 1,2,3,4,5
   public int scoreP1 = 0;
   public int scoreP2 = 0;

    //playerId = 0 -> left player, 1 -> right player
   public void IncreaseScore(int playerId)
    {
    switch (playerId)
    {       
    case 0: 
        scoreP1++; 
        break;
    case 1: 
        scoreP2++; 
        break;
     }

    }

}
