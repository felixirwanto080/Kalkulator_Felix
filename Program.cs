using System;  

namespace Kalkulator_Felix {  
    class Program {  
        static void Main(string[] args) {  
            Console.WriteLine("Pilih operasi kalkulator:");  
            Console.WriteLine("Tekan \"1\": Penambahan");  
            Console.WriteLine("Press \"2\": Pengurangan");  
            Console.WriteLine("Press \"3\": Perkalian");  
            Console.WriteLine("Press \"4\": Pembagian \n");  
            int operasi = Convert.ToInt32(Console.ReadKey());
            Console.Clear();

            Console.WriteLine("Enter 1st input");  
            double input_1 = Convert.ToDouble(Console.ReadLine());  
            Console.WriteLine("Enter 2nd input");  
            double input_2 = Convert.ToDouble(Console.ReadLine());  
            double result = 0;  
            switch (operasi) {  
                case 1: {  
                    result = Penambahan(input_1, input_2);  
                    break;  
                }  
                case 2: {  
                    result = Pengurangan(input_1, input_2);  
                    break;
                    }  
                case 3: {  
                    result = Perkalian(input_1, input_2);  
                    break;  
                }  
                case 4: {  
                    result = Pembagian(input_1, input_2);  
                    break;  
                }  
                default:  
                    Console.WriteLine("Operasi Kalkulator tidak ditemukan!");  
                    break;  
            }  
            Console.WriteLine("The result is {0}", result);  
            Console.ReadKey();  
        }  
        // Class untuk melakukan operasi penambahan  
        public static double Penambahan(double input_1, double input_2) {  
            double result = input_1 + input_2;  
            return result;  
        }  
        // Class untuk melakukan operasi perkurangan  
        public static double Pengurangan(double input_1, double input_2) {  
            double result = input_1 - input_2;  
            return result;  
        }
        // Class untuk melakukan operasi perkalian  
        public static double Perkalian(double input_1, double input_2) {  
            double result = input_1 * input_2;  
            return result;  
        }  
        // Class untuk melakukan operasi pembagian  
        public static double Pembagian(double input_1, double input_2) {  
            double result = input_1 / input_2;  
            return result;  
        }  
    }  
}