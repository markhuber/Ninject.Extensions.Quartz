// Ninject.Extensions.Quartz
// https://github.com/dtinteractive/Ninject.Extensions.Quartz
// 
// Copyright (c) 2013 DealerTrack Interactive
// Licensed under the MIT license.
using Quartz;
using Quartz.Impl;

namespace Ninject.Extensions.Quartz
{
	public class NinjectSchedulerFactory : StdSchedulerFactory
	{
		private readonly NinjectJobFactory _ninjectJobFactory;

		public NinjectSchedulerFactory(NinjectJobFactory ninjectJobFactory)
		{
			_ninjectJobFactory = ninjectJobFactory;
		}

		protected override IScheduler Instantiate(global::Quartz.Core.QuartzSchedulerResources rsrcs, global::Quartz.Core.QuartzScheduler qs)
		{
			qs.JobFactory = _ninjectJobFactory;
			return base.Instantiate(rsrcs, qs);
		}
	}
}