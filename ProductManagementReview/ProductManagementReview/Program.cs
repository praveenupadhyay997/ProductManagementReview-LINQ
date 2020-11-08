﻿// --------------------------------------------------------------------------------------------------------------------
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
            /// UC2 -- Get the top three highly rated record details
            productReview.DisplayTopThreeRatedProductReviewDetails();
            /// UC3 -- Get the product review for product rating greater than three and particular product Id
            productReview.DisplayTopProductReviewDetailsForGreaterThanThreeRating();
            /// UC4 -- Get the product review and product Id
            productReview.DisplayReviewCountForProductID();
            /// UC5 -- Get the product review and product id for the product review
            productReview.DisplayProductIDAndReview();
            /// UC6 -- Get the product review detail after skipping the first five records
            productReview.SkipTheTopFiveRecords();
            /// UC7 -- Get the product review and product Id Using the Lambda Syntax
            productReview.DisplayProductIDAndReviewUsingLambdaSyntax();
        }
    }
}