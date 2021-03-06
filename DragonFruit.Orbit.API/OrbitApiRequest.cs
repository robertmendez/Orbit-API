﻿// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data;

namespace DragonFruit.Orbit.API
{
    public abstract class OrbitApiRequest : ApiRequest
    {
        public override string Path => "https://osu.ppy.sh/api/v2" + Route;
        public override bool RequireAuth => true;
        public override string AcceptedContent => "application/json";

        protected abstract string Route { get; }
    }
}
