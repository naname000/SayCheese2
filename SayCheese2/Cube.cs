using System;
namespace SayCheese2
{
    public class Cube
    {
        // ある状態のコマを転がすとどの状態に推移するかを計算?するメソッド
        public static CubeState Roll(CubeState state, RollDirection d)
        {
            switch (state)
            {
                case CubeState.CUBE_STAND_UPPER:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBE_STAND_X_PLUS;
                        case RollDirection.XMINUS:
                            return CubeState.CUBE_STAND_X_MINUS;
                        case RollDirection.YPLUS:
                            return CubeState.CUBE_STAND_Y_PLUS;
                        case RollDirection.YMINUS:
                            return CubeState.CUBE_STAND_Y_MINUS;
                    }
                    break;
                case CubeState.CUBE_STAND_BOTTOM:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBE_STAND_X_MINUS;
                        case RollDirection.XMINUS:
                            return CubeState.CUBE_STAND_X_PLUS;
                        case RollDirection.YPLUS:
                            return CubeState.CUBE_STAND_Y_MINUS;
                        case RollDirection.YMINUS:
                            return CubeState.CUBE_STAND_Y_PLUS;
                    }
                    break;
                case CubeState.CUBE_STAND_X_PLUS:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBE_STAND_BOTTOM;
                        case RollDirection.XMINUS:
                            return CubeState.CUBE_STAND_UPPER;
                        case RollDirection.YPLUS:
                            return CubeState.CUBE_STAND_X_PLUS;
                        case RollDirection.YMINUS:
                            return CubeState.CUBE_STAND_X_PLUS;
                    }
                    break;
                case CubeState.CUBE_STAND_X_MINUS:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBE_STAND_UPPER;
                        case RollDirection.XMINUS:
                            return CubeState.CUBE_STAND_BOTTOM;
                        case RollDirection.YPLUS:
                            return CubeState.CUBE_STAND_X_MINUS;
                        case RollDirection.YMINUS:
                            return CubeState.CUBE_STAND_X_MINUS;
                    }
                    break;
                case CubeState.CUBE_STAND_Y_PLUS:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBE_STAND_Y_PLUS;
                        case RollDirection.XMINUS:
                            return CubeState.CUBE_STAND_Y_PLUS;
                        case RollDirection.YPLUS:
                            return CubeState.CUBE_STAND_BOTTOM;
                        case RollDirection.YMINUS:
                            return CubeState.CUBE_STAND_UPPER;
                    }
                    break;
                case CubeState.CUBE_STAND_Y_MINUS:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBE_STAND_Y_MINUS;
                        case RollDirection.XMINUS:
                            return CubeState.CUBE_STAND_Y_MINUS;
                        case RollDirection.YPLUS:
                            return CubeState.CUBE_STAND_UPPER;
                        case RollDirection.YMINUS:
                            return CubeState.CUBE_STAND_BOTTOM;
                    }
                    break;


                case CubeState.CUBOID_STAND_X_PLUS:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_X_PLUS_BOTTOM;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_X_MINUS_UPPER;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_Y_PLUS_X_PLUS;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_Y_MINUS_X_PLUS;
                    }
                    break;
                case CubeState.CUBOID_STAND_X_MINUS:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_X_PLUS_UPPER;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_X_MINUS_BOTTOM;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_Y_PLUS_X_MINUS;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_Y_MINUS_X_MINUS;
                    }
                    break;
                case CubeState.CUBOID_STAND_Y_PLUS:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_X_PLUS_Y_PLUS;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_X_MINUS_Y_PLUS;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_Y_PLUS_BOTTOM;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_Y_MINUS_UPPER;
                    }
                    break;
                case CubeState.CUBOID_STAND_Y_MINUS:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_X_PLUS_Y_MINUS;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_X_MINUS_Y_MINUS;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_Y_PLUS_UPPER;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_Y_MINUS_BOTTOM;
                    }
                    break;
                case CubeState.CUBOID_X_PLUS_UPPER:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_STAND_X_PLUS;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_STAND_X_MINUS;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_X_PLUS_Y_PLUS;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_X_PLUS_Y_MINUS;
                    }
                    break;
                case CubeState.CUBOID_X_PLUS_BOTTOM:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_STAND_X_MINUS;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_STAND_X_PLUS;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_X_PLUS_Y_MINUS;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_X_PLUS_Y_PLUS;
                    }
                    break;
                case CubeState.CUBOID_X_PLUS_Y_PLUS:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_STAND_Y_PLUS;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_STAND_Y_PLUS;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_X_PLUS_BOTTOM;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_X_PLUS_UPPER;
                    }
                    break;
                case CubeState.CUBOID_X_PLUS_Y_MINUS:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_STAND_Y_MINUS;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_STAND_Y_MINUS;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_X_PLUS_UPPER;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_X_PLUS_BOTTOM;
                    }
                    break;
                case CubeState.CUBOID_X_MINUS_UPPER:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_STAND_X_PLUS;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_STAND_X_MINUS;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_X_MINUS_Y_PLUS;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_X_MINUS_Y_MINUS;
                    }
                    break;
                case CubeState.CUBOID_X_MINUS_BOTTOM:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_STAND_X_MINUS;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_STAND_X_PLUS;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_X_MINUS_Y_MINUS;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_X_MINUS_Y_PLUS;
                    }
                    break;
                case CubeState.CUBOID_X_MINUS_Y_PLUS:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_STAND_Y_PLUS;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_STAND_Y_PLUS;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_X_MINUS_BOTTOM;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_X_MINUS_UPPER;
                    }
                    break;
                case CubeState.CUBOID_X_MINUS_Y_MINUS:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_STAND_Y_MINUS;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_STAND_Y_MINUS;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_X_MINUS_UPPER;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_X_MINUS_BOTTOM;
                    }
                    break;
                case CubeState.CUBOID_Y_PLUS_UPPER:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_Y_PLUS_X_PLUS;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_Y_PLUS_X_MINUS;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_STAND_Y_PLUS;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_STAND_Y_MINUS;
                    }
                    break;
                case CubeState.CUBOID_Y_PLUS_BOTTOM:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_Y_PLUS_X_MINUS;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_Y_PLUS_X_PLUS;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_STAND_Y_MINUS;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_STAND_Y_PLUS;
                    }
                    break;
                case CubeState.CUBOID_Y_PLUS_X_PLUS:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_Y_PLUS_BOTTOM;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_Y_PLUS_UPPER;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_STAND_X_PLUS;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_STAND_X_PLUS;
                    }
                    break;
                case CubeState.CUBOID_Y_PLUS_X_MINUS:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_Y_PLUS_UPPER;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_Y_PLUS_BOTTOM;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_STAND_X_MINUS;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_STAND_X_MINUS;
                    }
                    break;
                case CubeState.CUBOID_Y_MINUS_UPPER:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_Y_MINUS_X_PLUS;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_Y_MINUS_X_MINUS;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_STAND_Y_PLUS;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_STAND_Y_MINUS;
                    }
                    break;
                case CubeState.CUBOID_Y_MINUS_BOTTOM:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_Y_MINUS_X_MINUS;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_Y_MINUS_X_PLUS;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_STAND_Y_MINUS;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_STAND_Y_PLUS;
                    }
                    break;
                case CubeState.CUBOID_Y_MINUS_X_PLUS:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_Y_MINUS_BOTTOM;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_Y_MINUS_UPPER;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_STAND_X_PLUS;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_STAND_X_PLUS;
                    }
                    break;
                case CubeState.CUBOID_Y_MINUS_X_MINUS:
                    switch (d)
                    {
                        case RollDirection.XPLUS:
                            return CubeState.CUBOID_Y_MINUS_UPPER;
                        case RollDirection.XMINUS:
                            return CubeState.CUBOID_Y_MINUS_BOTTOM;
                        case RollDirection.YPLUS:
                            return CubeState.CUBOID_STAND_X_MINUS;
                        case RollDirection.YMINUS:
                            return CubeState.CUBOID_STAND_X_MINUS;
                    }
                    break;
            }
            throw new Exception("Undefined State.");
        }

        public static CubeDirection getCubeDirection(CubeState state)
        {
            CubeDirection direction = CubeDirection.STAND;

            if (state == CubeState.CUBOID_X_MINUS_UPPER ||
                state == CubeState.CUBOID_X_MINUS_BOTTOM ||
                state == CubeState.CUBOID_X_MINUS_Y_PLUS ||
                state == CubeState.CUBOID_X_MINUS_Y_MINUS) direction = CubeDirection.XMINUS;

            if (state == CubeState.CUBOID_X_PLUS_UPPER ||
                state == CubeState.CUBOID_X_PLUS_BOTTOM ||
                state == CubeState.CUBOID_X_PLUS_Y_PLUS ||
                state == CubeState.CUBOID_X_PLUS_Y_MINUS) direction = CubeDirection.XPLUS;

            if (state == CubeState.CUBOID_Y_MINUS_UPPER ||
                state == CubeState.CUBOID_Y_MINUS_BOTTOM ||
                state == CubeState.CUBOID_Y_MINUS_X_PLUS ||
                state == CubeState.CUBOID_Y_MINUS_X_MINUS) direction = CubeDirection.YMINUS;

            if (state == CubeState.CUBOID_Y_PLUS_UPPER ||
                state == CubeState.CUBOID_Y_PLUS_BOTTOM ||
                state == CubeState.CUBOID_Y_PLUS_X_PLUS ||
                state == CubeState.CUBOID_Y_PLUS_X_MINUS) direction = CubeDirection.YPLUS;

            return direction;
        }


    }
    // 形_倒れている方向_顔の向き
    public enum CubeState : byte
    {
        CUBE_STAND_UPPER,
        CUBE_STAND_BOTTOM,
        CUBE_STAND_X_PLUS,
        CUBE_STAND_X_MINUS,
        CUBE_STAND_Y_PLUS,
        CUBE_STAND_Y_MINUS,

        CUBOID_STAND_X_PLUS,
        CUBOID_STAND_X_MINUS,
        CUBOID_STAND_Y_PLUS,
        CUBOID_STAND_Y_MINUS,

        CUBOID_X_PLUS_UPPER,
        CUBOID_X_PLUS_BOTTOM,
        CUBOID_X_PLUS_Y_PLUS,
        CUBOID_X_PLUS_Y_MINUS,

        CUBOID_X_MINUS_UPPER,
        CUBOID_X_MINUS_BOTTOM,
        CUBOID_X_MINUS_Y_PLUS,
        CUBOID_X_MINUS_Y_MINUS,

        CUBOID_Y_PLUS_UPPER,
        CUBOID_Y_PLUS_BOTTOM,
        CUBOID_Y_PLUS_X_PLUS,
        CUBOID_Y_PLUS_X_MINUS,

        CUBOID_Y_MINUS_UPPER,
        CUBOID_Y_MINUS_BOTTOM,
        CUBOID_Y_MINUS_X_PLUS,
        CUBOID_Y_MINUS_X_MINUS
    }

    public enum RollDirection
    {
        XMINUS,
        XPLUS,
        YMINUS,
        YPLUS,
    }

    // コマの倒れている方向を表現する
    public enum CubeDirection
    {
        STAND,
        XMINUS,
        XPLUS,
        YMINUS,
        YPLUS,
    }
}