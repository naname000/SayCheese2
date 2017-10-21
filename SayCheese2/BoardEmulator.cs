using System;
using System.Collections.Generic;

namespace SayCheese2
{
    public class BoardEmulator
    {
        private Dictionary<CellPosition, Cube> table;
        private FilledCells filledCell;

        public BoardEmulator()
        {

        }

        public void Initialize(BoardSnapshot snapshot)
        {
            foreach (var cell in snapshot.Values)
            {
                //this.filledCell = this.filledCell | cell.filledCell;
            }
            //this.table = new Dictionary<CellPosition, Cube>(snapshot);
        }

        public Node createChildren()
        {
            throw new NotImplementedException();

        }
    }



}
