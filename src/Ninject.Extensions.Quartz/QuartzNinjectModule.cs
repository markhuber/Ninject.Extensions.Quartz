// Topshelf.Integrations
// https://github.com/dtinteractive/Topshelf.Integrations
// 
// Copyright (c) 2013 DT Interactive
// Licensed under the MIT license.
using Ninject.Modules;
using Quartz;

namespace Ninject.Extensions.Quartz
{
	public class QuartzNinjectModule : NinjectModule
	{
		public override void Load()
		{
			Bind<ISchedulerFactory>().To<NinjectSchedulerFactory>();
			Bind<IScheduler>().ToMethod(ctx => ctx.Kernel.Get<ISchedulerFactory>().GetScheduler()).InSingletonScope();   
		}
	}
}