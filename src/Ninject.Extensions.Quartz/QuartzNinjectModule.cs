// Ninject.Extensions.Quartz
// https://github.com/dtinteractive/Ninject.Extensions.Quartz
// 
// Copyright (c) 2013 DealerTrack Interactive
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