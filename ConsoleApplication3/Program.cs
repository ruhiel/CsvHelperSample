using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var r = new StreamReader("preset.csv", Encoding.GetEncoding("UTF-8")))
			using (var csv = new CsvHelper.CsvReader(r))
			{
				// ヘッダーがあるCSV
				csv.Configuration.HasHeaderRecord = true;
				// 先ほど作ったマッピングルールを登録
				csv.Configuration.RegisterClassMap<ShipInfoMap>();
				// データを読み出し
				var records = csv.GetRecords<ShipInfo>().ToList();
				try
				{
					// 全件出力
					foreach (var record in records)
					{
						Console.WriteLine("{0}/{1}/{2}", record.Index, record.Type, record.Class);
					}

					var torpedo1Max = records.Where(x => x.Type == "駆逐艦").Max(y => y.Torpedo1);

					Console.Write("最大の雷装を持つ駆逐艦は" + records.Where(x => x.Type == "駆逐艦" && x.Torpedo1 == torpedo1Max).First().Name);
				}
				catch(Exception e)
				{
					Console.Write(e.Message);
				}
				
			}
		}
	}
}
