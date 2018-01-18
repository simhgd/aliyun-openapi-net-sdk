# Open API SDK for dotnet core developers
- 本项目宗旨为临时解决Ali官方SDK不支持dotnet core， 尽量减少对原SDK的修改，使用较多曲线方案，并非最优版本。

## Requirements

- 支持 .Net Standard 1.6 版本；
- 使用nuget包引用方式；

## 已支持的产品列表
- [aliyun-net-sdk-core](https://www.nuget.org/packages/aliyun-net-sdk-core/)
- [aliyun-net-sdk-alidns](https://www.nuget.org/packages/aliyun-net-sdk-alidns/)
- [aliyun-net-sdk-cdn](https://www.nuget.org/packages/aliyun-net-sdk-cdn/)
- [aliyun-net-sdk-dm] PACKAGE ID WHO USED?
- [aliyun-net-sdk-domain](https://www.nuget.org/packages/aliyun-net-sdk-domain/)
- [aliyun-net-sdk-ecs](https://www.nuget.org/packages/aliyun-net-sdk-ecs/)
- [aliyun-net-sdk-hpc](https://www.nuget.org/packages/aliyun-net-sdk-hpc/)
- [aliyun-net-sdk-iot](https://www.nuget.org/packages/aliyun-net-sdk-iot/)
- [aliyun-net-sdk-kms](https://www.nuget.org/packages/aliyun-net-sdk-kms/)
- [aliyun-net-sdk-mts](https://www.nuget.org/packages/aliyun-net-sdk-mts/)
- [aliyun-net-sdk-push](https://www.nuget.org/packages/aliyun-net-sdk-push/)
- [aliyun-net-sdk-rds](https://www.nuget.org/packages/aliyun-net-sdk-rds/)
- [aliyun-net-sdk-slb](https://www.nuget.org/packages/aliyun-net-sdk-slb/)
- [aliyun-net-sdk-sms](https://www.nuget.org/packages/aliyun-net-sdk-sms/)
- [aliyun-net-sdk-sts](https://www.nuget.org/packages/aliyun-net-sdk-sts/)
- [aliyun-net-sdk-live](https://www.nuget.org/packages/aliyun-net-sdk-live/)
- [aliyun-net-sdk-cloudapi](https://www.nuget.org/packages/aliyun-net-sdk-cloudapi/)
- [aliyun-net-sdk-vod](https://www.nuget.org/packages/aliyun-net-sdk-vod/)
- [aliyun-net-sdk-cloudphoto](https://www.nuget.org/packages/aliyun-net-sdk-cloudphoto/)
- [aliyun-net-sdk-sas-api](https://www.nuget.org/packages/aliyun-net-sdk-sas-api/)
- [aliyun-net-sdk-dysms](https://www.nuget.org/packages/aliyun-net-sdk-dysms/)
- [aliyun-net-sdk-ons](https://www.nuget.org/packages/aliyun-net-sdk-ons/)
- [aliyun-net-sdk-ram](https://www.nuget.org/packages/aliyun-net-sdk-ram/)
- [aliyun-net-sdk-r-kvstore](https://www.nuget.org/packages/aliyun-net-sdk-r-kvstore/)
- [aliyun-net-sdk-chatbot](https://www.nuget.org/packages/aliyun-net-sdk-chatbot/)
- [aliyun-net-sdk-dds](https://www.nuget.org/packages/aliyun-net-sdk-dds/)
- [aliyun-net-sdk-ess](https://www.nuget.org/packages/aliyun-net-sdk-ess/)
- [aliyun-net-sdk-nas](https://www.nuget.org/packages/aliyun-net-sdk-nas/)
- [aliyun-net-sdk-vpc](https://www.nuget.org/packages/aliyun-net-sdk-vpc/)
- [aliyun-net-sdk-arms](https://www.nuget.org/packages/aliyun-net-sdk-arms/)
- [aliyun-net-sdk-arms4finance](https://www.nuget.org/packages/aliyun-net-sdk-arms4finance/)
- [aliyun-net-sdk-ccc](https://www.nuget.org/packages/aliyun-net-sdk-ccc/)
- [aliyun-net-sdk-cloudauth](https://www.nuget.org/packages/aliyun-net-sdk-cloudauth/)
- [aliyun-net-sdk-cms](https://www.nuget.org/packages/aliyun-net-sdk-cms/)
- [aliyun-net-sdk-domain-intl](https://www.nuget.org/packages/aliyun-net-sdk-domain-intl/)
- [aliyun-net-sdk-teslamaxcompute](https://www.nuget.org/packages/aliyun-net-sdk-teslamaxcompute/)
- [aliyun-net-sdk-cloudwf](https://www.nuget.org/packages/aliyun-net-sdk-cloudwf/)

### 当前版本
#### 1.0.6(原Repo未标明版本号)
#### 其余版本号使用原Repo中ChangeLog中的版本

## Example
   ```CSharp
    using Aliyun.Acs.Core;
    using Aliyun.Acs.Core.Exceptions;
    using Aliyun.Acs.Core.Profile;
    using Aliyun.Acs.Ecs.Model.V20140526;
    using System;
     
    class Sample
    {
        static void Main(string[] args)
        {
            TestDescribeInstanceAttribute();
        }
        
        private static void TestDescribeInstanceAttribute()
        {
            IClientProfile clientProfile = DefaultProfile.GetProfile("cn-hangzhou", "<your access key id>", "<your access key secret>");
            DefaultAcsClient client = new DefaultAcsClient(clientProfile);
            
            DescribeInstanceAttributeRequest request = new DescribeInstanceAttributeRequest();
            request.InstanceId = "<your instances id>";
            try
            {
                DescribeInstanceAttributeResponse response = client.GetAcsResponse(request);
                Console.Write(response.InstanceId);
            }
            catch (ServerException e)
            {
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMessage);
            }
            catch (ClientException e)
            {
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.ErrorMessage);
            }
        }
    }
   ```

## Questions

1. 怎么判断API调用成功？

	通过catch异常判断API是否调用成功，当 API 的 http status>=200 且 <300 表示API调用成功；当http status>=300且<500 SDK抛ClientException；当http status >=500 SDK 抛 ServerException

2. `IClientProfile clientProfile = DefaultProfile.GetProfile("< your request regionid >", "< your access key id >", "< your access key secret >")`;

	此处的regionid参数指你需要操作的region的id，例如要操作杭州region，则regionid=cn-hangzhou；默认填cn-hangzhou.



## Authors && Contributors

- [Ma Lijie](https://github.com/malijiefoxmail)
- [Sim Tsai](https://github.com/simhgd)

## License

licensed under the [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0.html)
