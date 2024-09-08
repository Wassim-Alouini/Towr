using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Map : MonoBehaviour
{

    [SerializeField]private int height;
    [SerializeField]private int width;
    public Cell[,] map;
    public Map(int height, int width)
    {
        this.height = height;
        this.width = width;

        map = new Cell[height,width];
    }

    public void SetMap_Random()
    {
        
        try
        {
            foreach(Cell cell in map)
            {
                cell.SetCellType((Cell.CellType)UnityEngine.Random.Range(0, 4));
            }
        }
        catch(NullReferenceException nullexc)
        {
            print(nullexc);
        }
    }

    public void InitializeMap_Empty(){
        try{
            for(int i = 0; i < height; i++){
                
                for(int j = 0; j < width; j++){
                    map[i,j] = new Cell(0);
                }
                
            }
        }
        catch(NullReferenceException nullexc)
        {
            print(nullexc);
        } 
    }

    public void PrintMap(){
        try{
            string line = "";
            for(int i = 0; i < height; i++){
                line = "";
                for(int j = 0; j < width; j++){
                    line += (map[i,j].cellType).ToString()[0];
                    line += " ";
                }
                print(i + " - - " + line + " ");
            }
        }
        catch(NullReferenceException nullexc)
        {
            print(nullexc);
        } 
    }

    void Start(){

        map = new Cell[height,width];
        InitializeMap_Empty();
        SetMap_Random();
        PrintMap();
    }
}
