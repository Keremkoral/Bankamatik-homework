namespace Bankamatik_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = 25000;
            string password = "ab18";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1-Kartlı İşlem\n2-Kartsız İşlem\nQ-Çıkış\nSeçiminiz:");
                string kartli = Console.ReadLine().ToUpper();

                if (kartli == "1")
                {

                    int hak = 3;
                    bool giris = false;
                    while (hak > 0)
                    {
                        Console.WriteLine("Şifreniz:");
                        string sifre = Console.ReadLine();
                        hak--;
                        if (sifre == password)
                        {
                            giris = true;
                            break;
                        }
                        else if (hak == 0)
                        {
                            Console.WriteLine("5 defa yanlış giriş yapıldı.Sistem 5 saniye kitlendi");
                            Thread.Sleep(50000);
                            hak = 5;
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Şifreniz Hatalı. Tekrar Deneyiniz.");

                        }
                    }

                    if (giris)
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Yapacağınız İşlemi Seçiniz");
                            Console.WriteLine("1-Para Çekme\n2-Para Yatırma\n3-Transfer\n4-Ödemeler\n5-Eğitim Ödemeleri\n6-Bilgi Güncelleme\n0-Çıkış\nSeçiminiz:");
                            string Menu = Console.ReadLine();

                            if (Menu == "1")
                            {
                                Console.WriteLine("Çekilmek istenilen miktar:");
                                int miktar = Convert.ToInt32(Console.ReadLine());
                                if (miktar <= money)
                                {
                                    money -= miktar;
                                    Console.WriteLine($"{miktar} lira çekildi. Yeni bakiyeniz:{money}");
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz Bakiye");
                                }

                            }
                            else if (Menu == "2")
                            {
                                Console.WriteLine("1-Kredi Kartı\n2-Hesaba\nSeçiminiz:");
                                string secim = Console.ReadLine();

                                if (secim == "1")
                                {
                                    Console.WriteLine("Kredi kart numarası:");
                                    string kartNo = Console.ReadLine();

                                    double kartNo2;
                                    if (kartNo.Length == 12 && double.TryParse(kartNo, out kartNo2))
                                    {
                                        Console.WriteLine("Yatırılacak Miktar Girişi:");
                                        int miktar = Convert.ToInt32(Console.ReadLine());

                                        if (money >= miktar)
                                        {
                                            money -= miktar;
                                            Console.WriteLine($"{miktar} ₺ yatırıldı. Yeni bakiyeniz:{money}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Kart numarası hatalı!!");
                                    }


                                }
                                else if (secim == "2")
                                {
                                    Console.WriteLine("Yatırılacak Miktar Girişi:");
                                    money += Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Yeni Bakiyeniz:" + money);
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Para Yatırma Seçimi!!");
                                }



                            }
                            else if (Menu == "3")
                            {
                                Console.WriteLine("1-EFT\n2-Havale\nSeçiminiz:");
                                string secim = Console.ReadLine();

                                if (secim == "1")
                                {
                                    Console.WriteLine("IBAN bilgisini başında TR olacak şekilde giriniz:");
                                    string Iban = Console.ReadLine().ToUpper();
                                    double iban;
                                    if (Iban.StartsWith("TR") && Iban.Length == 14 && double.TryParse(Iban.Substring(2), out iban))
                                    {
                                        Console.WriteLine("EFT Miktar Girişi:");
                                        int miktar = Convert.ToInt32(Console.ReadLine());

                                        if (money >= miktar)
                                        {
                                            money -= miktar;
                                            Console.WriteLine($"{miktar} lira eft edildi. Yeni bakiyeniz:{money}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Iban bilgisi hatalı!!");
                                    }

                                }
                                else if (secim == "2")
                                {
                                    Console.WriteLine("Hesap numarası:");
                                    string havale = Console.ReadLine();

                                    double havale2;
                                    if (havale.Length == 12 && double.TryParse(havale, out havale2))
                                    {
                                        Console.WriteLine("Havale Miktar Girişi:");
                                        int tutar = Convert.ToInt32(Console.ReadLine());

                                        if (money >= tutar)
                                        {
                                            money -= tutar;
                                            Console.WriteLine($"{tutar} lira havale edildi. Yeni bakiyeniz:{money}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Kart numarası hatalı!!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Havale Seçimi!!");
                                }

                            }
                            else if (Menu == "4")
                            {
                                Console.WriteLine("Eğitim Ödemeleri Bölümü ARIZALI!!!");
                            }
                            else if (Menu == "5")
                            {
                                Console.WriteLine("1-Elektrik\n2-Su\n3-Doğalgaz\nSeçiminiz:");
                                string fatura = Console.ReadLine();

                                if (fatura == "1")
                                {
                                    Console.WriteLine("Fatura bedeli:");
                                    double miktar = Convert.ToDouble(Console.ReadLine());

                                    if (money >= miktar)
                                    {
                                        money -= miktar;
                                        Console.WriteLine($"{miktar} ₺ fatura ödendi. Yeni bakiyeniz:{money}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz Bakiye");
                                    }

                                }


                            }
                            else if (Menu == "6")
                            {
                                Console.WriteLine("Eski şifreniz:");
                                string oldpassword = Console.ReadLine();
                                if (oldpassword == password)
                                {
                                    Console.WriteLine("Yeni Şifreniz:");
                                    string newpassword = Console.ReadLine();
                                    Console.WriteLine("Tekrar Yeni Şifreniz:");
                                    string newpassword = Console.ReadLine();

                                    if (newpassword == newpassword)
                                    {
                                        password = newpassword;
                                    }
                                    else
                                    {
                                        Console.WriteLine("2 Şifre Hatalı!!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Varolan Şifre Hatalı Girildi!!.");
                                }
                            }
                            else if (Menu == "0")
                            {
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Ana Menü Seçimi!!");
                                Thread.Sleep(1000);
                            }

                            Console.WriteLine("Ana menü-9\nÇıkış-0\nSeçiminiz:");
                            string exit = Console.ReadLine();
                            if (exit == "0")
                            {
                                break;
                            }
                            else if (exit == "9")
                            {
                                continue;
                            }
                        }


                    }



                }
                else if (kartli == "2") { }
                else if (kartli == "Q")
                {
                    Console.WriteLine("Sistem Kapatılıyor.");
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış Lütfen Tekrar Deneyiniz!");
                    Thread.Sleep(5000);
                }
            }
        }
    }
}
