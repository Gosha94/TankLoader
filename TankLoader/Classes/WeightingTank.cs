using TankLoader.Enums;
using TankLoader.Abstracts;
using System;

namespace TankLoader.Classes
{
    class WeightingTank
    {
        private bool isEmpty;
        public bool IsEmpty { get { return isEmpty; } }
        public int? volume { get; set; }
        public MaterialType? material { get; set; }        
        public int? MaterialWeight { get { return materialWeight; } }

        private int? materialWeight;

        public void ClearTank()
        {
            this.volume = null;
            this.material = null;

            isEmpty = true;
        }
        private void ClearWeight()
        {
            materialWeight = null;
        }

        private void DetermineWeight()
        {
            ClearWeight();
            this.materialWeight = ( int ) Math.Pow ( ( int ) this.volume, ( int ) this.material );
        }

        public int? PerformWeighting()
        {
            if (isEmpty)
            {
                DetermineWeight();
                return materialWeight;
            }
            else { return null; }
        }

    }
}
