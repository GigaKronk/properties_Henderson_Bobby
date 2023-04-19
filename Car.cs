using System;
using System.Collections.Generic;
using System.Text;

namespace properties_Henderson_Bobby
{
    class Car
    {

        private string model;

        public string Model { get { return model; } set { model = value;  } }

        public string Make { get; set; }
    }
}
