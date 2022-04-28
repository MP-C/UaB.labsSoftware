﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonativosWindowsForms.Views;

namespace DonativosWindowsForms.Models
{
    public class Model
    {
        private ViewDonativos view;
        private List<ModelDonativo> donativos = new List<ModelDonativo>();

        public Model(ViewDonativos v)
        {
            view = v;
        }
    }
}
