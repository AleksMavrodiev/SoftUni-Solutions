using System;
using System.Linq;

namespace _9.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine());
            int[] bestSequence = new int[sequenceLength];
            int bestSequenceIndex = 0;
            string command = string.Empty;
            int maxStreak = 0;
            int bestSequenceCount = 0;
            int counter = 0;

            while ((command = Console.ReadLine()) != "Clone them!")
            {
                counter++;
                int[] sequence = command.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int i = 0; i < sequenceLength; i++)
                {
                    int currentStreak = 1;
                    for (int j = i + 1; j < sequenceLength; j++)
                    {
                        if (sequence[i] == sequence[j])
                        {
                            currentStreak++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (currentStreak > maxStreak)
                    {
                        bestSequenceCount = counter;
                        maxStreak = currentStreak;
                        bestSequence = sequence;
                        bestSequenceIndex = i;
                    }
                    else if(currentStreak == maxStreak)
                    {
                        if (i < bestSequenceIndex)
                        {
                            bestSequenceCount = counter;
                            maxStreak = currentStreak;
                            bestSequence = sequence;
                            bestSequenceIndex = i;
                        }
                        else if (i == bestSequenceIndex)
                        {
                            if (sequence.Sum() > bestSequence.Sum())
                            {
                                bestSequence = sequence;
                                bestSequenceCount = counter;
                            }
                        }
                    }

                }
            }
            Console.WriteLine($"Best DNA sample {bestSequenceCount} with sum: {bestSequence.Sum()}.");
            Console.WriteLine(String.Join(' ', bestSequence));
        }
    }
}
