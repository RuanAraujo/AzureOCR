using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace POGSC
{
    public class ViewModel : BaseViewModel
    {


        public string RespostaString
        {
            get;
            set;
        }
        ICommand fotoCommand;

        public ICommand FotoCommand
        {
            get { return fotoCommand; }
        }


        ICommand analCommand;

        public ICommand AnalCommand
        {
            get { return analCommand; }
        }
        //public ICommand FotoCommand => fotoCommand ?? (fotoCommand = new Command(async () => await ExecuteFotoCommandAsync()));

        public ViewModel()
        {
            fotoCommand = new Command(ExecuteFotoCommand);
            analCommand = new Command(Invoca);
        }


        private void ExecuteFotoCommand()
        {
            TirarVoid();
        }


        Service service;
        private async void Invoca()
        {
            service = new Service();

            var listaResposta =  await service.PostServicoAsync(ImgTirada);

            Metodo(listaResposta);


            //IEnumerable<string> resultado = from e in listaResposta[0].Regions;

        }

        List<string> Textos = new List<string>();
       
        private void Metodo(Resposta respostas)
        {
            
            foreach (var item in respostas.Regions)
            {
                foreach (var item2 in item.Lines)
                {
                    foreach (var item3 in item2.Words)
                    {
                        Console.WriteLine(item3.Text);
                    }
                }
            }

        }
    }
}
