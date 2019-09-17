using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using OnCall.Service.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;

namespace OnCall.Service.Domain
{
    public class SMSSender
    {
        /// <summary>
        /// 阿里云短信发送方法
        /// </summary>
        /// <param name="PhoneNumbers">接收手机号</param>
        /// <param name="TemplateParam">模板参数 JSON格式</param>
        /// <param name="SignName">签名模板名称</param>
        /// <param name="TemplateCode">模板代码</param>
        /// <returns></returns>
        public string Sender(string PhoneNumbers, string TemplateParam)
        {
            string result = string.Empty;

            IClientProfile profile = DefaultProfile.GetProfile(ConfigureDBAssist.Instance.SMSRegionId,
                ConfigureDBAssist.Instance.SMSAccessKeyId, ConfigureDBAssist.Instance.SMSAccessSecret);

            DefaultAcsClient client = new DefaultAcsClient(profile);
            CommonRequest request = new CommonRequest();
            request.Method = MethodType.POST;
            request.Domain = ConfigureDBAssist.Instance.SMSDomain;// "dysmsapi.aliyuncs.com";
            request.Version = ConfigureDBAssist.Instance.SMSVersion;//"2017-05-25";
            request.Action = ConfigureDBAssist.Instance.SMSAction;//"SendSms";
            // request.Protocol = ProtocolType.HTTP;

            request.AddQueryParameters("PhoneNumbers", PhoneNumbers.Trim());
            request.AddQueryParameters("SignName", ConfigureDBAssist.Instance.SMSSignName);
            request.AddQueryParameters("TemplateCode", ConfigureDBAssist.Instance.SMSSignName);
            request.AddQueryParameters("TemplateParam", TemplateParam);//json

            try
            {
                CommonResponse response = client.GetCommonResponse(request);

                result = Encoding.Default.GetString(response.HttpResponse.Content);
            }
            catch (System.Runtime.Remoting.ServerException e)
            {
                Console.WriteLine(e);
            }
            catch (ClientException e)
            {
                Console.WriteLine(e);
            }

            return result;
        }
    }
}
