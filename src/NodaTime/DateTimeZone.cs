﻿#region Copyright and license information
// Copyright 2001-2009 Stephen Colebourne
// Copyright 2009 Jon Skeet
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System;

namespace NodaTime
{
    /// <summary>
    /// Original name: DateTimeZone.
    /// Everyone should fear time zones. We need to be very careful here :)
    /// </summary>   
    public abstract class DateTimeZone
    {
        public static DateTimeZone SystemDefault
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public static DateTimeZone Utc
        {
            get { throw new NotImplementedException(); }
        }

        public static DateTimeZone ForID(string id)
        {
            throw new NotImplementedException();
        }
    }
}
