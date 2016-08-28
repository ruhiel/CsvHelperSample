using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
	public sealed class ShipInfoMap : CsvClassMap<ShipInfo>
	{
		public ShipInfoMap()
		{
			Map(m => m.Index).Index(0);
			Map(m => m.Type).Index(1);
			Map(m => m.Class).Index(2);
			Map(m => m.Name).Index(3);
			Map(m => m.Attack).Index(4);
			Map(m => m.Torpedo1).Index(5);
			Map(m => m.Bomb).Index(6);
			Map(m => m.Torpedo2).Index(7);
			Map(m => m.PaPbPower).Index(8);
			Map(m => m.SlotSize).Index(9);
			Map(m => m.AntiSubBody).Index(10);
			Map(m => m.AntiSubWeapon).Index(11);
			Map(m => m.Defense).Index(12);
			Map(m => m.Hp).Index(13);
		}
	}
}
