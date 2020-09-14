using System;
using System.Windows.Forms;
using TankLoader.Classes;
using TankLoader.Enums;

namespace TankLoader
{
    public partial class frm_Main : Form
    {
        LoadTank loadTank;
        WeightingTank weightingTank;

        public frm_Main()
        {
            InitializeComponent();

            loadTank = new LoadTank();
            weightingTank = new WeightingTank();
        }

        /*
         +1. Создаем пустые бункеры загрузки и взвешивания
         +2. На форме выбираем материал, загружаем в первый бункер
         3. Материал сохраняется в первый бункер, и передается во второй
         4. Во втором бункере проводится проверка, если он уже занят, то взвешиваем текущий материал
        */

        private void btn_LoadWeightTank_Click(object sender, EventArgs e)
        {            
            StartLoadTank();

            //LoadTank loader = new LoadTank(200, "Loader Tank", MaterialType.CaC2 );
            //loader.SpeakAboutYourself();
            //loader.Load();
            //loader.Unload();            

            //WeightingTank weighter = new WeightingTank(500, "Weighter Tank", MaterialType.CaMg );
            //weighter.SpeakAboutYourself();
            //weighter.Load();
            //weighter.Unload();
        }

        private void StartLoadTank()
        {
            if ( cmbBx_materialType.SelectedIndex < 0 || maskTxtBx_tankVolume.TextLength < 3 )
                MessageBox.Show("Необходимо указать тип загружаемого в бункер материала !");
            else if ( maskTxtBx_tankVolume.Text == "" || Convert.ToInt32(maskTxtBx_tankVolume.Text) < 100 )                
                MessageBox.Show( "Некорректный объем бункера, минимальный объем = 100 m3 !" );
            else
            {
                FullTank(Convert.ToInt32(maskTxtBx_tankVolume.Text), ( MaterialType ) cmbBx_materialType.SelectedIndex );
            }
        }

        private void FullTank(int volume, MaterialType material )
        {
            bool isEmpty = loadTank.Load( volume, material );
            MessageBox.Show( $"Tank is Empty - {isEmpty}" );

            //LoadTank loaderTank = new LoadTank( volume, "Loader Tank", ( MaterialType ) cmbBx_materialType.SelectedIndex );
            //loaderTank.SpeakAboutYourself();
        }
    }
}
