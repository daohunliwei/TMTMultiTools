﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMTMultiTools
{
    public static class StaticExtension
    {
        /// <summary>
        /// 转成Json
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJson(this object obj)
        {
            string result = string.Empty;
            try
            {
                result = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            }
            catch (Exception ex)
            {
                //TODO:记录下来
            }
            return result;
        }
        /// <summary>
        /// 转成Json
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T ToInstance<T>(this string jsonValue)
        {
            T result = default(T);
            try
            {
                result = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonValue);
            }
            catch (Exception ex)
            {
                //TODO:记录下来
            }
            return result;
        }

        public static int FindIndexByKey<T>(this Dictionary<string, T> dic, string key)
        {
            int position = 0;
            bool isFind = false;
            foreach (var item in dic)
            {
                if (item.Key == key)
                {
                    isFind = true;
                    break;
                }
                else
                    position++;
            }
            if (isFind)
                return position;
            else
                return -1;
        } 
    }
}
