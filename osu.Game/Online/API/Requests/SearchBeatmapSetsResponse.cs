﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using Newtonsoft.Json;
using osu.Game.Online.API.Requests.Responses;

namespace osu.Game.Online.API.Requests
{
    public class SearchBeatmapSetsResponse : ResponseWithCursor
    {
        [JsonProperty("beatmapsets")]
        public IEnumerable<APIBeatmapSet> BeatmapSets;

        [JsonProperty("error")]
        public string Error;

        [JsonProperty("total")]
        public int Total;
    }
}
