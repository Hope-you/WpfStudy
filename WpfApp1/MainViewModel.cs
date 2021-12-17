using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public  class MainViewModel
    {
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public MainViewModel()
        {
            Message = "我是业务类!";
        }
    }
}
