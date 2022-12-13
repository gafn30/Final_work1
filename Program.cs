using System;
using static System.Console;

Clear();

string[] array = AskArray();
string[] result = FindLessThan(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindLessThan(string[] input, int c) {
    string[] output = new string[CountLessThan(input, c)];

    for(int a = 0, b = 0; a < input.Length; a++) {
        if(input[a].Length <= c) {
            output[b] = input[a];
            b++;
        }
    }

    return output;
}

int CountLessThan(string[] input, int c) {
    int count = 0;

    for(int a = 0; a < input.Length; a++) {
        if(input[a].Length <= c) {
            count++;
        }
    }

    return count;
}

string[] AskArray() {
    Write("Введите значения через пробел: ");
    return ReadLine().Split(" ");
}
