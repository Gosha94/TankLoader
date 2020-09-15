using System;
using System.Windows.Forms;
using TankLoader.Enums;

namespace TankLoader.Classes
{
    class LoadTank
    {        
        private MaterialType? materialType;
        public MaterialType? MaterialType 
        {
            get { return materialType; } 
            set 
            {
                this.materialType = value;
            } 
        }
        /// <summary>
        /// Метод загрузки бункера материалом
        /// </summary>        
        public void Load (WeightingTank weightingTank)
        {
            // Загружаем в весовой бункер материал
            weightingTank.Material = materialType;
            // Разгружаем загрузочный бункер
            AutoUnload();
        }        
        /// <summary>
        /// Метод автоматической рагрузки бункера после 
        /// </summary>
        private void AutoUnload()
        {
            this.materialType = null;            
        }
    }
}
