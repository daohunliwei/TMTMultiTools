using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpHttpHelper;
using TMTMultiTools.Model;
using System.Diagnostics;

namespace TMTMultiTools.Common.Providers
{
    public static class WeiboProvider
    {
        public static string cookies = "";

        public static Dictionary<string, WeiboUserInfo> GetUIDByURLList(Action<int, UserProcessModel> processChange,params string[] urls)
        {
            Dictionary<string, WeiboUserInfo> result = new Dictionary<string, WeiboUserInfo>();
            try
            {
                int i = 0;
                Stopwatch stopwatch = new Stopwatch();
                foreach (var url in urls)
                {
                    ++i;
                    stopwatch.Restart();
                    var html = GetHtmlByUrl(url);
                    result.AddOrUpdate(url, GetInfoFromHtml(html));
                    stopwatch.Stop();
                    processChange(i, new UserProcessModel() { ProcessNum = i, ProcessStr = $"正在获取{url}所对应的数据", ReportStr = $"获取{url}所对应的数据耗时{stopwatch.Elapsed.TotalSeconds}秒\r\n" });
                }
            }
            catch (Exception ex)
            {
            }
            return result;
        }

        public static Dictionary<string, WeiboUserInfo> GetUIDByNameList(Action<int, UserProcessModel> processChange,params string[] names)
        {
            Dictionary<string, WeiboUserInfo> result = new Dictionary<string, WeiboUserInfo>();
            try
            {
                int i = 0;
                System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
                foreach (var name in names)
                {
                    ++i; 
                    stopwatch.Restart();
                    result.AddOrUpdate(name, SearchWeibo(name));
                    stopwatch.Stop();
                    processChange(i, new UserProcessModel() { ProcessNum = i, ProcessStr = $"正在获取{name}所对应的数据",ReportStr=$"获取{name}所对应的数据耗时{stopwatch.Elapsed.TotalSeconds}秒\r\n"});
                }
            }
            catch (Exception ex)
            {
            }
            return result;
        }

        /// <summary>
        /// 根据微博的昵称获取相关信息
        /// </summary>
        /// <param name="nickName"></param>
        /// <param name="IsMohu">是否模糊匹配，模糊的话，会返回匹配列表的第一个</param>
        /// <returns></returns>
        private static WeiboUserInfo SearchWeibo(string nickName)
        {
            try
            {
                string url = "http://s.weibo.com/ajax/topsuggest.php?key=" + nickName;
                string html = GetHtmlByUrl(url);
                var test = HttpHelper.GetBetweenHtml(html, "try{window.&(", ");}catch");
                test = test.Remove(0, 1);
                test = test.Remove(test.Length - 1, 1);//掐头去尾两个()
                QuickSearchReturnModel model = Newtonsoft.Json.JsonConvert.DeserializeObject<QuickSearchReturnModel>(test);
                if (model != null)
                {
                    if (model.UserData != null && model.UserData.UserList.Any())
                    {
                        //说明有数据，那就开始匹配
                        WeiboUserInfo userInfo = model.UserData.UserList.First();
                        userInfo.IsTruly = false;
                        foreach (var item in model.UserData.UserList)
                        {
                            if (item.NickName == nickName)
                            {
                                userInfo = item;
                                //100%匹配
                                userInfo.IsTruly = true;
                                break;
                            }
                        }
                        return userInfo;
                    }
                }
            }
            catch (Exception ex)
            { }
            return new WeiboUserInfo() { IsTruly = false, UID = "-1" };//这个代表了没有返回值，匹配度为0
        }

        private static WeiboUserInfo GetInfoFromHtml(string html)
        {
            try
            {
                string uid = HttpHelper.GetBetweenHtml(html, "oid']='", "';");
                if (!string.IsNullOrEmpty(uid))
                {
                    string nick = HttpHelper.GetBetweenHtml(html, "onick']='", "';");
                    return new WeiboUserInfo() { UID = uid, NickName = nick, IsTruly = true };
                }
            }
            catch (Exception ex)
            {
            }
            return new WeiboUserInfo() { UID = "-1", IsTruly = false }; 
        }


        private static string GetHtmlByUrl(string url)
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
                    UserAgent = "spider"
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

        public static void Test(int value,Action<int> func)
        {
            func(value);
        }
    }
}
