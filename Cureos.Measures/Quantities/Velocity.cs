﻿/*
 *  Copyright (c) 2011-2015, Cureos AB.
 *  All rights reserved.
 *  http://www.cureos.com
 *
 *	This file is part of CSUnits.
 *
 *  CSUnits is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Lesser General Public License as
 *  published by the Free Software Foundation, either version 3 of the
 *  License, or (at your option) any later version.
 *
 *  CSUnits is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Lesser General Public License for more details.
 *
 *  You should have received a copy of the GNU Lesser General Public
 *  License along with CSUnits. If not, see http://www.gnu.org/licenses/.
 */

namespace Cureos.Measures.Quantities
{
    public partial struct Velocity
    {
        public static Length operator *(Velocity lhs, Time rhs)
        {
            return new Length(lhs.amount * rhs.Amount);
        }

        public static Length operator *(Velocity lhs, IMeasure<Time> rhs)
        {
            return new Length(lhs.amount * rhs.StandardAmount);
        }

        public static Acceleration operator /(Velocity lhs, Time rhs)
        {
            return new Acceleration(lhs.amount / rhs.Amount);
        }

        public static Acceleration operator /(Velocity lhs, IMeasure<Time> rhs)
        {
            return new Acceleration(lhs.amount / rhs.StandardAmount);
        }
    }
}