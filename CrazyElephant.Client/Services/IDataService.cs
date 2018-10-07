using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyElephant.Client.Services
{
    using CrazyElephant.Client.Models;

    public interface IDataService
    {
        List<Dish> GetAllDishes();
    }
}
