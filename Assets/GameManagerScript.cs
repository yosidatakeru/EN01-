using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    //int GetplayerIndex()
    //{
    //    for (int i = 0; i < map.Length; i++)
    //    {
    //        if (map[i] == 1)
    //        {
    //            return 1;
    //        }
    //        return -1;
    //    }
    //}
    int[] map;
    void PrintArray()
    {
        string debugText = "";
        for(int i =0;i< map.Length;i++)
        {
            debugText += map[i].ToShortString() + ",";
        }
        Debug.Log(debugText);
    }
   
    // Start is called before the first frame update
    void Start()
    {
        map = new int[] { 0, 0, 0, 1, 0, 2, 0, 0, 0, };
        PrintArray();
        // Debug.Log("Hello world");
        string debugText = "";
        for (int i = 0; i < map.Length; i++)
        {
            debugText += map[i].ToString() + ",";
        }
        for (int i = 0; i < map.Length; i++)
        {
            Debug.Log(map[i] + ",");

        }
    

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            int playerIndex = GetplayerIndex();

            if(playerIndex<map.Lenght -1)
            {
                map[playerIndex + 1] = 1;
                map[playerIndex] = 0;
            }

            MoveNumder(1, playerIndex, playerIndex + 1);
            PrintArray();

        }
        int playerIndex = -1;

        for (int i = 0; i < map.Length; i++)
        {
            if (map[i] == 1)
            {
                playerIndex = i;
                break;
            }
        }

        if (playerIndex < map.Length - 1)
        {
            map[playerIndex +1] = 1;
            map[playerIndex] = 0;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            for(int i=0; i<map.Length;i++)
            {
                if (map[i]==1)
                {
                    playerIndex = i;
                    break;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] == 1)
                {
                    playerIndex = i;
                    break;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] == 1)
                {
                    playerIndex = i;
                    break;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Return)) { }
        if (Input.GetKeyDown(KeyCode.KeypadEnter)) { }
        if (Input.GetKeyDown(KeyCode.Alpha0)) { }
        if (Input.GetKeyDown(KeyCode.Keypad0)) { }
        bool MoveNumder(int numder, int moveFrom, int moveTo)
        {
            if (moveTo< 0|| moveTo>= map.Length) { return false; }
            if (map[moveTo] == 2)
            {
                int velocity = moveTo - moveFrom;

                bool success = MoveNumber(2, moveTo, moveTo + velocity);

                if (!success) 
                {
                    return false; 
                }
            }
            map[moveTo] = numder;
            map[moveFrom] = 0;
            return true;

        }
        }
    }
 
}
