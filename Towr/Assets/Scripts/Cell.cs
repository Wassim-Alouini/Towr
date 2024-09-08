using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell
{

    public enum CellType
    {
        emptyCell,
        walkingCell,
        buildingCell,
        homeCell,
    }

    public CellType cellType;
    public Vector2 gridPos;
    
    public Cell(CellType cellType){
        this.cellType = cellType;
        
    }

    public void SetCellType(CellType type){
        cellType = type;
    }


}
