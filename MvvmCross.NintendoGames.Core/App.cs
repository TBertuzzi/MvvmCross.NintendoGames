using System;
using MvvmCross.IoC;
using MvvmCross.NintendoGames.Core.ViewModels;
using MvvmCross.ViewModels;

namespace MvvmCross.NintendoGames.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            RegisterAppStart<GamesViewModel>();
        }
    }
}
