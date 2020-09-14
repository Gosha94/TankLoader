using System;
using System.Windows.Forms;
using TankLoader.Abstracts;
using TankLoader.Enums;

namespace TankLoader.Classes
{
    class LoadTank
    {
        private int? vol = null;

        private MaterialType? materialType = null;

        private bool tankIsEmpty = true;

        //public LoadTank( int volume, string name, MaterialType material) : base( volume, name, material )
        //{

        //}      
        
        public bool Load(int tankVolume, MaterialType materialForLoad)
        {
            if ( materialType is null || vol is null )
            {
                this.vol = tankVolume;
                this.materialType = materialForLoad;

                tankIsEmpty = false;
                return tankIsEmpty;
            }
                else if (materialType.HasValue && vol.HasValue)
            {
                tankIsEmpty = false;
                return tankIsEmpty;
            }
            else
            {
                tankIsEmpty = true;
                return tankIsEmpty;
            }
            
        }
    }
}
