namespace VariableOgDatatyper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 16;
            double width = 5.1;
            Console.WriteLine(length + width); // resultatet er 21.1

            int area = length * width;
            /** Visual Studios compiler vil ikke oversætte din kode, men hvorfor?
             * double x int = double.
             * int kan kun indeholde heltal hvorfor du ikke kan assign en double til en int. 
             * Jeg er nødt til at caste datatyppen for at det skal kunne virke.
             * Dette kan jeg gøre enten med (int) eller Convert.ToInt32(width).
            */

            double d = width * length;
            /** Her vil Visual Studio gerne oversætte din kode, men hvorfor nu det?
             * double x int = double.
             */

            Console.WriteLine(d); //resultatet er 81.6
        }
    }
}