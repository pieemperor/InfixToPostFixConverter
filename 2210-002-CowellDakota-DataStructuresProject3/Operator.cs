///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject3/DataStructuresProject3
//	File Name:         Operator.cs
//	Description:       Class to help compare operators based on their precedence
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
    /// Operator class to help compare operators based on their precedence
    /// </summary>
    class Operator
    {
        //String value of the operator
        public string Op { get; set; }
        public int Precedence { get; set; }

        /// <summary>
        /// Default Constructor
        /// Sets Properties to default values
        /// </summary>
        public Operator()
        {
            Op = "";
            Precedence = -1;
        }

        /// <summary>
        /// Parameterized constructor for creating an operator
        /// </summary>
        /// <param name="op">String representation of an operator</param>
        public Operator(string op)
        {
            Op = op;
            //Set precedence based on the operator
            if (op == "=")
            {
                Precedence = 1;
            } else if(op == "+" || op == "-")
            {
                Precedence = 2;
            } else if (op == "*" || op == "/")
            {
                Precedence = 3;
            } else if(op == "(" || op == ")")
            {
                Precedence = 4;
            }
        }
    }
}
