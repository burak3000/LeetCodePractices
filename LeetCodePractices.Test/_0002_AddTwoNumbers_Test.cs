using System;
using LeetCodePractices.Impl;
namespace LeetCodePractices.Test
{
    public class _0002_AddTwoNumbers_Test
    {
        
        [TestCase("243", "564", "708")]
        [TestCase("0", "0", "0")]
        [TestCase("9999999", "9999", "89990001")]
        [TestCase("999", "12", "0201")]
        [TestCase("563", "563", "037")]

        public void AddTwoNumbers(string firstNums, string secondNums, string expected)
        {

            List<int> firstNum = new List<int>();
            for (int i = 0; i < firstNums.Length; i++)
            {
                firstNum.Add(int.Parse(firstNums[i].ToString()));
            }

            List<int> secondNum = new List<int>();
            for (int i = 0; i < secondNums.Length; i++)
            {
                secondNum.Add(int.Parse(secondNums[i].ToString()));
            }
            ListNode a = null;
            for(int i = firstNum.Count -1; i >= 0; i--)
            {
                a = new ListNode(firstNum[i], a);
            }
            ListNode b = null;
            for (int i = secondNum.Count - 1; i >= 0; i--)
            {
                b = new ListNode(secondNum[i], b);
            }

            _0002_AddTwoNumbers adder = new _0002_AddTwoNumbers();
            var resultNode = adder.AddTwoNumbers(a, b);

            Assert.That(resultNode.GetAsString(), Is.EqualTo(expected));

        }

    }
}

