﻿using System;
using System.Collections.Generic;
using System.Text;

namespace fhict_proftaak3.Componenten
{
    public class Drieweg : IKruispunt
    {
        protected KruispuntWachtrij[] wachtrijen;

        public Drieweg()
        {
            wachtrijen = new KruispuntWachtrij[4];
        }

        public void addAuto(Auto auto, IKruispunt richting)
        {
            foreach (KruispuntWachtrij wachtrij in wachtrijen) {
                if (wachtrij.Richting == richting) {
                    wachtrij.Add(auto);
                }
            }
        }

        public void addKruispunt(IKruispunt kruispunt, int pos)
        {
            wachtrijen[pos] = new KruispuntWachtrij(kruispunt);
        }
    }
}
