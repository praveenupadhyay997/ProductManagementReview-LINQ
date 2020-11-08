// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductReviewRepository.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ProductManagementReview
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Class to store the list of the reviews passed by the user of ProductReviewClass type
    /// </summary>
    public class ProductReviewRepository
    {
        /// <summary>
        /// List containing the product reiews of the users
        /// </summary>
        public static List<ProductReviewClass> productReviews = new List<ProductReviewClass>();
        /// <summary>
        /// Default Constructor to initialise the instance with 25 default values adding the values to the list
        /// </summary>
        public ProductReviewRepository()
        {
            for (int i = 0; i < 25; i++)
            {
                /// Declaring a random object to create random values for useId
                Random random = new Random();
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
                /// Adding to the list of product reviews
                productReviews.Add(new ProductReviewClass(i + 1000, randomUserId, randomRating, review));
            }
        }
        /// <summary>
        /// Method to display the entire product review by the users
        /// </summary>
        public void DisplayTheProductReviewDetails()
        {
            /// Iterating over the entire list
            /// Displaying the product reviews
            foreach (var record in productReviews)
            {
                Console.WriteLine($"ProductId : {record.productId}, UserId : {record.userId}, Rating : {record.rating}, Review : {record.review}");
            }
        }
        /// <summary>
        /// UC2 -- Method to display the entire product review by the users for top 3 highly rated products
        /// </summary>
        public void DisplayTopThreeRatedProductReviewDetails()
        {
            ///Query to get the top highly rated product review details
            var topThreeRated = (from reviews in productReviews.AsEnumerable()
                                 orderby reviews.rating descending
                                 select reviews).Take(3);
            /// Iterating over the entire list
            /// Displaying the product reviews
            foreach (var record in topThreeRated)
            {
                Console.WriteLine($"ProductId : {record.productId}, UserId : {record.userId}, Rating : {record.rating}, Review : {record.review}");
            }
        }
        /// <summary>
        /// UC3 -- Method to display the entire product review by the users for three plus rating and product id = 1001,1004 or 1009
        /// </summary>
        public void DisplayTopProductReviewDetailsForGreaterThanThreeRating()
        {
            ///Query to get product review details with rating greater than three and particular id
            var threePlusRatingAndSpecificId = (from reviews in productReviews.AsEnumerable()
                                                where (reviews.rating > 3) && (reviews.productId == 1001 || reviews.productId == 1004 || reviews.productId == 1009)
                                                select reviews);
            /// Iterating over the entire list
            /// Displaying the product reviews
            foreach (var record in threePlusRatingAndSpecificId)
            {
                Console.WriteLine($"ProductId : {record.productId}, UserId : {record.userId}, Rating : {record.rating}, Review : {record.review}");
            }
        }
        /// <summary>
        /// UC4 -- Method to display the entire count of number of reviews by productId
        /// </summary>
        public void DisplayReviewCountForProductID()
        {
            ///Query to get number of product review details  grouped by same productId
            var threePlusRatingAndSpecificId = (from reviews in productReviews.AsEnumerable()
                                                group reviews by reviews.productId into Group
                                                select new {ProductID = Group.Key, NumberOfReviews = Group.Count()});
            /// Iterating over the entire stored value with count and productId
            /// Displaying the reviews count
            foreach (var record in threePlusRatingAndSpecificId)
            {
                Console.WriteLine($"ProductId : {record.ProductID}, Number Of Reviews : {record.NumberOfReviews}");
            }
        }
        /// <summary>
        /// UC5 -- Method to display the reviews and productId
        /// </summary>
        public void DisplayProductIDAndReview()
        {
            ///Query to get number of product review details  grouped by same productId
            var productIDAndReview = (from reviews in productReviews.AsEnumerable()
                                                select new { ProductID = reviews.productId, Review = reviews.review});
            /// Iterating over the entire stored value with review and productId
            /// Displaying the reviews count
            foreach (var record in productIDAndReview)
            {
                Console.WriteLine($"ProductId : {record.ProductID}, Review : {record.Review}");
            }
        }
        /// <summary>
        /// UC6 -- Method to display the product review detail by skipping the top five records
        /// </summary>
        public void SkipTheTopFiveRecords()
        {
            ///Query to get the product review detail skipping the first five records
            var topThreeRated = (from reviews in productReviews.AsEnumerable()
                                 select reviews).Skip(5);
            /// Iterating over the entire list
            /// Displaying the product reviews
            foreach (var record in topThreeRated)
            {
                Console.WriteLine($"ProductId : {record.productId}, UserId : {record.userId}, Rating : {record.rating}, Review : {record.review}");
            }
        }
        /// <summary>
        /// UC7 -- Method to display the reviews and productId using the lambda expression syntax
        /// </summary>
        public void DisplayProductIDAndReviewUsingLambdaSyntax()
        {
            ///Query to get number of product review details  grouped by same productId
            var productIDAndReview = productReviews.Select (reviews => new { ProductID = reviews.productId, Review = reviews.review });
            /// Iterating over the entire stored value with review and productId
            /// Displaying the reviews count
            foreach (var record in productIDAndReview)
            {
                Console.WriteLine($"ProductId : {record.ProductID}, Review : {record.Review}");
            }
        }
    }
}