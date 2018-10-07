using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyElephant.Client.ViewModels
{
    using CrazyElephant.Client.Models;
    using Prism.Commands;
    using Prism.Mvvm;
    using CrazyElephant.Client.Services;
    using System.Windows;

    class MainWindowViewModel:BindableBase
    {
        public DelegateCommand PlaceOrderCommand { get; set; }
        public DelegateCommand SelectMenuItemCommand { get; set; }

        private int count;

        public int Count
        {
            get { return count; }
            set
            {
                count = value;
                this.RaisePropertyChanged("Count");
            }
        }

        private Restaurant restaurant;

        public Restaurant Restaurant
        {
            get { return restaurant; }
            set
            {
                restaurant = value;
                this.RaisePropertyChanged("Restaurant");
            }
        }

        private List<DishMenuItemViewModel> dishMenu;

        public List<DishMenuItemViewModel> DishMenu
        {
            get { return dishMenu; }
            set
            {
                dishMenu = value;
                this.RaisePropertyChanged("DishMenu");
            }
        }

        public MainWindowViewModel()
        {
            LoadRestaurant();
            LoadDishMenu();
            this.PlaceOrderCommand = new DelegateCommand(new Action(PlaceOrderCommandExecute));
                //new DelegateCommand(() => PlaceOrderCommandExecute());
            this.SelectMenuItemCommand = new DelegateCommand(new Action(SelectMenuItemExecute));
        }

        private void LoadDishMenu()
        {
            XmlDataService ds = new XmlDataService();
            var dishes = ds.GetAllDishes();
            this.DishMenu = new List<DishMenuItemViewModel>();
            foreach(var d in dishes)
            {
                DishMenuItemViewModel item = new DishMenuItemViewModel();
                item.Dish = d;
                this.DishMenu.Add(item);
            }
        }

        private void LoadRestaurant()
        {
            this.Restaurant = new Restaurant();
            this.Restaurant.Name = "Crazy大象";
            this.Restaurant.Address = "北京市 海淀区 万泉河路 紫金庄园1号楼1层113室";
            this.Restaurant.Telephon = "15210365423 or 82650336";
        }

        private void PlaceOrderCommandExecute()
        {
            var selectedDishes = this.DishMenu.Where(i => i.IsSelected == true).Select(i => i.Dish.Name).ToList();
            IOrderService orderService = new MockOrderService();
            orderService.PlaceOrder(selectedDishes);
            MessageBox.Show("订餐成功");
        }

        private void SelectMenuItemExecute()
        {
            this.Count = this.DishMenu.Count(i => i.IsSelected == true);
        }
    }
}
