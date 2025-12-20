using CompositeProject.TreeClassLibrary;

namespace CompositeProject
{
    class ProgramCompsoite
    {
        public static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(5);
            tree.Add(12);
            tree.Add(1);
            tree.Add(7);
            tree.Add(0);
            tree.Add(8);
            tree.Add(2);
            tree.Add(6);
            Console.WriteLine($"Количество элементов = {tree.Count}");
            Console.WriteLine($"Высота дерева = {tree.Height()}");
            tree.Max();
            tree.Min();
            tree.IsEmptyString();
            tree.Contains(5);
            tree.Contains(3);
            Console.WriteLine("Элементы дерева в прямом порядке:");
            foreach (var value in tree)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            tree.ReverseDirection();
            Console.WriteLine("Элементы дерева в обратном порядке:");
            foreach (var value in tree)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            tree.Clear();
            Console.WriteLine($"Количество элементов = {tree.Count}");
            tree.IsEmptyString();
            Console.WriteLine("Элементы дерева в обратном порядке:");
            foreach (var value in tree)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}