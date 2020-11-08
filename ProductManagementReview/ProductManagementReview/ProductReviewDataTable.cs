// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductReviewDataTable.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ProductManagementReview
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    /// <summary>
    /// Class to define the Product Review Management as Data table
    /// </summary>
    public class ProductReviewDataTable
    {
        /// <summary>
        /// UC8 -- Defining a static data table to define the fields of product review management
        /// </summary>
        public static DataTable productReviews = new DataTable();
        /// <summary>
        /// Method to Declare the colums in the data table directly rather defining the entire schema
        /// </summary>
        public static void AddingColumns()
        {
            /// Adding all the mentioned fields in the data table
            /// To note - Mentioned the data type explicitly 
            /// By default the data type is string
            productReviews.Columns.Add("ProductId", typeof(Int32));
            productReviews.Columns.Add("UserId", typeof(Int32));
            productReviews.Columns.Add("Rating", typeof(Int32));
            productReviews.Columns.Add("Review");
            productReviews.Columns.Add("isLike", typeof(bool));
        }
        /// <summary>
        /// Method to add the data to the table using randomly generated value
        /// </summary>
        public static void AddData()
        {
            for (int i = 0; i < 25; i++)
            {
                /// Declaring a random object to create random values for useId
                Random random = new Random();
                int randomProductId = random.Next(1, 10);
                int randomUserId = random.Next(1100, 1199);
                /// Creating random Product rating
                int randomRating = random.Next(0, 6);
                string review = "";
                /// Moderating the rating to an expression for revie
                /// from 0- Poor to 5- Excellent
                switch (randomRating)
                {
                    case 0:
                        review = "Poor";
                        break;
                    case 1:
                        review = "Fairly Poor";
                        break;
                    case 2:
                        review = "Average";
                        break;
                    case 3:
                        review = "Above Average";
                        break;
                    case 4:
                        review = "Good";
                        break;
                    case 5:
                        review = "Excellent";
                        break;
                    default:
                        break;
                }
                bool randomIsLike = random.Next(0, 2) > 0;
                /// Adding to the list of product reviews
                productReviews.Rows.Add(randomProductId, randomUserId, randomRating, review, randomIsLike);
            }
        }
        /// <summary>
        /// Method to display the entire data rows present in the data table
        /// </summary>
        public static void DisplayDataInTable()
        { 
            /// Iterating over the dara table by making it support the enumerable iteration
            foreach(var record in productReviews.AsEnumerable())
            {
                Console.WriteLine($"ProductId : {record.Field<int>("ProductId")}, UserId : {record.Field<int>("UserId")}, Rating : {record.Field<int>("Rating")}," +
                    $" Review : {record.Field<string>("Review")}, isLike: {record.Field<bool>("isLike")}");
            }
        }
        /// <summary>
        /// Method to get the data of the records from the product review data table with is like as true
        /// </summary>
        public static void DisplayRecordWithTrueIsLike()
        {
            /// LINQ query syntax to get the records with isLike as true
            var trueIsLike = (from product in productReviews.AsEnumerable()
                              where product.Field<bool>("isLike") == true select product);
            /// Iterating over records stored to print the reviews
            foreach(var review in trueIsLike)
            {
                Console.WriteLine($"ProductId : {review.Field<int>("ProductId")}, UserId : {review.Field<int>("UserId")}, Rating : {review.Field<int>("Rating")}," +
                    $" Review : {review.Field<string>("Review")}, isLike: {review.Field<bool>("isLike")}");
            }
        }
        /// <summary>
        /// Method to get the average rating for each product from the product review data table
        /// </summary>
        public static void DisplayAverageRatingForProductId()
        {
            /// LINQ query syntax to get the average rating of the products grouped by product id
            var displayCountOfProductReview = (from reviews in productReviews.AsEnumerable()
                              group reviews by reviews.Field<int>("ProductId") into Group
                              select new { ProductID = Group.Key, AverageRating = Group.Average(row => row.Field<int>("Rating")) });
            /// Iterating over records stored to print the reviews
            foreach (var review in displayCountOfProductReview)
            {
                Console.WriteLine($"ProductId : {review.ProductID}, Average Rating : {review.AverageRating}");
            }
        }
    }
}
