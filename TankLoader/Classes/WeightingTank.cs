using TankLoader.Enums;
using System;
using System.Windows.Forms;

namespace TankLoader.Classes
{
    class WeightingTank
    {
        private int? materialWeight;
        
        private MaterialType? material;
        public MaterialType? Material
        { 
            get { return material; } 
            set
            {
                // Обработка повторной загрузки бункера, если не пустой, выдаем исключение
                if (material != null && material != value)
                {
                    throw new Exception("Принять новый метериал невозможно! Освободите весовой бункер!");
                }
                // в других случаях загружаем материал в весовой бункер
                material = value;
            }
        }
        
        public int? MaterialWeight { get { DetermineWeight(); return materialWeight; } }        
        Random rand;
        /// <summary>
        /// Метод очистки бункера от материала
        /// </summary>
        public void ClearTank()
        {
            this.material = null;            
        }       
        /// <summary>
        /// Метод вычисляет вес загруженного в него материала
        /// </summary>
        private void DetermineWeight()
        {
            ClearWeight();
            rand = new Random();            
            this.materialWeight = ( int ) rand.Next ( 100, 800 );
        }
        /// <summary>
        /// Метод обнуления весов перед взвешиванием
        /// </summary>        
        private void ClearWeight()
        {
            materialWeight = null;
        }

    }
}
