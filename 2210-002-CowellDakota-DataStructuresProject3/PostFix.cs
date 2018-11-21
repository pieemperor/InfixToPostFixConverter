///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject3/DataStructuresProject3
//	File Name:         PostFix.cs
//	Description:       Used to convert expressions from Infix Expressions to PostFix Expressions - Uses the operator class to help with this
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Dakota Cowell, cowelld@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Thursday, November 1, 2018
//	Copyright:         Dakota Cowell, 2018
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2210_002_CowellDakota_DataStructuresProject3
{
    /// <summary>
    /// Class to help with converting from Infix Notation to PostFix Notation
    /// </summary>
    class PostFix
    {
        public string InfixExpression { get; set; }
        public string PostFixExpression { get; set; }

        /// <summary>
        /// Default constructor
        /// Sets Properties to default values
        /// </summary>
        public PostFix()
        {
            InfixExpression = "";
            PostFixExpression = "";
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="input">Infix Expression to be converted</param>
        public PostFix(string input)
        {
            InfixExpression = input;
        }

        /// <summary>
        /// Converts InfixExpression to Postfix Expression
        /// </summary>
        /// <returns>PostFix Expression that has been converted</returns>
        public string Convert()
        {
            //Initialize PostFix Expression to null
            PostFixExpression = null;

            //Split the input into a list of tokens using the Parse Method
            List<string> expressionList = Parse(InfixExpression, " +-*/()=");

            //Initialize a list of possible operators
            List<string> operators = new List<string>{ "+", "-", "*", "/", "(", ")", "=" };

            //Initialize empty stack of operators
            Stack<Operator> operatorStack = new Stack<Operator>();

            //Loop through each token in the list of tokens
            foreach(string token in expressionList)
            {
                //If string is an operator, create Operator object and perform operations based on it
                if (operators.Contains(token))
                {
                    //Create new operator from string
                    Operator op = new Operator(token);

                    //If operator = ( Push it to the stack
                    if(op.Op == "(")
                    {
                        operatorStack.Push(op);
                    }
                    //If operator = ) pop the stack until an open parenthesis is found.
                    else if(op.Op == ")")
                    {
                        //Pop the stack until it is empty or until an open parenthesis is found
                        while(operatorStack.Count != 0 && operatorStack.Peek().Op != "(")
                        {
                            PostFixExpression += operatorStack.Pop().Op + " ";
                        }

                        //If there is nothing left in the stack, no ( was found, and set PostFix Expression to an error
                        if(operatorStack.Count == 0)
                        {
                            PostFixExpression = "***Error***   Unmatched closed parenthesis in expression";
                            return PostFixExpression;
                        }

                        //If open parenthesis is on top of the stack, pop it
                        if(operatorStack.Peek().Op == "(")
                        {
                            operatorStack.Pop();
                        }
                    }
                    //Otherwise, Pop the stack until an operator with lower precedence is found, an open parenthesis is found, or the stack is empty
                    else
                    {
                        //Pop the stack until an operator with lower precedence is found, an open parenthesis is found, or the stack is empty
                        while (operatorStack.Count != 0 && operatorStack.Peek().Precedence >= op.Precedence && operatorStack.Peek().Op != "(")
                        {
                            PostFixExpression += operatorStack.Pop().Op + " ";
                        }
                        //Then, push the operator onto the stack
                        operatorStack.Push(op);
                    }
                }
                //token is not an operator so append to PostFix Expression
                else
                {
                    PostFixExpression += token + " ";
                }
            }

            //Pop the remaining items on the stack and add them to the PostFix Expression
            while(operatorStack.Count != 0)
            {
                if(operatorStack.Peek().Op != "(")
                {
                    PostFixExpression += operatorStack.Pop().Op + " ";
                } else
                {
                    //An open parenthesis was found without a closed parenthesis - Return an error
                    PostFixExpression = "***Error*** Unmatched open parenthesis in expression";
                    return PostFixExpression;
                }
            }
            return PostFixExpression;
        }

        /// <summary>
        /// Splits a string into a List of words based on the delimiters passed
        /// </summary>
        /// <param name="original">Original string to be parsed for words</param>
        /// <param name="delimiters">Delimiters to split the string on</param>
        /// <returns>Returns a list of words that were in the original string</returns>
        public static List<String> Parse(string original, string delimiters)
        {
            //Copy original into temp variable
            string temp = original;

            //Initialize List<string>
            List<string> words = new List<string>();

            //Split delimiters string into array of characters to be used in IndexOfAny
            var delims = delimiters.ToCharArray();

            //loop until the temp string is empty
            while (!String.IsNullOrEmpty(temp))
            {
                //Find index of first delimiter in temp
                var index = temp.IndexOfAny(delims);

                //If the position of the delimiter is greater than 0, add everything before the delimiter as a word. Then remove the word from temp
                if (index > 0)
                {
                    words.Add(temp.Substring(0, index));
                    temp = temp.Substring(index);
                }
                //If the position of the delimiter = 0, add the delimiter to the words list if it's not a space or new line
                else if (index == 0)
                {
                    if (temp.Substring(0, index + 1) != " " && temp.Substring(0, index + 1) != "\n")
                    {
                        words.Add(temp.Substring(0, index + 1));
                        temp = temp.Substring(index + 1);
                    }
                    else
                    {
                        temp = temp.Substring(index + 1);
                    }
                }
                //If there is not another delimiter, add the rest of temp to the words list
                else if (index == -1)
                {
                    words.Add(temp);
                    temp = "";
                }

                //Trim leading and trailing spaces or new line characters
                temp.Trim(new char[] { ' ', '\t', '\r' });
            }

            return words;
        }

    }
}
