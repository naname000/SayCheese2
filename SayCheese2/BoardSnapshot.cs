using System;
using System.Collections.Generic;
namespace SayCheese2
{
    using BitBoard = Int32;

    public class BoardSnapshot : Dictionary<CellPosition, CubeState>, IEquatable<BoardSnapshot>
    {
        private BitBoard _BitBoard = default(BitBoard);

        public BoardSnapshot(IDictionary<CellPosition, CubeState> dictionary) : base(dictionary)
        {
        }

        public BitBoard GetBitBoard()
        {
            if (_BitBoard == default(BitBoard)) _BitBoard = GetBitBoard(this);
            return _BitBoard;
        }



        // 埋まっているマスを計算するメソッド
        private static BitBoard GetBitBoard(BoardSnapshot snapshot)
        {
            BitBoard filledCells = default(BitBoard);
            foreach (var cell in snapshot)
            {
                filledCells = filledCells | CalcBitBoard(cell.Key, cell.Value);
            }
            return filledCells;
        }

        // コマが配置されている位置、及び状態から埋まっているマスを計算するメソッド
        public static BitBoard CalcBitBoard(CellPosition position, CubeState state)
        {
            CubeDirection direction = Cube.getCubeDirection(state);
            BitBoard bitBoard = CalcBitBoardByPosition(position);
            switch (direction)
            {
                case CubeDirection.XMINUS:
                    bitBoard = bitBoard | bitBoard >> 1;
                    break;
                case CubeDirection.XPLUS:
                    bitBoard = bitBoard | bitBoard << 1;
                    break;
                case CubeDirection.YMINUS:
                    bitBoard = bitBoard | bitBoard << 3;
                    break;
                case CubeDirection.YPLUS:
                    bitBoard = bitBoard | bitBoard >> 3;
                    break;
                case CubeDirection.STAND:
                    break;
            }
            return bitBoard;
        }

        // コマが配置されている位置から埋まっているマスを計算するメソッド
        public static BitBoard CalcBitBoardByPosition(CellPosition position)
        {
            int one = 1;
            BitBoard bitBoard = one << position.X;
            bitBoard = bitBoard << 3 * position.Y;
            return bitBoard;
        }

        public int GetHashCode(BoardSnapshot obj)
        {
            var ret = obj.GetBitBoard();
            return ret;
        }

        public bool Equals(BoardSnapshot other)
        {
            foreach (var kv in other)
            {
                if (this.ContainsKey(kv.Key) == false)
                {
                    return false;
                }
                if (this[kv.Key] != other[kv.Key])
                {
                    return false;
                }
            }
            return true;
        }
    }

    public class Board : Dictionary<CellPosition, CubeState>
    {
    }


    //[Flags]
    //public enum FilledCells : int
    //{
    //    Invalid = 0,
    //    ONE = 1,
    //    TWO = 1 << 2,
    //    THREE = 1 << 3,
    //    FOUR = 1 << 4,
    //    FIVE = 1 << 5,
    //    SIX = 1 << 6,
    //    SEVEN = 1 << 7,
    //    EIGHT = 1 << 8,
    //    NINE = 1 << 9,
    //}

    public struct CellPosition
    {
        public int X;
        public int Y;


        public CellPosition(int line, int row)
        {
            X = line; Y = row;
        }
    }

}
