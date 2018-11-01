using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BlackJack
{
    class GameModel : CardCharacteristics
    {
        int _playerScore;
        int _computerScore;

        private List<CardCharacteristics> cards = new List<CardCharacteristics>();
        public int PlayerScore
        {
            get { return _playerScore; }
            set
            {
                if (value == _playerScore)
                    return;
                _playerScore = value;
                OnPropertyChanged();
            }
        }
        public int ComputerScore
        {
            get { return _computerScore; }
            set
            {
                if (value == _computerScore)
                    return;
                _computerScore = value;
                OnPropertyChanged();
            }
        }

        public List<CardCharacteristics> deck
        {
            get { return cards; }
            set
            {
                if(value == cards)
                   return;
                cards = value;
                OnPropertyChanged();
            }
        }
       
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public GameModel()
        {
            AddCommand = new AddNameCommand(this);
        }
        class AddNameCommand : ICommand
        {
            GameModel parent;

            public AddNameCommand(GameModel parent)
            {
                this.parent = parent;
                parent.PropertyChanged += delegate { CanExecuteChanged?.Invoke(this, EventArgs.Empty); };
            }

            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter) { return Game.deck.Any(); }
            //HitMe
            public void Execute(object parameter)
            {
                List<CardCharacteristics> cards = (from item in parent.cards
                                                   where item.flag != 1
                                                   select item).ToList();

                var drawncard = cards.Take(1).ToList();
                Game.playerHand.AddRange(drawncard);

                foreach (var card in Game.playerHand)
                {
                    card.flag = 1;
                }
            }
        }

        public ICommand AddCommand { get; private set; }
    }
}
