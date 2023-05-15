using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment2_RESTfulService
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate = "NumberGenWithRange?lower={lower}&upper={higher}",
            RequestFormat = WebMessageFormat.Json)]
        int SecretNumber(int lower, int higher);

        [OperationContract]
        [WebGet(UriTemplate = "VerifyNum?Num1={userNum}&Num2={SecretNum}",
            RequestFormat = WebMessageFormat.Json)]
        string checkNumber(int userNum, int SecretNum);
    }
}
