# Open API SDK for .Net developers

## Requirements

- 支持 .Net Standard 1.6 版本；
- 使用引用Project方式引入aliyun-net-sdk-core 和相应的产品Project。

## 已支持的产品列表
- [aliyun-net-sdk-core](https://www.nuget.org/packages/aliyun-net-sdk-core/)
- [aliyun-net-sdk-alidns](https://www.nuget.org/packages/aliyun-net-sdk-alidns/)


## Example

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

## Questions

1. 怎么判断API调用成功？

	通过catch异常判断API是否调用成功，当 API 的 http status>=200 且 <300 表示API调用成功；当http status>=300且<500 SDK抛ClientException；当http status >=500 SDK 抛 ServerException

2. IClientProfile clientProfile = DefaultProfile.GetProfile("< your request regionid >", "< your access key id >", "< your access key secret >");

	此处的regionid参数指你需要操作的region的id，例如要操作杭州region，则regionid=cn-hangzhou；默认填cn-hangzhou.



## Authors && Contributors

- [Ma Lijie](https://github.com/malijiefoxmail)
- [Sim Tsai](https://github.com/simhgd)

## License

licensed under the [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0.html)
