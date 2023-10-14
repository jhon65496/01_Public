using System.Collections.ObjectModel;
using WpfUserControlLibrary00.Models;


namespace WpfUserControlLibrary00.ViewModels
{
    internal class MainWindowViewModel : BaseVM
    {
        // AppManager appManager;
        // IndexesViewModel indexesViewModel;

        public MainWindowViewModel()
        {   
            LoadData();
        }

        #region Title
        private string title = "App `WpfUserControlLibrary00`. Prop title";
        
        public string Title 
        {
            get { return title; }
            set { title = value; }
        }
        #endregion

        private ObservableCollection<IndexCalculation> calculationIndexs;

        public ObservableCollection<IndexCalculation> СalculationIndexs
        {
            get { return calculationIndexs; }
            set
            {
                calculationIndexs = value;
                RaisePropertyChanged(nameof(СalculationIndexs));
            }
        }





        private BaseVM currentView;
        public BaseVM CurrentView
        {
            get { return currentView; }
            set
            {
                currentView = value;
                RaisePropertyChanged(nameof(CurrentView));
            }
        }

        public void LoadData()
        {
            var calculationIndexes = new ObservableCollection<IndexCalculation>();
            for (int i = 1; i < 10; i++)
            {
                var indexCalculation = new IndexCalculation()
                {
                    Id = i,
                    Name = $"Name-{i}",
                    Description = $"Description-{i}"
                };
                calculationIndexes.Add(indexCalculation);
            }

            СalculationIndexs = calculationIndexes;
        }


    }
}
