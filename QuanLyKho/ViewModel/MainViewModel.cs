using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyKho.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool Isloaded = false;
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand UnitCommand { get; set; }
        public ICommand SuplierCommand { get; set; }
        public ICommand CustomerCommand { get; set; }
        public ICommand ObjectCommand { get; set; }
        public ICommand UserCommand { get; set; }
        public ICommand InputCommand { get; set; }
        public ICommand OutputCommand { get; set; }

        // mọi thứ xử lý sẽ nằm trong này
        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                Isloaded = true;
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();
            });

            UnitCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                UnitWindow wn = new UnitWindow();
                wn.ShowDialog();
            });

            SuplierCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                SuplierWindow wn = new SuplierWindow();
                wn.ShowDialog();
            });

            CustomerCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                CustomerWindow wn = new CustomerWindow();
                wn.ShowDialog();
            });

            ObjectCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                ObjectWindow wn = new ObjectWindow();
                wn.ShowDialog();
            });

            UserCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                UserWindow wn = new UserWindow();
                wn.ShowDialog();
            });

            InputCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                InputWindow wn = new InputWindow();
                wn.ShowDialog();
            });

            OutputCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                OutputWindow wn = new OutputWindow();
                wn.ShowDialog();
            });

        }
    }
}
