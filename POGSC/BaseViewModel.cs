using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;

namespace POGSC
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public string Title { get; set; }







        private bool isBusy;
        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChanged(); }
        }

        //private bool isBusy;
        //public bool IsBusy
        //{
        //    get { return isBusy; }
        //    set
        //    {
        //        isBusy = value;
        //        PropertyChanged(this, new PropertyChangedEventArgs("IsBusy"));
        //    }
        //}

        //public bool verificaCon()
        //{
        //    var isConnected = CrossConnectivity.Current.IsConnected;
        //    return isConnected;
        //}



        private ImageSource _imageSource;
        public ImageSource ImageSource
        {
            get { return _imageSource; }
            set
            {
                _imageSource = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ImageSource"));
            }
        }
        public string matricula;
        public string Matricula
        {
            get { return matricula; }
            set
            {
                matricula = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Matricula"));
            }
        }
        //private List<Loja> _listaLojas;
        //public List<Loja> ListaLojas
        //{
        //    get { return _listaLojas; }
        //    set
        //    {
        //        _listaLojas = value;
        //        PropertyChanged(this, new PropertyChangedEventArgs("ListaLojas"));
        //    }
        //}

        //int selectChanged;
        //public int SelectChanged
        //{
        //    get
        //    {
        //        return selectChanged;
        //    }
        //    set
        //    {
        //        //if (selectChanged != value)
        //        //{
        //        selectChanged = value;

        //        // trigger some action to take such as updating other labels or fields
        //        //DisplayAlert("teste", value.ToString(), "dawdawda");
        //        Id = ListaLojas[value].ID;
        //        Logradouro = ListaLojas[value].Endereco.Logradouro;
        //        Bairro = ListaLojas[value].Endereco.Bairro;
        //        Complemento = ListaLojas[value].Endereco.Complemento;
        //        Cidade = ListaLojas[value].Endereco.Cidade;
        //        Uf = ListaLojas[value].Endereco.UF;
        //        Matricula = ListaLojas[value].Matricula;
        //        //SelectedCountry = Countries[countriesSelectedIndex];
        //        // }
        //    }
        //}

        //private List<string> _displayLojas;
        //public List<string> DisplayLojas
        //{
        //    get { return _displayLojas; }
        //    set
        //    {
        //        _displayLojas = value;
        //        PropertyChanged(this, new PropertyChangedEventArgs("DisplayLojas"));
        //    }
        //}
        private string _logradouro;
        public string Logradouro
        {
            get { return _logradouro; }
            set
            {
                _logradouro = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Logradouro"));
            }
        }
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Id"));
            }
        }

        private string _bairro;
        public string Bairro
        {
            get { return _bairro; }
            set
            {
                _bairro = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Bairro"));
            }
        }

        private string _complemento;
        public string Complemento
        {
            get { return _complemento; }
            set
            {
                _complemento = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Complemento"));
            }
        }

        private string _cidade;
        public string Cidade
        {
            get { return _cidade; }
            set
            {
                _cidade = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Cidade"));
            }
        }

        private string _uf;
        public string Uf
        {
            get { return _uf; }
            set
            {
                _uf = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Uf"));
            }
        }



        private bool proxAtivo;
        public bool ProxAtivo
        {
            get { return proxAtivo; }
            set
            {
                proxAtivo = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ProxAtivo"));
            }
        }

        public List<string> UFLista
        {
            get;
            set;
        }



        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public BaseViewModel()
        {
            UFLista = new List<string>();
            ListaUF();
        }
        private void ListaUF()
        {
            UFLista.Add("AC");
            UFLista.Add("AL");
            UFLista.Add("AP");
            UFLista.Add("AM");
            UFLista.Add("BA");
            UFLista.Add("CE");
            UFLista.Add("DF");
            UFLista.Add("ES");
            UFLista.Add("GO");
            UFLista.Add("MA");
            UFLista.Add("MT");
            UFLista.Add("MS");
            UFLista.Add("MG");
            UFLista.Add("PA");
            UFLista.Add("PB");
            UFLista.Add("PR");
            UFLista.Add("PE");
            UFLista.Add("PI");
            UFLista.Add("RJ");
            UFLista.Add("RN");
            UFLista.Add("RS");
            UFLista.Add("RO");
            UFLista.Add("RR");
            UFLista.Add("SC");
            UFLista.Add("SP");
            UFLista.Add("SE");
            UFLista.Add("TO");

        }

        public async Task DisplayAlert(string title, string message, string cancel)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, cancel);
        }

        //private void Acesso()
        //{
        //    authServ = new AutenticacaoService();
        //    authServ.PegaTipo();
        //}
        //public async void NavegarHome(INavigation nav)
        //{
        //    INavigation navigation = nav;
        //    //Acesso();
        //    switch (Settings.TipoAcc)
        //    {
        //        case "Vendedor":
        //            Application.Current.MainPage = new HomeView_v();
        //            var mainPage = new HomeView_v();
        //            await navigation.PushAsync(mainPage);
        //            RemovePageFromStack(navigation);
        //            break;

        //        case "Supervisor":
        //            Application.Current.MainPage = new HomeView_eg();
        //            var mainPage2 = new HomeView_eg();
        //            await navigation.PushAsync(mainPage2);
        //            break;

        //        default:
        //            RemovePageFromStack(navigation);
        //            break;
        //    }

        //}
        //public async void NavegarHomeAcesso(INavigation nav)
        //{
        //    INavigation navigation = nav;
        //    Acesso();
        //    switch (Settings.TipoAcc)
        //    {
        //        case "Vendedor":
        //            Application.Current.MainPage = new HomeView_v();
        //            var mainPage = new HomeView_v();
        //            await navigation.PushAsync(mainPage);
        //            RemovePageFromStack(navigation);
        //            break;

        //        case "Supervisor":
        //            Application.Current.MainPage = new HomeView_eg();
        //            var mainPage2 = new HomeView_eg();
        //            await navigation.PushAsync(mainPage2);
        //            break;

        //        default:
        //            RemovePageFromStack(navigation);
        //            break;
        //    }

        //}
        //private void RemovePageFromStack(INavigation nav)
        //{
        //    INavigation navigation = nav;
        //    var existingPages = navigation.NavigationStack.ToList();
        //    foreach (var page in existingPages)
        //    {
        //        if (page.GetType() == typeof(MainPage))
        //            navigation.RemovePage(page);
        //    }
        //}


        public MediaFile ImgTirada
        {
            get;
            set;
        }

        //tirar foto
        public async void TirarVoid()
        {


            try
            {
                await CrossMedia.Current.Initialize();

                if (!CrossMedia.Current.IsTakePhotoSupported || !CrossMedia.Current.IsCameraAvailable)
                {
                    await DisplayAlert("Erro", "Nenhuma câmera detectada", "Ok");
                    return;
                }

                var file = await CrossMedia.Current.TakePhotoAsync(
                new StoreCameraMediaOptions
                {
                    SaveToAlbum = true,
                    Directory = "testeSC"

                });
                if (file == null)
                {
                    return;
                }
                ImgTirada = file;
                ImageSource = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    //file.Dispose();
                    return stream;

                });
                ProxAtivo = true;


            }
            catch (Exception)
            {
                await DisplayAlert("Ops", "Algo aconteceu, se certifique que as permissões foram concedidas corretamente", "ok");

            }


        }

        //public void LimpaCoockies()
        //{
        //    Settings.TokenAcesso = string.Empty;
        //    Settings.TipoAcc = string.Empty;
        //}

        //public async Task NavegarLogin(INavigation navigation)
        //{
        //    Application.Current.MainPage = new MainPage();
        //    var mainPage2 = new MainPage();
        //    await navigation.PushAsync(mainPage2);
        //    RemovePageFromStack(navigation);
        //}
    }
}
