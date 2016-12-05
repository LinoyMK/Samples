using StructVsClass.Data;
using System;

namespace StructVsClass.RealTime
{
    public class RealTimeHandler
    {
        public void Check()
        {
            Console.WriteLine("Effective way to handle the null using struct");

            Option<Article> optionalArticle = GetValidArticleFromOtherLayer();
            string articleName = optionalArticle.HasValue ? optionalArticle.Value.Name : "no article";
            Console.WriteLine($"With Valid article : HasValue {optionalArticle.HasValue} : ArticleName : {articleName}");

            Option<Article> optionalNullArticle = new Option<Article>(null);
            string nullArticleName = optionalNullArticle.HasValue ? optionalNullArticle.Value.Name : "no article";
            Console.WriteLine($"With Null article : HasValue {optionalNullArticle.HasValue} : ArticleName : {nullArticleName}");


        }

        private Option<Article> GetValidArticleFromOtherLayer()
        {
            Article article = new Article()
            {
                Id = 1,
                Name = "Linoy"
            };

            return new Option<Article>(article);
        }
    }
}
