using System.Diagnostics.CodeAnalysis;
using MvvmCross.Commands;
using MvvmCross.NintendoGames.Core.Models;
using MvvmCross.NintendoGames.Core.Services;
using MvvmCross.ViewModels;

namespace MvvmCross.NintendoGames.Core.ViewModels
{
    public class GamesViewModel : MvxViewModel
    {
        private readonly INintendoService _nintendoService;
        public  MvxObservableCollection<Game> Games { get; }

        public GamesViewModel(INintendoService nintendoService)
        {
            _nintendoService = nintendoService;
            Games = new MvxObservableCollection<Game>();
        }
        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);
        private void ResetText()
        {
            Text = "Hello MvvmCross";
        }

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }
    }
}