using System;
using System.Windows.Forms;
using TankLoader.Abstracts;
using TankLoader.Enums;

namespace TankLoader.Classes
{
    class LoadTank
    {
        private int? vol;
        private MaterialType? materialType;
        private WeightingTank weightTank;

        public LoadTank(WeightingTank weightingTank)
        {
            this.weightTank = weightingTank;
        }

        public void Load ( int tankVolume, MaterialType materialForLoad )
        {
            this.vol = tankVolume;
            this.materialType = materialForLoad;

            AutoUnload();
        }

        private void AutoUnload()
        {
            weightTank.volume = ( int ) this.vol;            
            this.vol = null;

            weightTank.material = ( MaterialType ) this.materialType;
            this.materialType = null;
        }
    }
}
