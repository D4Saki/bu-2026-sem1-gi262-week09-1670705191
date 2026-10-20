using System;
using System.Collections.Generic;

namespace Assignment
{
    public class StudentSolution
    {
        class Action
        {
            public string Name;
            public int Value;
        }

        #region Lecture

        public (int Count, int Popped, int Peek, int CountAfterPeek) LCT01_StackSyntax()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int count = stack.Count;

            int popped = stack.Pop();

            int peek = stack.Peek();
            int countAfterPeek = stack.Count;

            return (count, popped, peek, countAfterPeek);
        }

        public (int Count, int Dequeued, int Peek, int CountAfterPeek) LCT02_QueueSyntax()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            int count = queue.Count;

            int dequeued = queue.Dequeue();

            int peek = queue.Peek();
            int countAfterPeek = queue.Count;

            return (count, dequeued, peek, countAfterPeek);
        }

        public string[] LCT03_ActionStack()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };
            Stack<Action> actionStack = new Stack<Action>();

            actionStack.Push(action1);
            actionStack.Push(action2);
            actionStack.Push(action3);

            List<string> result = new List<string>();

            while (actionStack.Count > 0)
            {
                result.Add(actionStack.Pop().Name);
            }

            return result.ToArray();
        }

        public string[] LCT04_ActionQueue()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };
            Queue<Action> actionQueue = new Queue<Action>();

            actionQueue.Enqueue(action1);
            actionQueue.Enqueue(action2);
            actionQueue.Enqueue(action3);

            List<string> result = new List<string>();

            while (actionQueue.Count > 0)
            {
                result.Add(actionQueue.Dequeue().Name);
            }

            return result.ToArray();
        }

        #endregion

        #region Assignment

        public string ASN01_ReverseString(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                stack.Push(c);
            }

            char[] reversedChars = new char[str.Length];
            int index = 0;
            while (stack.Count > 0)
            {
                reversedChars[index++] = stack.Pop();
            }

            return new string(reversedChars);
        }

        public bool ASN02_StackPalindrome(string str)
        {
            string reversed = ASN01_ReverseString(str);

            return str.Equals(reversed);
        }

        #endregion

        #region Extra

        public bool EX01_ParenthesesChecker(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();

                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        #endregion
    }
}
