using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Plant : IPlant
    {
        private CSunflower _flowerGraphics;
        public CSunflower FlowerGraphics//передают значения в графику(контрол)
        {
            get => _flowerGraphics;
            set
            {
                _flowerGraphics = value;
                _flowerGraphics.hp = HP;
            }
        }

        private CNut _nutGraphics;
        public CNut NutGraphics
        {
            get => _nutGraphics;
            set
            {
                _nutGraphics = value;
                _nutGraphics.hp = HP;
            }
        }

        private CSundew _sundewGraphics;

		public CSundew SundewGraphics
		{
			get => _sundewGraphics;
			set
            {
				_sundewGraphics = value;
				_sundewGraphics.HP = HP;
			}
		}

		private int _hp;

        public int HP
		{
			get => _hp;
			set
			{
				_hp = value;
				if (SundewGraphics != null)
					SundewGraphics.HP = value;
                if (NutGraphics != null)
                    NutGraphics.hp = value;
                if (FlowerGraphics != null)
                    FlowerGraphics.hp = value;
            }
		}

        public int execution = 100;
        public bool life = true;
        public bool Photo { get; set; }
        public string s;

        //___________________________________________________________

        public Plant (bool life, int HP, bool photo)
        {
            this.life = life;
            this.HP = HP;
            this.Photo = photo;
        }

        public string AreLife()//на жзнь проверяет метод этот
        {
            if (life && HP > 0)
            {
                s = "БРАТЦЫ, ОНО ОЧЕНЬ ЖИВОЕ, ЙОШКИН КОТ\n";
                return s;
            }
            else
            {
                s = "ОНО МЕРТВО\n";
                return s;
            }
        }

        public string GetPhotoEating(Sun sun)//просто добавляет хп если день
        {
            if (sun.light && Photo)
            {
                HP += (int)(execution * 0.1);
                s = "наслаждаемся солнышком (*_*)\n";
                return s;
            }
            else
            {
                s = "а ты не можешь это сделать!\n";
                return s;
            }
        }
    }
}
