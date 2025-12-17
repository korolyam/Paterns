using CompositeProject.TreeClassLibrary;

namespace CompositeProject
{
    class program
    {
        static void Main()
        {
            try
            {
                Composite root = new Composite(7);
                Composite node1 = new Composite(3);
                Composite node2 = new Composite(4);
                Leaf leaf1 = new Leaf(2);
                Leaf leaf2 = new Leaf(1);
                root.Add(node1);
                root.Add(leaf1);
                node1.Add(node2);
                node2.Add(leaf2);
                List<double> res1 = root.GetValueOfAllChildren();
                foreach (double value in res1)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
                node2.Remove(leaf2);
                node1.Add(leaf2);
                List<double> res2 = root.GetValueOfAllChildren();
                foreach (double value in res2)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}