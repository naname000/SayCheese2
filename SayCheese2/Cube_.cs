using System;
using System.Diagnostics.Contracts;

namespace SayCheese2
{
    //[Serializable]
    //public class Cube_ : ICube
    //{
    //    private CubeType type;
    //    private CubeDirection direction;
    //    private FaceAngle angle;
    //    private CubeState state;

    //    public Cube_(CubeType t, CubeDirection d, FaceAngle a)
    //    {
    //        switch (t)
    //        {
    //            case CubeType.CUBE:
    //                if (d != CubeDirection.STAND)
    //                {
    //                    throw new Exception("直方体に倒れている状態は無い");
    //                }
    //                break;
    //            case CubeType.CUBOID:
    //                switch (d)
    //                {
    //                    case CubeDirection.X_MINUS:
    //                    case CubeDirection.X_PLUS:
    //                        if (a == FaceAngle.X_MINUS || a == FaceAngle.X_PLUS)
    //                        {
    //                            throw new Exception("横に倒れた状態で横に顔はない");
    //                        }
    //                        break;
    //                    case CubeDirection.Y_MINUS:
    //                    case CubeDirection.Y_PLUS:
    //                        if (a == FaceAngle.Y_MINUS || a == FaceAngle.Y_PLUS)
    //                        {
    //                            throw new Exception("縦に倒れた状態で奥もしくは手前に顔はない");
    //                        }
    //                        break;
    //                }
    //                break;
    //        }
    //        type = t; direction = d; angle = a;
    //    }

    //    CubeState GetCubeState(CubeType t, CubeDirection d, FaceAngle f)
    //    {
    //        if (t == CubeType.CUBE)
    //        {
    //            if (d != CubeDirection.STAND) throw new Exception("Illigal State.");
    //            switch (f)
    //            {
    //                case FaceAngle.UPPER:
    //                    return CubeState.CUBE_STAND_UPPER;
    //                case FaceAngle.BOTTOM:
    //                    return CubeState.CUBE_STAND_BOTTOM;
    //                case FaceAngle.X_MINUS:
    //                    return CubeState.CUBE_STAND_X_MINUS;
    //                case FaceAngle.X_PLUS:
    //                    return CubeState.CUBE_STAND_X_PLUS;
    //                case FaceAngle.Y_MINUS:
    //                    return CubeState.CUBE_STAND_Y_MINUS;
    //                case FaceAngle.Y_PLUS:
    //                    return CubeState.CUBE_STAND_Y_PLUS;
    //            }
    //        }
    //        else if (t == CubeType.CUBOID)
    //        {
    //            if (d == CubeDirection.STAND)
    //            {
    //                switch (f)
    //                {
    //                    case FaceAngle.X_MINUS:
    //                        return CubeState.CUBOID_STAND_X_MINUS;
    //                    case FaceAngle.X_PLUS:
    //                        return CubeState.CUBOID_STAND_RIGHT;
    //                    case FaceAngle.Y_MINUS:
    //                        return CubeState.CUBOID_STAND_Y_MINUS;
    //                    case FaceAngle.Y_PLUS:
    //                        return CubeState.CUBOID_STAND_Y_PLUS;
    //                }
    //            }
    //            if (d == CubeDirection.X_PLUS)
    //            {
    //                switch (f)
    //                {
    //                    case FaceAngle.UPPER:
    //                        return CubeState.CUBOID_X_PLUS_UPPER;
    //                    case FaceAngle.BOTTOM:
    //                        return CubeState.CUBOID_X_PLUS_BOTTOM;
    //                    case FaceAngle.Y_MINUS:
    //                        return CubeState.CUBOID_X_PLUS_Y_MINUS;
    //                    case FaceAngle.Y_PLUS:
    //                        return CubeState.CUBOID_X_PLUS_Y_PLUS;
    //                }
    //            }
    //            if (d == CubeDirection.X_MINUS)
    //            {
    //                switch (f)
    //                {
    //                    case FaceAngle.UPPER:
    //                        return CubeState.CUBOID_X_MINUS_UPPER;
    //                    case FaceAngle.BOTTOM:
    //                        return CubeState.CUBOID_X_MINUS_BOTTOM;
    //                    case FaceAngle.Y_MINUS:
    //                        return CubeState.CUBOID_X_MINUS_Y_MINUS;
    //                    case FaceAngle.Y_PLUS:
    //                        return CubeState.CUBOID_X_MINUS_Y_PLUS;
    //                }
    //            }
    //            if (d == CubeDirection.Y_PLUS)
    //            {
    //                switch (f)
    //                {
    //                    case FaceAngle.UPPER:
    //                        return CubeState.CUBOID_Y_PLUS_UPPER;
    //                    case FaceAngle.BOTTOM:
    //                        return CubeState.CUBOID_Y_PLUS_BOTTOM;
    //                    case FaceAngle.X_MINUS:
    //                        return CubeState.CUBOID_Y_PLUS_X_MINUS;
    //                    case FaceAngle.X_PLUS:
    //                        return CubeState.CUBOID_Y_PLUS_X_PLUS;
    //                }
    //            }
    //            if (d == CubeDirection.Y_MINUS)
    //            {
    //                switch (f)
    //                {
    //                    case FaceAngle.UPPER:
    //                        return CubeState.CUBOID_Y_MINUS_UPPER;
    //                    case FaceAngle.BOTTOM:
    //                        return CubeState.CUBOID_Y_MINUS_BOTTOM;
    //                    case FaceAngle.X_MINUS:
    //                        return CubeState.CUBOID_Y_MINUS_X_MINUS;
    //                    case FaceAngle.X_PLUS:
    //                        return CubeState.CUBOID_Y_MINUS_X_PLUS;
    //                }
    //            }

    //        }
    //        throw new Exception("State Not Found.");
    //    }

    //    public ICube ToDown()
    //    {
    //        ChangeState(RollDirection.XMINUS);
    //        return this;

    //    }

    //    public ICube ToLeft()
    //    {
    //        ChangeState(RollDirection.YMINUS);
    //        return this;
    //    }

    //    public ICube ToRight()
    //    {
    //        ChangeState(RollDirection.YPLUS);
    //        return this;
    //    }

    //    public ICube ToUp()
    //    {
    //        ChangeState(RollDirection.XPLUS);
    //        return this;
    //    }

    //    private void ChangeState(RollDirection d)
    //    {
            
    //        throw new NotImplementedException();
    //    }
    //}



    //// コマの倒れている方向
    //// 立方体は常にSTAND
    //public enum CubeDirection : byte // 列挙型のデフォルトはint
    //{
    //    STAND,
    //    X_PLUS,
    //    X_MINUS,
    //    Y_PLUS,
    //    Y_MINUS
    //}


    //// 顔の向き
    //// 直方体は４方向にしか顔がない(狭い面に顔が無い。ゲームデザイン上の問題であって、存在しても良いと思う。)
    //public enum FaceAngle : byte
    //{
    //    UPPER,
    //    BOTTOM,
    //    X_PLUS,
    //    X_MINUS,
    //    Y_PLUS,
    //    Y_MINUS
    //}

    //public enum CubeType : byte
    //{
    //    CUBE, // 立方体
    //    CUBOID // 長方体
    //}


}
