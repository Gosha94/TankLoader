using System;
using System.Windows.Forms;
using TankLoader.Classes;
using TankLoader.Enums;

namespace TankLoader
{
    public partial class frm_Main : Form
    {
        // Создаем переменные для объектов бункеров
        LoadTank loadTank;
        WeightingTank weightingTank;

        public frm_Main()
        {
            InitializeComponent();

            // Выделяем память ( создаем объекты ) для загрузочного и весового бункеров при создании формы
            loadTank = new LoadTank();
            weightingTank = new WeightingTank();
        }


        private void btn_LoadWeightTank_Click(object sender, EventArgs e)
        {
            // Вызываем метод проверки данных при нажатии кнопки на форме
            CheckInfo();
        }
        /// <summary>
        /// Метод проверяет заполнение элементов на форме
        /// </summary>
        private void CheckInfo()
        {            
            if ( cmbBx_materialType.SelectedIndex < 0 )
                MessageBox.Show("Необходимо указать тип загружаемого в бункер материала !");            
            else
            {
                FullTank(( MaterialType ) cmbBx_materialType.SelectedIndex );
            }
        }
        /// <summary>
        /// Метод загрузки материала в бункер
        /// </summary>
        /// <param name="material">Загружаемый в бункер материал</param>
        private void FullTank(MaterialType material )
        {
            try {
                // Принимаем материал в бункер
                loadTank.MaterialType = material;
                // Передаем материал в весовой бункер
                loadTank.Load(weightingTank);
                
                MessageBox.Show($"Вес материала: {weightingTank.Material} - { weightingTank.MaterialWeight.ToString()}");
            }
            catch (Exception exception) { MessageBox.Show(exception.Message,"Attention!",MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_UnloadWeightTank_Click(object sender, EventArgs e)
        {
            weightingTank.ClearTank();
            MessageBox.Show("Весовой бункер успешно очищен!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
