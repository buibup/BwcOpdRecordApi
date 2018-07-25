using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data
{
    public static class Extensions
    {
        public static string GetContentTypeByDocType(this string docType)
        {
            string extension = docType;
            string contenttype = String.Empty;

            switch (extension.ToLower())
            {
                case "doc":
                    contenttype = "application/vnd.ms-word";
                    break;
                case "docx":
                    contenttype = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                    break;
                case "xls":
                    contenttype = "application/vnd.ms-excel";
                    break;
                case "xlsx":
                    contenttype = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    break;
                case "jpg":
                    contenttype = "image/jpg";
                    break;
                case "jpeg":
                    contenttype = "image/jpg";
                    break;
                case "png":
                    contenttype = "image/png";
                    break;
                case "gif":
                    contenttype = "image/gif";
                    break;
                case "pdf":
                    contenttype = "application/pdf";
                    break;
                case "txt":
                    contenttype = "application/text";
                    break;
                case "html":
                    contenttype = "application/html";
                    break;
            }

            return contenttype;
        }

        public static IEnumerable<TSource> DistinctBy<TSource, TKey>
            (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
    }
}
