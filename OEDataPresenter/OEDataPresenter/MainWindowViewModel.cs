using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OEDataPresenter
{
    public class MainWindowViewModel:BaseViewModel
    {
        #region Private Properties

        private string studentname;

        private int mytimer;

        #endregion

        #region Public Properties

        public string StudentName
        {
            get { return studentname; }
            set { studentname = value; }
        }


        public int MyTimer
        {
            get
            {
                return mytimer;
            }
            set { mytimer = value; }
        }

        #endregion


        public ICommand ChangeCommand { get; set; }


        #region ctor

        public MainWindowViewModel()
        {
            ChangeCommand = new RelayCommand(async () => await ChangeCommandAsync());

            StudentName = "USST";
        }
        #endregion

        #region Methods

        private async Task ChangeCommandAsync()
        {
            MyTimer = MyTimer + 1;
            await Task.Delay(1);
        } 
        #endregion


    }
}
