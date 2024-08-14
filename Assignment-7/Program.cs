namespace Assignment_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            
            int[] A1 = { 5, 3, -6, -4, 10, 2 };
            Console.WriteLine(sol.solution(A1)); 

            int[] A2 = { 1, 2, 3 };
            Console.WriteLine(sol.solution(A2)); 

            int[] A3 = { -1, -3 };
            Console.WriteLine(sol.solution(A3)); 
        }
    }
}
