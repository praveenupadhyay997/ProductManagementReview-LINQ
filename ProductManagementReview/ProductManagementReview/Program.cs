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
        public static void ClassInterpretation()
        {
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
        public static void DataTableInterpretation()
        {
            /// By default adding of column is required to initiate the process of performing the data operation
            /// Additionally we can define the adding of column and adding data in static constructor of ProductReviewDataTable.cs
            /// So as to execute it automatically when the first instance of the Product Review Data Table Class is created
            ProductReviewDataTable.AddingColumns();
            ProductReviewDataTable.AddData();
            ProductReviewDataTable.DisplayDataInTable();
            ///UC2 -- Getting all the product reviews for is like as true
            ProductReviewDataTable.DisplayRecordWithTrueIsLike();
        }
            /// <summary>
            /// Main Driver function
            /// </summary>
            /// <param name="args"></param>
            static void Main(string[] args)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Welcome to Product Review Program");
            Console.WriteLine("===================================");
            Console.WriteLine("1. List Interpretation.");
            Console.WriteLine("2. Data Table Interpretation.");
            int choice = Convert.ToInt32(Console.ReadLine());
            /// Enabling the user choice to work on different platforms
            switch(choice)
            {
                case 1:
                    Program.ClassInterpretation();
                    break;
                case 2:
                    Program.DataTableInterpretation();
                    break;
                default:
                    break;
            }
        }
    }
}