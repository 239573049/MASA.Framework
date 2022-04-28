// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

global using Masa.BuildingBlocks.Configuration;
global using Masa.Contrib.BasicAbility.Dcc.Internal;
global using Masa.Contrib.BasicAbility.Dcc.Options;
global using Masa.Contrib.BasicAbility.Dcc.Tests.Internal;
global using Masa.Contrib.BasicAbility.Dcc.Tests.Internal.Common;
global using Masa.Contrib.BasicAbility.Dcc.Tests.Internal.Config;
global using Masa.Contrib.BasicAbility.Dcc.Tests.Internal.Enum;
global using Masa.Contrib.BasicAbility.Dcc.Tests.Internal.Model;
global using Masa.Contrib.Configuration;
global using Masa.Utils.Caching.Core.Interfaces;
global using Masa.Utils.Caching.Core.Models;
global using Masa.Utils.Caching.DistributedMemory;
global using Masa.Utils.Caching.DistributedMemory.Interfaces;
global using Masa.Utils.Caching.DistributedMemory.Models;
global using Masa.Utils.Caching.Redis.Models;
global using Masa.Utils.Caller.Core;
global using Masa.Utils.Caller.HttpClient;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.Extensions.Caching.Memory;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Options;
global using Microsoft.VisualStudio.TestTools.UnitTesting;
global using Moq;
global using System.Net;
global using System.Text.Json;

