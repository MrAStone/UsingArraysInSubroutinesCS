namespace UsingArraysInSubroutinesCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[10];
            string[] b = createAStringArray(10);


        }
        static void PrintStringArray(string[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static string[] createAStringArray(int n)
        {
            string[] aNewArrayToCreate = new string[n];
            // code to fill array
            return aNewArrayToCreate;
        }
        static void changeArrayValues(string[] theArray)
        {
            for (int i = 0;i < theArray.Length;i++)
            {
                theArray[i] = "Some new text"; // this will change the values
            }
        }
    }
}