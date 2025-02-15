/*
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 * Copyright (c) 2017-2018 Swan & The Quaver Team <support@quavergame.com>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quaver.API.Enums
{
    [Flags]
    public enum ModIdentifier : long
    {
        None = -1L,
        NoSliderVelocity = 1L << 0, // No Slider Velocity
        Speed05X = 1L << 1, // Speed 0.5x,
        Speed06X = 1L << 2, // Speed 0.6x
        Speed07X = 1L << 3, // Speed 0.7x
        Speed08X = 1L << 4, // Speed 0.8x
        Speed09X = 1L << 5, // Speed 0.9x
        Speed11X = 1L << 6, // Speed 1.1x
        Speed12X = 1L << 7, // Speed 1.2x
        Speed13X = 1L << 8, // Speed 1.3x
        Speed14X = 1L << 9, // Speed 1.4x
        Speed15X = 1L << 10, // Speed 1.5x
        Speed16X = 1L << 11, // Speed 1.6x
        Speed17X = 1L << 12, // Speed 1.7x
        Speed18X = 1L << 13, // Speed 1.8x
        Speed19X = 1L << 14, // Speed 1.9x
        Speed20X = 1L << 15, // Speed 2.0x
        Strict = 1L << 16, // Makes the accuracy hit windows harder
        Chill = 1L << 17, // Makes the accuracy hit windows easier
        NoPause = 1L << 18, // Disallows pausing.
        Autoplay = 1L << 19, // The game automatically plays it.
        Paused = 1L << 20, // The user paused during gameplay.
        NoFail = 1L << 21, // Unable to fail during gameplay.
        NoLongNotes = 1L << 22, // Converts LNs into regular notes.
        Randomize = 1L << 23, // Randomizes the playfield's lanes.
        Speed055X = 1L << 24, // Speed 0.55x,
        Speed065X = 1L << 25, // Speed 0.65x
        Speed075X = 1L << 26, // Speed 0.75x
        Speed085X = 1L << 27, // Speed 0.85x
        Speed095X = 1L << 28, // Speed 0.95x
        Inverse = 1L << 29, // Converts regular notes into LNs and LNs into gaps.
        FullLN = 1L << 30, // Converts regular notes into LNs, keeps existing LNs.
        Mirror = 1L << 31, // Flips the map horizontally
        Coop = 1L << 32 // Allows multiple people to play together on one client
    }
}
