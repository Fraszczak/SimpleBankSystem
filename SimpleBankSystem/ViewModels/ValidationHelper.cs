using System.Collections.Generic;

namespace SimpleBankSystem.ViewModels
{
    public static class ValidationHelper
    {
        public static List<char> listOfLetter = new List<char>()
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'o', 'p', 'r', 's', 't', 'q', 'u', 'w', 'x', 'y',
            'z'
        };
        public static List<char> listOfLetterUppercase = new List<char>()
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
            'M', 'N', 'O', 'P', 'R', 'S', 'T', 'Q', 'U', 'W', 'X', 'Y',
            'Z'
        };
        public static List<char> listOfNumbers = new List<char>()
        {
            '1', '2', '3', '4', '5', '6', '7',
            '8', '9', '0'
        };

        public static List<char> listOfSpecialCharacters = new List<char>()
        {
            ',', '.', '?', ';', ':', '\'', '\\', '[', ']', '{', '}',
            '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-',
            '+', '~', '|', '/', '?',
        };

        public static List<string> listOfTitles = new List<string>()
        {
            "Mr", "Mis", "Miss", "Ms", "Mx", "Dr", "Lady", "Lord"
        };
    }
}