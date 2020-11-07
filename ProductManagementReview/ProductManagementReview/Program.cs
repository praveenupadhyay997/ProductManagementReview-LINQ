// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ProductManagementReview
{
    using System;
    class Program
    {
        /// <summary>
        /// Main Driver function
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Welcome to Product Review Program");
            Console.WriteLine("===================================");
            /// Creating the instance of the product review repository
            ProductReviewRepository productReview = new ProductReviewRepository();
            /// Printing the details stored inside the reviews
            productReview.DisplayTheProductReviewDetails();
        }
    }
}