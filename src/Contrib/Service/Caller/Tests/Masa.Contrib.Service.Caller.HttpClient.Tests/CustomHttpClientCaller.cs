// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.Contrib.Service.Caller.HttpClient.Tests;

public class CustomHttpClientCaller : HttpClientCaller
{
    public CustomHttpClientCaller(
        System.Net.Http.HttpClient httpClient,
        IServiceProvider serviceProvider,
        string name,
        bool supportAuthentication,
        string baseApi,
        Func<IServiceProvider, IRequestMessage>? currentRequestMessageFactory = null,
        Func<IServiceProvider, IResponseMessage>? currentResponseMessageFactory = null)
        : base(httpClient, serviceProvider, name, supportAuthentication, baseApi, currentRequestMessageFactory, currentResponseMessageFactory)
    {
    }

    public string GetResult(string? methodName) => base.GetRequestUri(methodName);
}
