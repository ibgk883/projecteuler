﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{
    class Program
    {             
        static void Main(string[] args)
        {
            //Console.WriteLine("BGK");
            void problem6()
            {
                //The sum of the squares of the first ten natural numbers is,
                //1^2 + 2^2 + ... + 10^2 = 385
                //The square of the sum of the first ten natural numbers is,
                //(1 + 2 + ... + 10)^2 = 55^2 = 3025
                //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
                //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

                double total = 0;
                double total_kare = 0;
                double tekli_kare = 0;
                total = (100 * 101) / 2;
                total_kare = Math.Pow(total, 2);                
                for (int i = 1; i <= 100; i++)
                {
                    tekli_kare += Math.Pow(i, 2);
                }

                Console.WriteLine("{0}", total_kare);

                Console.WriteLine("----------");

                Console.WriteLine("{0}", tekli_kare);

                Console.WriteLine("----------");

                Console.WriteLine("{0}", total_kare - tekli_kare);
            }
            void problem7()
            {
                //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
                //What is the 10 001st prime number ?


                int asalmi = 1;
                int bolen_sayisi = 0;
                int maxasal = 0;
                int count = 1;
                do
                {
                    bolen_sayisi = 0;
                    asalmi++;
                    for (int i = 1; i <= asalmi; i++)
                    {
                        if (asalmi % i == 0)
                        {
                            bolen_sayisi++;
                        }
                    }
                    if (bolen_sayisi > 2)
                    {                        
                    }
                    else
                    {
                        Console.WriteLine("{0}.asal {1}",count, asalmi);
                        maxasal = asalmi;
                        count++;
                    }
                    if (count == 10002)
                    {
                        break;
                    }
                } while (true);
                
            }
            void problem8()
            {
                    //The four adjacent digits in the 1000 - digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
                    //73167176531330624919225119674426574742355349194934
                    //96983520312774506326239578318016984801869478851843
                    //85861560789112949495459501737958331952853208805511
                    //12540698747158523863050715693290963295227443043557
                    //66896648950445244523161731856403098711121722383113
                    //62229893423380308135336276614282806444486645238749
                    //30358907296290491560440772390713810515859307960866
                    //70172427121883998797908792274921901699720888093776
                    //65727333001053367881220235421809751254540594752243
                    //52584907711670556013604839586446706324415722155397
                    //53697817977846174064955149290862569321978468622482
                    //83972241375657056057490261407972968652414535100474
                    //82166370484403199890008895243450658541227588666881
                    //16427171479924442928230863465674813919123162824586
                    //17866458359124566529476545682848912883142607690042
                    //24219022671055626321111109370544217506941658960408
                    //07198403850962455444362981230987879927244284909188
                    //84580156166097919133875499200524063689912560717606
                    //05886116467109405077541002256983155200055935729725
                    //71636269561882670428252483600823257530420752963450
                    //Find the thirteen adjacent digits in the 1000 - digit number that have the greatest product. What is the value of this product ?


                char[] sayilar = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450".ToArray();

                int sayı_uzunluk = sayilar.Length;                
                long carpim = 1;
                int x = 0;
                long enbuyuk = 1;                
                for (int i = 0; i < 988; i++)
                {
                    
                    carpim = (long)Char.GetNumericValue(sayilar[i]) * (long)Char.GetNumericValue(sayilar[i + 1]) * (long)Char.GetNumericValue(sayilar[i + 2]) * (long)Char.GetNumericValue(sayilar[i + 3]) * (long)Char.GetNumericValue(sayilar[i + 4]) * (long)Char.GetNumericValue(sayilar[i + 5]) * (long)Char.GetNumericValue(sayilar[i + 6]) * (long)Char.GetNumericValue(sayilar[i + 7]) * (long)Char.GetNumericValue(sayilar[i + 8]) * (long)Char.GetNumericValue(sayilar[i + 9]) * (long)Char.GetNumericValue(sayilar[i + 10]) * (long)Char.GetNumericValue(sayilar[i + 11]) * (long)Char.GetNumericValue(sayilar[i + 12]);

                    Console.Write("{14}.{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12} = {13}\n", sayilar[i], sayilar[i + 1], sayilar[i + 2], sayilar[i + 3], sayilar[i + 4], sayilar[i + 5], sayilar[i + 6], sayilar[i + 7], sayilar[i + 8], sayilar[i + 9], sayilar[i + 10], sayilar[i + 11], sayilar[i + 12], carpim, i);


                    if (carpim > enbuyuk)
                    {
                        x = i;
                        enbuyuk = carpim;                                                
                    }
                }                

                Console.WriteLine("<<<<<<<<<<<<{1},{0}>>>>>>>>>>>", enbuyuk, x);
            }            
            void problem9()
            {                
                double a, b, c;
                a = 1;
                b = 1;
                c = 1;
                double sonuc = 0;
                //200,375,425

                for (a = 1; a < 1000; a++)
                {                    
                    for (b = 1; b < 1000; b++)
                    {
                        for (c = 1; c < 1000; c++)
                        {
                            
                            if ((Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2)) && (a + b + c == 1000))
                            {
                                
                                Console.WriteLine("{0} , {1}, {2}", a, b, c);
                            }
                        }
                    }
                }


                sonuc = a * b * c;

            }
            void problem10()
            {
                //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
                //Find the sum of all the primes below two million.

                long toplam = 0;
                int sayi = 2;

                bool asalmi(int x)
                {
                    int bolen_sayisi = 0;
                    bool kontrol = false;

                    for (int i = 1; i <= x; i++)
                    {
                        if (x % i == 0)
                        {
                            bolen_sayisi++;
                        }
                        if (bolen_sayisi > 2)
                        {
                            break;
                        }
                    }
                    if (bolen_sayisi == 2)
                    {
                        kontrol = true;
                    }
                    return kontrol;
                }

                while (sayi < 2000000)
                {
                    if (asalmi(sayi))
                    {
                        toplam += sayi;
                        sayi++;
                        Console.WriteLine("{0}", toplam);

                    }
                    else
                    {
                        sayi++;
                    }

                }



            }
            void problem11()
            {
                    //In the 20×20 grid below, four numbers along a diagonal line have been marked in red.
                    //08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08
                    //49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00
                    //81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65
                    //52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91
                    //22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80
                    //24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50
                    //32 98 81 28 64 23 67 10 26 38 40 67 59 54 70 66 18 38 64 70
                    //67 26 20 68 02 62 12 20 95 63 94 39 63 08 40 91 66 49 94 21
                    //24 55 58 05 66 73 99 26 97 17 78 78 96 83 14 88 34 89 63 72
                    //21 36 23 09 75 00 76 44 20 45 35 14 00 61 33 97 34 31 33 95
                    //78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92
                    //16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57
                    //86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58
                    //19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40
                    //04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66
                    //88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69
                    //04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36
                    //20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16
                    //20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54
                    //01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48
                    //The product of these numbers is 26 × 63 × 78 × 14 = 1788696.
                    //What is the greatest product of four adjacent numbers in the same direction(up, down, left, right, or diagonally) in the 20×20 grid ?
            }
            void problem12()
            {

            }
            Problem1 pro1 = new Problem1();
            Problem2 pro2 = new Problem2();
            Problem3 pro3 = new Problem3();
            Problem4 pro4 = new Problem4();
            Problem5 pro5 = new Problem5();

            //pro1.problem1();
            //pro2.problem1();
            //pro3.problem1();
            //pro4.problem1();
            //pro5.problem1();
            

            Console.Read();
        }
    }
}
