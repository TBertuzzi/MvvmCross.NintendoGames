using System.Diagnostics.CodeAnalysis;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace MvvmCross.NintendoGames.Core.ViewModels
{
    public class GamesViewModel : MvxViewModel
    {
        
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