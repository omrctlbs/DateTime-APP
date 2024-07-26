bool exit = false;
while (!exit)
{
	Console.Clear();
	Console.WriteLine("Saat Farkı Hesaplayıcı");
	Console.WriteLine("1. Saat Farkı Hesapla");
	Console.WriteLine("2. Çıkış");
	Console.Write("Seçiminizi yapın (1 veya 2): ");

	string sec = Console.ReadLine();

	switch (sec)
	{
		case "1":
			CalculateTimeDifference();
			break;
		case "2":
			exit = true;
			break;
		default:
			Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
			break;
	}
}

 static void CalculateTimeDifference()
{
	Console.WriteLine("Yönlendirme ekranına gidiyorsunuz ltf bekleyiniz.");
	try
	{
		Console.WriteLine("İlk tarihi ve saati girin (yyyy-MM-dd HH:mm): ");
		DateTime firstdatetime = Convert.ToDateTime(Console.ReadLine());
		Console.Write("İkinci tarihi ve saati girin (yyyy-MM-dd HH:mm): ");
		DateTime seconddattime = Convert.ToDateTime(Console.ReadLine());

		TimeSpan diffrencetime = firstdatetime - seconddattime;
		Console.WriteLine($"Fark: {diffrencetime.Days} Gün, {diffrencetime.Hours} Saat, {diffrencetime.Minutes} Dakika");

	}
	catch (FormatException)
	{
		Console.WriteLine("Geçersiz tarih formatı, lütfen yyyy-MM-dd HH:mm formatında girin.");
	}

	Console.WriteLine("Devam etmek için bir tuşa basın...");
	Console.ReadKey();
	}