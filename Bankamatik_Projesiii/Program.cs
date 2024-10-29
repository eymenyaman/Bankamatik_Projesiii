using System;
using System.Collections.Concurrent;
using System.ComponentModel.Design;
using System.Reflection.Metadata;

namespace Bankamatik_Projesiii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 25000;


        //    string sıfre = "ab18";




        //#region Şifre Yeri
        //sıfreyerıne:
        //    Console.WriteLine("Şifreniz Nedir");
        //    string şifre = Console.ReadLine();

        //   if (sıfre==şifre)
        //    {
        //        Console.WriteLine("Giriş Başarılı");


        //    }
        //            else
        //    {
        //        Console.WriteLine("Giriş Başarısız : Lütfen Tekrar Deneyin");
        //        goto sıfreyerıne;
        //    }

        //#endregion


        #region ANA MENÜ
        ANAMENU:
            Console.WriteLine("*** Bankamatiğe Hoşgeldiniz");
            Console.WriteLine("Ana Menü");
            Console.WriteLine("1, Para Çekmek");
            Console.WriteLine("2, Para Yatırmak");
            Console.WriteLine("3, Para Transferleri");
            Console.WriteLine("4, Eğitim Ödemeleri");
            Console.WriteLine("5, Ödemeler");
            Console.WriteLine("6, Bilği Güncelleme ");
            Console.WriteLine("Çıkmak İçin 0");
            int ifadeler = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region  Yanlış Sayı Girildiğinde Ana Menüye Atıcak
            if (ifadeler > 7 /*|| ifadeler > 100*/)
            {
                Console.WriteLine("Yanlış Sayı Girdiniz Ana Menüye Yönlendiriliyorsunuz");

                goto ANAMENU;
            }
            #endregion

            #region 0 Tıkladığında Çıkış
            if (ifadeler == 0)
            {
                Console.Clear();
                Console.WriteLine("İyi Günler");
            }
            #endregion

            #region Para Çekmek + Yetersiz Bakiye + ÇIKIŞ ANA MENÜ
            if (ifadeler == 1)
            {
                Console.WriteLine("Ne Kadar Tutarda Para Çekmek İstiyorsunuz");
                int bakiye_çekmek = Convert.ToInt32(Console.ReadLine());

                if (bakiye_çekmek < bakiye)
                {
                    bakiye = bakiye - bakiye_çekmek;
                    Console.WriteLine(" Para Çekim Başarılı İle Gerçekleştirildi");
                    Console.WriteLine("İşlem Sonu Kalan Bakiye");
                    Console.WriteLine(bakiye);

                    Console.WriteLine("Ana Menüye Gitmek İçin 7");
                    Console.WriteLine("Çıkış Yapmak İçin 0");
                    string bakıye_cıkısanamenu = Console.ReadLine();

                    if (bakıye_cıkısanamenu == "7")
                    {
                        goto ANAMENU;

                    }
                    if (bakıye_cıkısanamenu == "0")
                    {
                        Console.Clear();
                        Console.WriteLine("İyi Günler :)");

                    }

                }




                else
                {
                    Console.WriteLine("Yetersiz Bakiye");

                    Console.WriteLine("Çıkış Yapmak İçin 0");

                    Console.WriteLine("Ana Menüye Gitmek İçin 7");
                    string secim = Console.ReadLine();

                    if (secim == "0")
                    {
                        Console.Clear();
                        Console.WriteLine("İyi Günler :) ");

                    }

                    if (secim == "7")
                    {
                        goto ANAMENU;
                    }
                }
            }
            #endregion


            #region Para Yatırmak 

            if (ifadeler == 2)
            {
                Console.WriteLine("1, Kredi Kartına ");
                Console.WriteLine("2, Hesabınıza Yatırmak İçin ");
                string parayatırmak = Console.ReadLine();

                if (parayatırmak == "1")
                {
                kredıkartyatırma:
                    // Kredi Kartına Para Yatırma İşlemi

                    Console.WriteLine("12 Haneli Kredi Kart Numaranızı Girin");
                    string kartnumarası = Console.ReadLine();
                    int kartnumarası12 = kartnumarası.Length;

                    if (kartnumarası12 == 12)
                    {

                        Console.WriteLine("Ne Kadar Tutarda Para Yatırılacak");
                        int kredıkartı_para = Convert.ToInt32(Console.ReadLine());



                        if (kartnumarası12 < kredıkartı_para)
                        {
                            bakiye = bakiye - kredıkartı_para;
                            Console.WriteLine("İşlem Başarılı Bir Şekilde Gerçekleşti");
                            Console.WriteLine("İşlem Sonu Bakiyede Kalan Para ");
                            Console.WriteLine(bakiye);
                            Console.WriteLine("Ana Menüye Geçmek İçin 7");
                            Console.WriteLine("Çıkış Yapmak İçin 0");
                            // Kredı Kartı Cıkıs menu
                            string cıkıs_anamenu = Console.ReadLine();



                            if (cıkıs_anamenu == "7")
                            {
                                goto ANAMENU;
                            }
                            if (cıkıs_anamenu == "0")
                            {
                                Console.Clear();
                                Console.WriteLine("İyi Günler :) ");
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("Başarısız Sonuçlandı");
                        Console.WriteLine("Lütfen 12 Haneli Numara Girin");
                        goto kredıkartyatırma;


                    }
                }

                //Kendi Hesabıma Yatırılcak Tutar
                if (ifadeler == 2)
                {
                    Console.WriteLine("Ne Kadar Hesabınıza Para Yatırmak İstiyorsunuz");
                    int hesabına_parayatırma = Convert.ToInt32(Console.ReadLine());


                    if (parayatırmak == "2")
                    {
                        bakiye = bakiye + hesabına_parayatırma;
                        Console.WriteLine("İşlem Başarılı Bir Şekilde Gerçekleştirilmiştir");
                        Console.WriteLine("İşlem Sonu Yatırılan Bakiyenizin Toplamı ");
                        Console.WriteLine(bakiye);
                        Console.WriteLine("Ana Menuye Gitmek İçin 7");
                        Console.WriteLine("Çıkış Yapmak İçin 0");
                        // hesaba para yatırmak çıkış menu 
                        string hesabacıkısmenu = Console.ReadLine();

                        if (hesabacıkısmenu == "7")
                        {
                            goto ANAMENU;
                        }
                        if (hesabacıkısmenu == "0")
                        {
                            Console.Clear();
                            Console.WriteLine("İyi Günler");
                        }


                    }
                }
            }

            #endregion


            #region Havale-Eft

            if (ifadeler == 3)
            {

                Console.WriteLine("1, Başka Hesaba Eft");
                Console.WriteLine("2, Başka Hesaba Havale");
                string paratransferleriifade = Console.ReadLine();



                if (paratransferleriifade == "1")
                {
                efttransfer:
                    Console.WriteLine("TR Başında Olmak Zorunluluğu İle 12 Hanaeli İban Yazın");
                    string eftnumarası = Console.ReadLine();
                    int eftişlemi = eftnumarası.Length;



                    if (eftnumarası.StartsWith("tr") && eftnumarası.Length == 14)
                    {

                        Console.WriteLine("Ne Kadarlık Bir İşlem Yapmak İstiyorsunuz");
                        int eftpara = Convert.ToInt32(Console.ReadLine());








                        if (eftpara < bakiye)
                        {
                            bakiye = bakiye - eftişlemi;
                            Console.WriteLine("  İşlem Başarılı İle Gerçekleştirilmiştir");
                            Console.WriteLine("İşlem Sonu Hesabınızda Olan Bakiye");
                            Console.WriteLine(bakiye);
                            Console.WriteLine("Ana Menüye Gitmek İstiyorsanız 7");
                            Console.WriteLine("Çıkış Yapmak İstiyorsanız 0");
                            int eft_anacıkıs = Convert.ToInt32(Console.ReadLine());





                            if (eft_anacıkıs == 7)
                            {
                                goto ANAMENU;
                            }
                            if (eft_anacıkıs == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("İyi Günler :)");
                            }



                        }
                        else
                        {
                            Console.WriteLine("Yetersiz Bakiye");
                            Console.WriteLine("Çıkış İçin 0");
                            Console.WriteLine("Ana Menü İçin 7");
                            int havaleeftcıkıs = Convert.ToInt32(Console.ReadLine());


                            if (havaleeftcıkıs == 7)
                            {
                                goto ANAMENU;
                            }
                            if (havaleeftcıkıs == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("İyi Günler");
                            }
                        }
                    }


                    else
                    {

                        Console.WriteLine("Lütfen Geçerli Iban Giriniz");
                        goto efttransfer;
                    }


                }


                #endregion

                #region Hesaba-Havale

                if (paratransferleriifade == "2")
                {
                havaleeft:
                    Console.WriteLine("11 Haneli Hesab Numarası Girin");
                    string hesabnumarası = Console.ReadLine();


                    if (hesabnumarası.Length == 11)
                    {
                        Console.WriteLine("Ne Kadarlık Tutarda İşlem Yapılacak");
                        int hesabhavale = Convert.ToInt32(Console.ReadLine());

                        if (hesabhavale < bakiye)
                        {
                            bakiye = bakiye - hesabhavale;
                            Console.WriteLine("İşlem Başarılı İle Gerçekleştirilmiştir");
                            Console.WriteLine("İşlem Sonu Hesabınızda Olan Tutar");
                            Console.WriteLine(bakiye);
                            Console.WriteLine("Ana Menüye Gitmek İçin 7");
                            Console.WriteLine("Çıkış Yapmak için 0");
                            int hesabcıkısana = Convert.ToInt32(Console.ReadLine());

                            if (hesabcıkısana == 7)
                            {
                                goto ANAMENU;
                            }
                            if (hesabcıkısana == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("İyi Günler :)");
                            }


                        }
                        else
                        {
                            Console.WriteLine("Yetersiz Bakiye");
                            Console.WriteLine("Çıkış İçin 0");
                            Console.WriteLine("Ana Menüye Gitmek İçin 7");
                            // havale yetersız cıkıs ana
                            int havaleyetersız = Convert.ToInt32(Console.ReadLine());

                            if (havaleyetersız == 7)
                            {
                                goto ANAMENU;

                            }

                            if (havaleyetersız == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("İyi Günler :)");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lütfen Geçerli Hesab Numarası Girin");
                        goto havaleeft;
                    }
                }



            }
            #endregion

            #region Eğitim Ödemeleri
            if (ifadeler == 4)
            {
                Console.WriteLine("Eğitim Ödemeleri Sayfası Arızalı");
                Console.WriteLine("Ana Menüye Geçmek İçin 7");
                Console.WriteLine("Çıkış Yapmak İçin 0");
                int egıtımcıkısana = Convert.ToInt32(Console.ReadLine());

                if (egıtımcıkısana == 7)
                {
                    goto ANAMENU;
                }
                if (egıtımcıkısana == 0)
                {
                    Console.Clear();
                    Console.WriteLine("İyi Günler");
                }
            }
            #endregion

            #region Faturaların Ödemesi
            if (ifadeler == 5)
            {
                Console.WriteLine("1, Elektirik Faturası");
                Console.WriteLine("2, Telefon Faturası");
                Console.WriteLine("3, İnternet Faturası");
                Console.WriteLine("4, Su Faturası");
                Console.WriteLine("5, Ogs Ödemeleri");
                Console.WriteLine("7 Ana Menüye Dön");
                Console.WriteLine("0 Çıkış Yap ");
                string faturasecenekleri = Console.ReadLine();

                if (faturasecenekleri == "7")
                {
                    goto ANAMENU;
                }
                if (faturasecenekleri == "0")
                {
                    Console.Clear();
                    Console.WriteLine("İyi Günler");
                }
                if (faturasecenekleri == "1")
                {
                    Console.WriteLine("Ne Kadar Tutarda Elektirik Faturasını Ödemek İstiyorsunuz");
                    int elektirikfaturası = Convert.ToInt32(Console.ReadLine());



                    if (elektirikfaturası < bakiye)
                    {

                        bakiye = bakiye - elektirikfaturası;
                        Console.WriteLine("İşlem Başarılı Bir Şekilde Gerçekleştirildi");
                        Console.WriteLine("İşlem Sonu Bakiyenizde Olan Para");
                        Console.WriteLine(bakiye);
                        Console.WriteLine("Ana Menüye Dönmek İçin 7");
                        Console.WriteLine("Çıkış Yapmak İçin 0");
                        int elektırık_cıkıs_anamenu = Convert.ToInt32(Console.ReadLine());

                        if (elektırık_cıkıs_anamenu == 7)
                        {
                            goto ANAMENU;
                        }
                        if (elektırık_cıkıs_anamenu == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("İyi Günler :)");
                        }



                    }

                    else
                    {
                        Console.WriteLine("Yetersiz Bakiye");
                        Console.WriteLine("Ana Menüye Dönmek İçin 7");
                        Console.WriteLine("Çıkış Yapmak İçin 0");
                        int yetersızelektırık_cıkısana = Convert.ToInt32(Console.ReadLine());

                        if (yetersızelektırık_cıkısana == 7)
                        {
                            goto ANAMENU;
                        }
                        if (yetersızelektırık_cıkısana == 0)
                        {
                            Console.Clear();
                        }
                    }
                }

                //  Elektirik Faturasının Bittiği Yer

                if (faturasecenekleri == "2")
                {
                    Console.WriteLine("Telefon Faturasının Ne Kadar Tutarda Ödemek İstiyorsunuz");
                    int telefonfaturası = Convert.ToInt32(Console.ReadLine());

                    if (telefonfaturası < bakiye)
                    {
                        bakiye = bakiye - telefonfaturası;
                        Console.WriteLine("İşlem Başarılı Bir Şekilde Gerçekleştirildi");
                        Console.WriteLine("İşlem Sonu Bakiyede Olan Tutar");
                        Console.WriteLine(bakiye);
                        Console.WriteLine("Ana Menüye Dönmek İçin 7");
                        Console.WriteLine("Çıkış Yapmak İçin 0 ");
                        int telefon_cıkıs_ana = Convert.ToInt32(Console.ReadLine());

                        if (telefon_cıkıs_ana == 7)
                        {
                            goto ANAMENU;
                        }
                        if (telefon_cıkıs_ana == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("İyi Günler");
                        }

                        else
                        {
                            Console.WriteLine("Yetersiz Bakiyeeeeeeeeee");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Yetersiz Bakiye ");
                        Console.WriteLine("Ana Menüye Dönmek İçin 7");
                        Console.WriteLine("Çıkış Yapmak İçin 0");
                        // yetersiz bakiye telefon:
                        int telefon2_cıkısana = Convert.ToInt32(Console.ReadLine());

                        if (telefon2_cıkısana == 7)
                        {
                            goto ANAMENU;
                        }
                        if (telefon2_cıkısana == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("İyi Günler :)");
                        }
                    }

                }

                // Telefon Faturasınım Bitiği Yer

                if (faturasecenekleri == "3")
                {
                    Console.WriteLine("Ne Kadar Tutarda İnternet Faturası Ödemek İstiyorsunuz");
                    int internetfaturası = Convert.ToInt32(Console.ReadLine());

                    if (internetfaturası < bakiye)
                    {
                        bakiye = bakiye - internetfaturası;
                        Console.WriteLine("İşlem Başarılı İle Gerçekleşti");
                        Console.WriteLine("İşlem Sonu Bakiyenizde Olan Tutar");
                        Console.WriteLine(bakiye);
                        Console.WriteLine("Ana Menüye Gitmek İçin 7");
                        Console.WriteLine("Çıkış Yapmak İçin 0");
                        int internet_cıkıs_ana = Convert.ToInt32(Console.ReadLine());

                        if (internet_cıkıs_ana == 7)
                        {
                            goto ANAMENU;

                        }
                        if (internet_cıkıs_ana == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("İyi Günler");

                        }

                    }

                    else
                    {
                        Console.WriteLine("Yetersiz Bakiye");
                        Console.WriteLine("Ana Menüye Dönmek İçin 7 ");
                        Console.WriteLine("Çıkış Yapmak İçin 0");
                        // İnternet cıkıs ana
                        int internetcıkkk = Convert.ToInt32(Console.ReadLine());

                        if (internetcıkkk == 7)
                        {
                            goto ANAMENU;
                        }
                        if (internetcıkkk == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("İyi Günler");
                        }
                    }

                }

                // İnternet Faturası Bitiş


                if (faturasecenekleri == "4")
                {
                    Console.WriteLine("Ne Kadar Tutarda Su Faturası Ödemek İstiyorsunuz");
                    int sufaturası = Convert.ToInt32(Console.ReadLine());

                    if (sufaturası < bakiye)
                    {
                        bakiye = bakiye - sufaturası;
                        Console.WriteLine("İşlem Başarılı İle Gerçekleşti");
                        Console.WriteLine("İşlem Sonu Bakiyenizde Olan Tutar");
                        Console.WriteLine(bakiye);
                        Console.WriteLine("Ana Menüye Dönmek İçin 7");
                        Console.WriteLine("Çıkış Yapmak İçin 0");
                        // cıkıs ana
                        int suc_cıkıs_ana = Convert.ToInt32(Console.ReadLine());

                        if (suc_cıkıs_ana == 7)
                        {
                            goto ANAMENU;
                        }
                        if (suc_cıkıs_ana == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("İyi Günler :)");
                        }


                    }

                    else
                    {
                        Console.WriteLine("Yetersiz Bakiye");
                        Console.WriteLine("Ana Menüye Gitmek İçin 7");
                        Console.WriteLine("Çıkış Yapmak İçin 0");
                        int su_yetersız = Convert.ToInt32(Console.ReadLine());

                        if (su_yetersız == 7)
                        {
                            goto ANAMENU;
                        }
                        if (su_yetersız == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("İyi Günler");
                        }

                    }
                }

                // Su Faturasının Bitişi

                if (faturasecenekleri == "5")
                {
                    Console.WriteLine("Ne Kadar Tutarda Ogs Faturasını Ödemek İstiyorsunuz");
                    int ogsfatura = Convert.ToInt32(Console.ReadLine());

                    if (ogsfatura <= bakiye)
                    {
                        bakiye = bakiye - ogsfatura;
                        Console.WriteLine("İşlem Başarılı İle Gerçekleştirildi");
                        Console.WriteLine("İşlem Sonu Bakiyede Olan Tutar ");
                        Console.WriteLine(bakiye);
                        Console.WriteLine("Ana Menüye Girmek İçin 7");
                        Console.WriteLine("Çıkış Yapmak İçin 0");
                        int ogs_cıkısana = Convert.ToInt32(Console.ReadLine());

                        if (ogs_cıkısana == 7)
                        {
                            goto ANAMENU;
                        }
                        if (ogs_cıkısana == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("İyi Günler :)");
                        }



                    }

                    else
                    {
                        Console.WriteLine("Yetersiz Bakiye");
                        Console.WriteLine("Ana Menüye Dönmek İçin 7");
                        Console.WriteLine("Çıkış Yapmak İçin 0 ");
                        int ogsyetersız_cıkıs_ana = Convert.ToInt32(Console.ReadLine());

                        if (ogsyetersız_cıkıs_ana == 7)
                        {
                            goto ANAMENU;
                        }
                        if (ogsyetersız_cıkıs_ana == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("İyi Günler :)");
                        }
                    }
                }



            }
        }
    }
}
            #endregion

            