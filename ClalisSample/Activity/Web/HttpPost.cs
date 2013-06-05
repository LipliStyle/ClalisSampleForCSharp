//=======================================================================
//  ClassName : HttpPost
//  概要      : ポストを送信して結果を得る
//
//  Clalis
//  Copyright(c) 2011-2013 LipliStyle. All Rights Reserved. 
//=======================================================================

using System.Collections.Specialized;
using System.Net;
using System.Net.Cache;
using System;
using System.Text;
using System.IO;

namespace Clalis.Web
{
    public class HttpPost
    {
        /// <summary>
        /// 定数定義
        /// </summary>
        const int WEB_POST_TIMEOUT         = 5000;
        const string WEB_POST_METHOD       = "POST";
        const string WEB_POST_CONTENT_TYPE = "application/x-www-form-urlencoded";


        ///====================================================================
        ///
        ///                        パブリックメソッド
        ///                         
        ///====================================================================

        /// <summary>
        /// ポストを送信する
        /// (UTF-8のみ)
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="postData"></param>
        /// <returns></returns>
        public static string sendPost(string url, NameValueCollection postData)
        {
            //受信したデータを表示する
            return sendPost(url, getParamDataByte(postData));
        }
        public static string sendPost(string url, byte[] data)
        {
            //ウェブリクエストの取得
            HttpWebRequest req = getWebRequest(url, data.Length);

            req.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);

            // ポスト・データの書き込み
            sendPostRequest(req, data);

            //受信したデータを表示する
            return getWebResponse(req);
        }

        ///====================================================================
        ///
        ///                       POSTの実行メソッド
        ///                         
        ///====================================================================

        /// <summary>
        /// getParamDataByte
        /// パラメータをバイトで取得する
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static byte[] getParamDataByte(NameValueCollection postData)
        {
            string param = "";

            //バラメータの取得
            foreach (string k in postData)
            {
                param += String.Format("{0}={1}&", k, postData[k]);
            }

            //パラメータをバイト変換
            return Encoding.ASCII.GetBytes(param);
        }


        /// <summary>
        /// getWebRequest
        /// ウェブリクエストを取得する
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static HttpWebRequest getWebRequest(string url, long paramLength)
        {
            // リクエストの作成
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Timeout = WEB_POST_TIMEOUT;
            req.Method = WEB_POST_METHOD;
            req.ContentType = WEB_POST_CONTENT_TYPE;
            req.ContentLength = paramLength;

            return req;
        }

        /// <summary>
        /// getWebResponse
        /// ウェブレスポンスを取得する
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static string getWebResponse(HttpWebRequest req)
        {
            using (Stream resStream = req.GetResponse().GetResponseStream())
            {
                using (StreamReader sr = new StreamReader(resStream, Encoding.UTF8))
                {
                    return sr.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// getWebRequest
        /// ウェブリクエストを取得する
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static void sendPostRequest(HttpWebRequest req, byte[] pramData)
        {
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(pramData, 0, pramData.Length);
            }
        }
    }
}
