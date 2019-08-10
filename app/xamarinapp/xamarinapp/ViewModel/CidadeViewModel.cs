using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace xamarinapp
{
    public class CidadeViewModel : BindableObject

    {
        private ObservableCollection<Cidades> itens = new ObservableCollection<Cidades>();

        public ObservableCollection<Cidades> Itens
        {
            get => itens;
            set { Itens = value; OnPropertyChanged(); }
        }

        public CidadeViewModel()
        {
            Itens = new ObservableCollection<Cidades>(

                new List<Cidades>
                {
                    new Cidades {NomeCidade = "Curitiba"}
                });
        }
        //william@mkn.dev

    }
}
