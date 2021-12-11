using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };
		List<string> scrollBaru = new List<string>();

		while (true)
		{
			Menu();
			int pilih = Convert.ToInt32(Console.ReadLine());
			var counter = 0;
			var berapa = 0;
			var que = 0;

			if (pilih == 1)
			{
				Console.WriteLine("Scrolls To Learn List");
				foreach (var scroll in scrolls)
				{
					counter++;
					Console.WriteLine($"Scrolls {counter}: {scroll}");
				}

			}
			else if (pilih == 2)
			{
				Console.Write("How Many Scrolls To Add: ");
				berapa = Convert.ToInt32(Console.ReadLine());
				Console.Write("In What Number of Queue: ");
				que = Convert.ToInt32(Console.ReadLine());

				for (int i = 0; i < berapa; i++)
				{
					Console.Write("Scroll " + (i + 1) + " name: ");
					scrollBaru.Add(Console.ReadLine());
				}

				if(que < 1)
                {
					que = 0;
                }
				else if(que > scrolls.Count)
                {
					que = scrolls.Count;
                }

				counter = -1;
				foreach (var scroll in scrollBaru)
				{
					
					scrolls.Insert(que + counter, scroll);
					counter++;
				}
				scrollBaru.Clear();

			}
			else if (pilih == 3)
            {
				Console.WriteLine("Insert Scroll Name: ");
				string cari = Console.ReadLine();
				var indes = scrolls.FindIndex(a => a.Equals(cari, StringComparison.OrdinalIgnoreCase));

					if (scrolls.FindIndex(x => x.Equals(cari,StringComparison.OrdinalIgnoreCase)) != -1)
					{
							Console.WriteLine($"Book Found! Queue Number: {indes+1} ");
					}
					else
					{
					Console.WriteLine("Book Not Found...");
					}



			}
			else if (pilih == 4)
            {
				Console.WriteLine("Remove from List from scroll name? (y/n)");
				var milih = Console.ReadLine();

				{
					while (milih != "y" && milih != "n")
					{
						Console.Write("Wrong Selection? Choose Again: \nRemove from List from scroll name? (y/n)");
						milih = Console.ReadLine();	

					}
					{
						if (milih == "y") // delet by name
						{
							Console.Write("Input Scroll Name: ");
							string NamaS = Console.ReadLine();

							
									if (scrolls.Contains(NamaS, StringComparer.OrdinalIgnoreCase))
									{
										scrolls.RemoveAt(scrolls.FindIndex(n => n.Equals(NamaS, StringComparison.OrdinalIgnoreCase)));
										Console.WriteLine("Book Removed!");
									}
									else if (scrollBaru.Contains(NamaS, StringComparer.OrdinalIgnoreCase))
									{
										scrollBaru.RemoveAt(scrollBaru.FindIndex(n => n.Equals(NamaS, StringComparison.OrdinalIgnoreCase)));
										Console.WriteLine("Book Removed!");
									}
									else
									{
										Console.WriteLine("Book Not Found");
									}


						}
						else if (milih == "n") // delet by que
						{
							Console.Write("Input Scroll Queue: ");

							var Position = Convert.ToInt32(Console.ReadLine());
							var simpen = 1;
							

							while (simpen == 1)
                            {
								if (simpen == 1)
								{
									Console.Write("Queue Not Found... Insert Scroll Queue: ");
									Position = Convert.ToInt32(Console.ReadLine());
								}


								for(int j = 0; j < scrolls.Count; j++)
                                {
									if(Position == j)
                                    {
										scrolls.Remove(scrolls[j -1]);
										Console.WriteLine("Book Removed!!");
										simpen++;

                                    }
									
									
                                }
								
								
								
                            }

							

							
						}
					}
				}
			}
		}
	}

	public static void Menu() 
	{
		Console.Write("1. My Scroll List\n2. Add Scroll\n3. Search Scroll\n4. Remove Scroll\nChoose What To Do: "); 
	}


}

