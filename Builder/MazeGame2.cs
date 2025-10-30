using Classes.Mazes;
using Classes.Mazes.MapSites.Rooms;
using Classes.Mazes.MapSites.Doors;
using Classes.Mazes.MapSites.Walls;
using Classes.Mazes.MapSites;

namespace Builder;
class MazeGame2
{
    static void Main()
    {
        IMazeBuilder builder = new StandartMazeBuilder();
        Director director = new Director(builder);
        IMaze maze = director.CreateSimpleMaze();
        IMaze bigMaze = director.CreateBigMaze();
        Console.WriteLine("Выберите комнату (1 или 2)");
        char press = Console.ReadKey().KeyChar;
        char press2;
        switch (press)
        {
            default:
                Console.WriteLine("Недопустимый ввод");
                Main();
                break;
            case '1':
                press2 = Console.ReadKey().KeyChar;
                switch (press2)
                {
                    default:
                        Console.WriteLine("Недопустимый ввод");
                        Main();
                        break;
                    case 'w':
                        maze.GetRoomFromItsInternalId(0).Enter(Direction.North);
                        break;
                    case 'a':
                        maze.GetRoomFromItsInternalId(0).Enter(Direction.West);
                        break;
                    case 's':
                        maze.GetRoomFromItsInternalId(0).Enter(Direction.South);
                        break;
                    case 'd':
                        maze.GetRoomFromItsInternalId(0).Enter(Direction.East);
                        break;
                }
                break;
            case '2':
                press2 = Console.ReadKey().KeyChar;
                switch (press2)
                {
                    default:
                        Console.WriteLine("Недопустимый ввод");
                        Main();
                        break;
                    case 'w':
                        maze.GetRoomFromItsInternalId(1).Enter(Direction.North);
                        break;
                    case 'a':
                        maze.GetRoomFromItsInternalId(1).Enter(Direction.West);
                        break;
                    case 's':
                        maze.GetRoomFromItsInternalId(1).Enter(Direction.South);
                        break;
                    case 'd':
                        maze.GetRoomFromItsInternalId(1).Enter(Direction.East);
                        break;
                }
                break;
        }
        bigMaze.GetRoomFromItsInternalId(56).Enter(Direction.North);
    }
}
