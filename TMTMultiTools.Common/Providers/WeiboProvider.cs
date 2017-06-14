using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpHttpHelper;

namespace TMTMultiTools.Common.Providers
{
    public static class WeiboProvider
    {
        public static string cookies = "";
        public static string GetHtmlByUrl(string url)
        {
            string resultHtml = "";
            try
            {
                //创建Httphelper对象
                HttpHelper http = new HttpHelper();
                //创建Httphelper参数对象
                HttpItem item = new HttpItem()
                {
                    URL = url,//URL     必需项    
                    Method = "get",//URL     可选项 默认为Get   
                    ContentType = "text/html",//返回类型    可选项有默认值   
                    Allowautoredirect = true,
                    AutoRedirectCookie = true,
                    Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8",
                    UserAgent="spider"
                    //UserAgent = string.IsNullOrEmpty(cookies)?"spider": "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/59.0.3071.86 Safari/537.36"
                    //ContentType = "application/x-www-form-urlencoded",//返回类型    可选项有默认值   
                };
                //请求的返回值对象
                HttpResult result = http.GetHtml(item);
                //获取请请求的Html
                resultHtml = result.Html;
                if (string.IsNullOrEmpty(cookies))
                {
                    cookies = result.Cookie; 
                }
               
            }
            catch (Exception ex)
            { }
            return resultHtml;
        }

        public static Dictionary<string,string> GetUIDByURLList(params string[] urls)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            try
            {
                foreach (var url in urls)
                {
                    var html = GetHtmlByUrl(url);
                    var oid = GetoidByHtml(html);
                    var onick = GetonickByHtml(html);
                    if (result.ContainsKey(oid))
                        result[oid] = onick;
                    else
                        result.Add(oid, onick);
                }
            }
            catch (Exception ex)
            {
            }
            return result;
        }

        private static string GetoidByHtml(string html)
        {
            string result = string.Empty;
            try
            {
                return HttpHelper.GetBetweenHtml(html, "oid']='", "';");
            }
            catch (Exception ex)
            {
            }
            return result;
        }

        private static string GetonickByHtml(string html)
        {
            string result = string.Empty;
            try
            {
                return HttpHelper.GetBetweenHtml(html, "onick']='", "';");
            }
            catch (Exception ex)
            {
            }
            return result;
        }
    }
}
