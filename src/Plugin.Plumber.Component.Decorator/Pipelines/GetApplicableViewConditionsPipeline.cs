﻿using Microsoft.Extensions.Logging;
using Plugin.Plumber.Component.Decorator.Pipelines.Arguments;
using Sitecore.Commerce.Core;
using Sitecore.Framework.Pipelines;

namespace Plugin.Plumber.Component.Decorator.Pipelines
{
    public class GetApplicableViewConditionsPipeline : CommercePipeline<EntityViewConditionsArgument, EntityViewConditionsArgument>, IGetApplicableViewConditionsPipeline
    {
        public GetApplicableViewConditionsPipeline(IPipelineConfiguration<IGetApplicableViewConditionsPipeline> configuration, ILoggerFactory loggerFactory)
            : base(configuration, loggerFactory)
        {
        }
    }
}
