﻿/*
*
* 文件名    ：BasicTypeRepository                             
* 程序说明  : 基础数据类型数据接口实现
* 更新时间  : 2020-05-21 16：43
* 更新人    : zhouhaogg789@outlook.com
* 联系作者  : QQ:779149549 
* 开发者群  : QQ群:874752819
* 邮件联系  : zhouhaogg789@outlook.com
* 视频教程  : https://space.bilibili.com/32497462
* 博客地址  : https://www.cnblogs.com/zh7791/
* 项目地址  : https://github.com/HenJigg/WPF-Xamarin-Blazor-Examples
* 项目说明  : 以上所有代码均属开源免费使用,禁止个人行为出售本项目源代码
*/

namespace Consumption.EFCore.Repository
{
    using Consumption.Core.ApiInterfaes;
    using Consumption.Core.Entity;
    using Consumption.EFCore.Orm;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BasicTypeRepository : BaseRepository<BasicType>, IBasicTypeRepository
    {
        public BasicTypeRepository(ConsumptionContext consumptionContext) : base(consumptionContext)
        {
        }
    }
}
