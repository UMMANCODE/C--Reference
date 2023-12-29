using System;

namespace ConsoleApp11 {
    internal class Program {
        static void Main(string[] args) {

            int number = 5;
            Square(ref number);
            Console.WriteLine(number);

            int[] numbers = { 1, 2, 3, 4, 5 };
            Square(ref numbers);
            for (int i = 0; i < numbers.Length; i++) {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            string text = "   Hello World   ";
            RemoveSpaces(ref text);
            Console.WriteLine(text);

            int[] numbers2 = { 1, 2, 3, 4, 5 };
            AddElement(ref numbers2, 6);
            for (int i = 0; i < numbers2.Length; i++) {
                Console.Write($"{numbers2[i]} ");
            }
            Console.WriteLine();

        }

        #region Task1

        // Verilmiş ədədi kvadratına yüksəldən metod

        static void Square(ref int number) {
            number *= number;
        }

        #endregion

        #region Task2

        // Verilmiş ədədlər siyahısını içindəki bütün ədədlər kvadratına yüksəlmiş array-ə çevirən metod

        static void Square(ref int[] numbers) {
            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] *= numbers[i];
            }
        }

        #endregion

        #region Task3

        // Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod

        static void RemoveSpaces(ref string text) {
            string newText = "";
            for (int i  = 0; i < text.Length; i++) {
                if (text[i] != ' ') newText += text[i];
            }
            text = newText;
        }

        #endregion

        #region Task4

        // Parameter olaraq integer array variable-i ve bir integer value qebul eden ve hemin integer value-nu integer array-e yeni element kimi elave eden metod

        static void AddElement(ref int[] numbers, int number) {
            int[] newNumbers = new int[numbers.Length + 1];
            for (int i = 0; i < numbers.Length; i++) {
                newNumbers[i] = numbers[i];
            }
            newNumbers[newNumbers.Length - 1] = number;
            numbers = newNumbers;
        }

        #endregion
    }
}
