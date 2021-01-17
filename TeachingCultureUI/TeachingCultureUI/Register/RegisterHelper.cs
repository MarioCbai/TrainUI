﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TeachingCultureUI.Register
{
    public class RegisterHelper
    {
        public RegisterHelper()
        {
        }
        public static string _Linkstring = "http://106.ihuyi.cn/webservice/sms.php?method=Submit";
         
        //短信帮助类 返回值为发送验证码的四位数字  返回0为发送失败
        public int Page_Load(string mobile)
        {
            string account = "C67183189";//查看用户名 登录用户中心->验证码通知短信>产品总览->API接口信息->APIID
            string password = " 45f29c9307b17f4dc984205c5cac8c3b"; //查看密码 登录用户中心->验证码通知短信>产品总览->API接口信息->APIKEY       
            Random rad = new Random();
            int mobile_code = rad.Next(1000, 10000);
            string content = "您的验证码是：" + mobile_code + " 。请不要把验证码泄露给其他人。";

            //Session["mobile"] = mobile;
            //Session["mobile_code"] = mobile_code;

            string postStrTpl = "account={0}&password={1}&mobile={2}&content={3}";

            UTF8Encoding encoding = new UTF8Encoding();
            byte[] postData = encoding.GetBytes(string.Format(postStrTpl, account, password, mobile, content));

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(_Linkstring);
            myRequest.Method = "POST";
            myRequest.ContentType = "application/x-www-form-urlencoded";
            myRequest.ContentLength = postData.Length;

            Stream newStream = myRequest.GetRequestStream();
            // Send the data.
            newStream.Write(postData, 0, postData.Length);
            newStream.Flush();
            newStream.Close();

            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            if (myResponse.StatusCode == HttpStatusCode.OK)
            {
                StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);

                //Response.Write(reader.ReadToEnd());

                string res = reader.ReadToEnd();
                int len1 = res.IndexOf("</code>");
                int len2 = res.IndexOf("<code>");
                string code = res.Substring((len2 + 6), (len1 - len2 - 6));
                //Response.Write(code);
                int len3 = res.IndexOf("</msg>");
                int len4 = res.IndexOf("<msg>");
                string msg = res.Substring((len4 + 5), (len3 - len4 - 5));
                return mobile_code;

            }
            else
            {
                return 0;
                //访问失败
            }
        }
    }
}
