﻿using ActionGame;
using BepInEx;
using BepInEx.Logging;

namespace KKAPI.MainGame
{
    internal sealed class TestGameFunctionController : GameCustomFunctionController
    {
        protected internal override void OnEndH(HSceneProc proc, bool freeH)
        {
            Logger.Log(LogLevel.Warning | LogLevel.Message, "GameController - OnEndH - FreeH:" + freeH);
        }

        protected internal override void OnEnterNightMenu()
        {
            Logger.Log(LogLevel.Warning | LogLevel.Message, "GameController - OnEnterNightMenu");
        }

        protected internal override void OnGameLoad(GameSaveLoadEventArgs args)
        {
            Logger.Log(LogLevel.Warning | LogLevel.Message, "GameController - OnGameLoad - Path:" + args.FullFilename);
        }

        protected internal override void OnGameSave(GameSaveLoadEventArgs args)
        {
            Logger.Log(LogLevel.Warning | LogLevel.Message, "GameController - OnGameSave - Path:" + args.FullFilename);
        }

        protected internal override void OnStartH(HSceneProc proc, bool freeH)
        {
            Logger.Log(LogLevel.Warning | LogLevel.Message, "GameController - OnStartH - FreeH:" + freeH);
        }

        protected internal override void OnDayChange(Cycle.Week day)
        {
            Logger.Log(LogLevel.Warning | LogLevel.Message, "GameController - OnDayChange - day:" + day);
        }

        protected internal override void OnPeriodChange(Cycle.Type period)
        {
            Logger.Log(LogLevel.Warning | LogLevel.Message, "GameController - OnPeriodChange - period:" + period);
        }
    }
}
