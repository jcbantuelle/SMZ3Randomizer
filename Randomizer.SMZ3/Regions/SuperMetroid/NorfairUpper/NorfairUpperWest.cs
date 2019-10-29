﻿using System.Collections.Generic;

namespace Randomizer.SMZ3.Regions.SuperMetroid {

    class NorfairUpperWest : SMRegion {

        public override string Name => "Norfair Upper West";
        public override string Area => "Norfair Upper";

        public NorfairUpperWest(World world, Config config) : base(world, config) {
            Locations = new List<Location> {
                new Location(this, 50, 0xC78B24, LocationType.Chozo, "Ice Beam",
                    items => items.Super && items.CanPassBombPassages() && (
                        items.SpeedBooster && items.Varia ||
                        Logic.HellRun && items.CanHellRun(3)
                    )),
                new Location(this, 51, 0xC78B46, LocationType.Hidden, "Missile (below Ice Beam)",
                    items => items.Super && (
                        items.CanUsePowerBombs() && items.SpeedBooster && items.Varia ||
                        Logic.HellRun && (items.CanUsePowerBombs() || items.SpeedBooster) && items.CanHellRun(3)
                    )),
                new Location(this, 53, 0xC78BAC, LocationType.Chozo, "Hi-Jump Boots",
                    items => items.CanOpenRedDoors() && items.CanPassBombPassages()),
                new Location(this, 55, 0xC78BE6, LocationType.Visible, "Missile (Hi-Jump Boots)",
                    items => items.CanOpenRedDoors() && items.Morph),
                new Location(this, 56, 0xC78BEC, LocationType.Visible, "Energy Tank (Hi-Jump Boots)",
                    items => items.CanOpenRedDoors()),
            };
        }

        public override bool CanEnter(Progression items) {
            return (items.CanDestroyBombWalls() || items.SpeedBooster) && items.Super && items.Morph ||
                items.CanAccessNorfairUpperPortal();
        }

    }

}