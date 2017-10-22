using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SayCheese2
{
    class MainClass
    {
        public static void Main()
        {
            // 重複検索がメンドイのでリストに突っ込む
            IList<Node> nodeList = new List<Node>();
            CellPosition position1 = new CellPosition(1, 1);
            CubeState state1 = CubeState.CUBE_STAND_BOTTOM;
            CellPosition position2 = new CellPosition(2, 1);
            CubeState state2 = CubeState.CUBE_STAND_BOTTOM;
            BoardSnapshot snapshot = new BoardSnapshot(new Dictionary<CellPosition, CubeState>()
            {
                { position1, state1 },
                { position2, state2 },
            });
            Node node = new Node(snapshot);
            nodeList.Add(node);
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                node = queue.Dequeue();
                snapshot = node.GetSnapshot();
                // 答えチェック
                if (isCorrectSnapshot(snapshot)) throw new Exception("Found!");
                // 各コマの次の一手を生成する
                foreach (var cube in snapshot)
                {
                    // 上下左右に動かしてみる
                    foreach (RollDirection direction in Enum.GetValues(typeof(RollDirection)))
                    {
                        // 移動可否判定を行う
                        var nextCubeState = Cube.Roll(cube.Value, direction);
                        var nextPosition = RollCubeFor(nextCubeState, cube.Key, direction);
                        if (nextPosition.Line < 0 || 2 < nextPosition.Line || nextPosition.Row < 0 || 2 < nextPosition.Row)
                        {
                            // 範囲外
                            continue;
                        }
                        // 衝突判定を行う
                        if (0 < (snapshot.GetBitBoard() & BoardSnapshot.CalcBitBoard(nextPosition, nextCubeState)))
                        {
                            // 衝突
                            continue;
                        }
                        // 衝突していなければ
                        // snapshot生成
                        // snapshotを複製
                        var childSnapshot = new BoardSnapshot(snapshot);
                        // 子ノード生成
                        var childNode = new Node(childSnapshot, node);
                        // 移動する前のコマを削除
                        childSnapshot.Remove(cube.Key);
                        // 移動したコマを追加
                        childSnapshot.Add(nextPosition, nextCubeState);
                        // 正誤判定を行う
                        if (isCorrectSnapshot(childSnapshot))
                        {
                            // 答え
                            DisplayNodes(childNode);
                            return;
                        }

                        // 重複判定
                        if (nodeList.Contains(childNode))
                        {
                            // 重複
                            continue;
                        }
                        // 木構造に追加
                        node.AddChild(childNode);
                        queue.Enqueue(childNode);
                    }
                }
            }
        }

        private static bool isCorrectSnapshot(BoardSnapshot snapshot)
        {
            foreach (var cube in snapshot)
            {
                switch (cube.Value)
                {
                    case CubeState.CUBE_STAND_UPPER:
                    case CubeState.CUBOID_X_PLUS_UPPER:
                    case CubeState.CUBOID_X_MINUS_UPPER:
                    case CubeState.CUBOID_Y_PLUS_UPPER:
                    case CubeState.CUBOID_Y_MINUS_UPPER:
                        break;
                    default:
                        // 一つでも表向きではないコマが存在すれば解では無い
                        return false;
                }
            }
            return true;
        }

        // コマを転がした先のマスが何処になるか計算するメソッド
        // 転がす方向と倒れている方向が一緒ならば１マスズレる
        private static CellPosition RollCubeFor(CubeState state, CellPosition fromPosition, RollDirection rollDirection)
        {
            CellPosition position = fromPosition;
            CubeDirection cubeDirection = Cube.getCubeDirection(state);

            switch (rollDirection)
            {
                case RollDirection.XMINUS:
                    position.Line--;
                    if (cubeDirection == CubeDirection.XMINUS) position.Line--;
                    break;
                case RollDirection.XPLUS:
                    position.Line++;
                    if (cubeDirection == CubeDirection.XPLUS) position.Line++;
                    break;
                case RollDirection.YMINUS:
                    position.Row--;
                    if (cubeDirection == CubeDirection.YMINUS) position.Row--;
                    break;
                case RollDirection.YPLUS:
                    position.Row++;
                    if (cubeDirection == CubeDirection.YPLUS) position.Row++;
                    break;
            }
            return position;
        }

        private static void DisplayNodes(INode node)
        {
            Debug.WriteLine("-------");
            String lineString = "";
            BoardSnapshot snapshot = node.GetSnapshot();
            for (var y = 0; y < 3; y++){
                for (var x = 0; x < 3; x++){
                    CellPosition position = new CellPosition(x, y);
                    if(snapshot.ContainsKey(position)) {
                        lineString = lineString + "|" + snapshot[position] + "\t";
                    }else{
                        lineString = lineString + "|\t\t\t";
                    }
                }
                lineString = lineString + "|\n";
            }
            Debug.WriteLine(lineString);
            if(node.GetParent() != null) {
                DisplayNodes(node.GetParent());
            }
        }
    }
}
