using System;

namespace DataStructureExamples.Stacks
{
    public class DynamicStackInteger
    {
        static int initialLenght = 5;
        int[] stackItems = new int[initialLenght];
        int top = -1;

        public void Push(int value)
        {
            if (IsFull())
            {
                int[] newArray = new int[initialLenght * 2];

                stackItems.CopyTo(newArray, 0);
                stackItems = newArray;
            }

            stackItems[++top] = value;
        }

        public int Pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("The Stack is empty");
            }

            return stackItems[top--];
        }

        public int Peek()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("The Stack is empty");
            }

            return stackItems[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == initialLenght - 1;
        }
    }
}
