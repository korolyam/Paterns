using Classes.Mazes;
using Classes.Mazes.MapSites.Rooms;
using Classes.Mazes.MapSites.Doors;
using Classes.Mazes.MapSites.Walls;
using Classes.Mazes.MapSites;
class MazeGame3

{
    static void Main()
    {
        MazeCreator creator;
        Console.WriteLine("Выберите лабиринт (1-обычный, 2-с закрытыми дверьми, 3-взорванный)");
        char press = Console.ReadKey().KeyChar;
        switch (press)
        {
            default:
                Console.WriteLine("Недопустимый ввод");
                creator = null;
                Main();
                break;
            case '1':
                creator = new CommonMazeCreator();
                break;
            case '2':
                creator = new EnchantedMazeCreator();
                break;
            case '3':
                creator = new BombedMazeCreator();
                break;
        }
        IMaze maze = creator.CreateMaze();
        Console.WriteLine("Выберите комнату (1 или 2)");
        press = Console.ReadKey().KeyChar;
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
    }
}
