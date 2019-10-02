# Open API SDK for .Net Core developers

## Requirements

- 仅支持 .NET Core 2.0 及以上版本(为推进新版本发展，停止支持 .NET Core 1.0、1.1版本)；
- 下载SDK 把 `Aliyun.Acs.Core.dll` 和相应产品的 .dll 文件添加引用到项目中。

## Installation
进入 [Alibaba Cloud SDK for .NET Nuget Package](https://www.nuget.org/profiles/aliyun-openapi-sdk) 页面，查看已发布的阿里云产品 SDK 模块列表。

> **注意：** 部分阿里云产品的 SDK 未收录到这个列表中，例如对象存储（OSS），表格存储（Table Store），请前往这些产品的详情页获取相应的 SDK。

使用ECS产品时，应安装 [ECS Nuget Package](https://www.nuget.org/packages/aliyun-net-sdk-ecs/)。
如果要安装特定版本，请添加`--version`，否则它将安装此软件包的最新版本。

您可以通过 NuGet 程序包管理器来安装：

* 在 `解决方案资源管理器面板` 中右击您的项目选择 `管理 NuGet 程序包` 菜单，在打开的 `NuGet 管理面板` 中点击 `浏览` 选项卡输入 `aliyun-net-sdk`，在下方列表中选择 `Authors` 为 `Alibaba Cloud` 由官方发布的各产品模块，选择您期望的模块点击 **安装** 即可。

或者通过 .NET CLI 工具来安装（以安装 ECS为例）

    dotnet add package aliyun-net-sdk-ecs

使用程序包管理器控制台

    Install-Package aliyun-net-sdk-ecs

## Examples

```csharp
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

	通过catch异常判断API是否调用成功，当 API 的 `http status >= 200 && http status < 300` 表示API调用成功；当`http status >= 300 && http status < 500` SDK 抛出 `ClientException`；当`http status >= 500` SDK 抛出 `ServerException`.

2. `IClientProfile clientProfile = DefaultProfile.GetProfile("< your request regionid >", "< your access key id >", "< your access key secret >");`

	此处的`regionid`参数指你需要操作的`region`的`id`，例如要操作`杭州region`，则`regionid=cn-hangzhou`；默认填`cn-hangzhou`.

3. docker for linux 环境中，如何无错运行Aliyun SDK Application?
请在Dockerfile中指定`FROM microsoft/dotnet:latest`, 而不是`FROM microsoft/aspnetcore:latest`.

## Authors && Contributors

- [Ma Lijie](https://github.com/malijiefoxmail)
- [Allen Cai](https://github.com/VAllens)

## License

licensed under the [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0.html)
