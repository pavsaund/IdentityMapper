/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using Machine.Specifications;
using Dolittle.TimeSeries.Modules;
using Moq;
using It = Machine.Specifications.It;

namespace Dolittle.TimeSeries.IdentityMapper.for_TimeSeriesMapper
{
    public class when_asking_if_timeseries_exists_for_in_non_existing_system
    {
        const string system = "MySystem";
        const string tag = "MyTag";

        static bool result;

        static TimeSeriesMapper mapper;

        Establish context = () => mapper = new TimeSeriesMapper(new TimeSeriesMap(new Dictionary<ControlSystem, TimeSeriesByTag>()));

        Because of = () => result = mapper.HasTimeSeriesFor(system, tag);

        It should_consider_not_having_it = () => result.ShouldBeFalse();
    }
}