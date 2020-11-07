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
    using System.Text;
    /// <summary>
    /// Class defining the review attributes inside the customer review
    /// </summary>
    public class ProductReviewClass
    {
        /// <summary>
        /// Member Data Attribute of the review to be fed by users
        /// </summary>
        public int productId;
        public int userId;
        public int rating;
        public string review;
        /// <summary>
        /// PArameterised constructor initialising the instance of the Product Review Class
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="userId"></param>
        /// <param name="rating"></param>
        /// <param name="review"></param>
        public ProductReviewClass(int productId, int userId, int rating, string review)
        {
            this.productId = productId;
            this.userId = userId;
            this.rating = rating;
            this.review = review;
        }
    }
}