﻿//////////////////////////////////////////////////
//             NOT IMPLEMENTED YET              //
//              Level/Subtlety.cs               //
//      Part of MutaRaidBT by fiftypence        //
//////////////////////////////////////////////////

using System;
using TreeSharp;
using Action = TreeSharp.Action;

namespace MutaRaidBT.Composites.Context.Level
{
    class Subtlety
    {
        public static Composite BuildCombatBehavior()
        {
            return new Action(ret =>
                {
                    throw new NotImplementedException();
                }
            );
        }

        public static Composite BuildPullBehavior()
        {
            return new Action(ret => RunStatus.Failure);
        }

        public static Composite BuildBuffBehavior()
        {
            return new Action(ret => RunStatus.Failure);
        }
    }
}
