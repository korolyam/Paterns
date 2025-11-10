using Classes.Mazes;
using Classes.Mazes.MapSites;
using Prototype;
using Classes.Mazes.MapSites.Rooms;
using Classes.Mazes.MapSites.Doors;
using Classes.Mazes.MapSites.Walls;

namespace Prototype
{
    class MazeGame4
    {
        static IMaze CreateMaze(MazePrototypeFactory factory)
        {
            IMaze aMaze = factory.MakeMaze();
            Room r1 = factory.MakeRoom(0);
            Room r2 = factory.MakeRoom(1);
            IDoor aDoor = factory.MakeDoor(r1, r2);
            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);
            r1.SetSide(Direction.North, factory.MakeWall());
            r1.SetSide(Direction.East, aDoor);
            r1.SetSide(Direction.South, factory.MakeWall());
            r1.SetSide(Direction.West, factory.MakeWall());
            r2.SetSide(Direction.North, factory.MakeWall());
            r2.SetSide(Direction.East, factory.MakeWall());
            r2.SetSide(Direction.South, factory.MakeWall());
            r2.SetSide(Direction.West, aDoor);
            return aMaze;
        }

        static void Main()
        {
            MazePrototypeFactory factory;
            Console.WriteLine("Выберите лабиринт (1-обычный, 2-с закрытыми дверьми, 3-взорванный)");
            char press = Console.ReadKey().KeyChar;
            switch (press)
            {
                default:
                    Console.WriteLine("Недопустимый ввод");
                    factory = null;
                    Main();
                    break;
                case '1':
                    factory = new MazePrototypeFactory(new Maze(), new CommonWall(), new CommonRoom(0), new CommonDoor(new CommonRoom(1), new CommonRoom(2)));
                    break;
                case '2':
                    factory = new MazePrototypeFactory(new Maze(), new CommonWall(), new EnchantedRoom(0, new Spell()), new DoorNeedingSpell(new EnchantedRoom(1,new Spell()), new EnchantedRoom(2, new Spell())));
                    break;
                case '3':
                    factory = new MazePrototypeFactory(new Maze(), new BombedWall(), new RoomWithABomb(0), new CommonDoor(new CommonRoom(1), new CommonRoom(2)));
                    break;
            }
            IMaze maze = CreateMaze(factory);
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
}