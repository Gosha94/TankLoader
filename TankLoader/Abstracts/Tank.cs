using System.Windows.Forms;
using TankLoader.Enums;

namespace TankLoader.Abstracts
{
    /// <summary>
    /// Абстракция, определяюшая сущность бункера и его возможные методы и поля
    /// </summary>
    abstract class Tank
    {
        /// <summary>
        /// Тип материала, загруженный в бункер
        /// </summary>
        public MaterialType Material { get; set; }
        /// <summary>
        /// Имя бункера
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Объем бункера
        /// </summary>
        public int Volume { get; set; }
        /// <summary>
        /// Конструктор по умолчанию для абстракции, для передачи в дочерние классы объема бункера, названия бункера и типа материала в бункере
        /// </summary>
        /// <param name="volume"></param>
        public Tank ( int volume, string name, MaterialType material )
        {
            Volume = volume;
            Name = name;
            Material = material;
        }

        public Tank(int volume, string name, Tank tank)
        {
            Volume = volume;
            Name = name;            
        }

        public void SpeakAboutYourself()
        {
            MessageBox.Show( $"My Volume - { Volume } m3, my Name - { Name }, Loaded material - { Material }" );
        }

        public virtual void Load()
        {
            MessageBox.Show( "Tank Loaded!" );
        }

        public virtual void Unload()
        {
            MessageBox.Show( "Tank Unloaded!" );
        }
    }
}
