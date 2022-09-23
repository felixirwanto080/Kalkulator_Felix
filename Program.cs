using System;  

namespace Kalkulator_Felix {  
    class Program {  
        static void Main(string[] args) { 
            var pilihan = "";
            int intPilihan = 0;

            var operasi = "";
            int intOperasi = 0;

            var input1 = "";
            double doubleInput1 = 0;
            var input2 = "";
            double doubleInput2 = 0;

            int operasiAman = 0;
            int bilangan1Aman = 0;
            int bilangan2Aman = 0;
            int keluarAman = 0;
            int maukeluar = 0;
            int keluar = 0; 
            
            do{
                operasiAman = 0;
                do{
                    Console.Clear();
                    Console.WriteLine("Selamat datang di Kalkulator!");  
                    Console.WriteLine("Tekan \"1\": Penambahan");  
                    Console.WriteLine("Tekan \"2\": Pengurangan");  
                    Console.WriteLine("Tekan \"3\": Perkalian");  
                    Console.WriteLine("Tekan \"4\": Pembagian");
                    Console.WriteLine("Tekan \"0\": Keluar");
                    Console.Write("Pilih Operasi Kalkulator: ");
                    operasi = Convert.ToString(Console.ReadLine());
                    bool boolOperasi = int.TryParse(operasi, out intOperasi);
                    if(boolOperasi){
                        operasiAman = 1;
                    }
                    else{
                        Console.WriteLine("Operasi Kalkulator tidak ditemukan!");  
                        Console.WriteLine("Tekan tombol untuk coba lagi!");  
                        Console.ReadKey();
                    }
                } 
                while(string.IsNullOrEmpty(operasi) | operasiAman != 1);

                if(intOperasi==0){
                    keluar=1;
                }
                
                else if(intOperasi>0 && intOperasi <=4){
                    double hasil = 0;
                    do{
                        bilangan1Aman = 0;
                        input1 = "";
                        doubleInput1 = -999;
                        Console.Clear();
                        Console.Write("Bilangan pertama: ");  
                        input1 = Convert.ToString(Console.ReadLine());
                        bool boolInput1 = double.TryParse(input1, out doubleInput1);

                        if(boolInput1){    
                            bilangan1Aman = 1;
                        }
                        else{
                            Console.WriteLine("Masukkan bilangan yang valid");  
                            Console.WriteLine("Tekan tombol untuk coba lagi!");  
                            Console.ReadKey();
                        }
                    }
                    while(string.IsNullOrEmpty(input1) | bilangan1Aman != 1);

                    do{
                        bilangan2Aman = 0;
                        input2 = "";
                        doubleInput2 = -999;
                        Console.Clear();
                        Console.Write("Bilangan kedua: ");  
                        input2 = Convert.ToString(Console.ReadLine());
                        bool boolInput2 = double.TryParse(input2, out doubleInput2);
                        if(boolInput2){
                            bilangan2Aman = 1;
                        }
                        else{
                            Console.WriteLine("Masukkan bilangan yang valid!");  
                            Console.WriteLine("Tekan tombol untuk coba lagi!");  
                            Console.ReadKey();
                        }
                    }
                    while(string.IsNullOrEmpty(input2) | bilangan2Aman != 1);

                    Console.Clear();
                    switch (intOperasi) {  
                        case 1: {  
                            hasil = Penambahan(doubleInput1, doubleInput2);
                            Console.WriteLine("Bilangan 1: {0}", doubleInput1);
                            Console.WriteLine("Bilangan 2: {0}", doubleInput2);
                            Console.WriteLine("Proses: Bilangan 1 + Bilangan 2 = Hasil");
                            Console.WriteLine("Hasil : {0} + {1} = {2}", doubleInput1, doubleInput2, hasil);
                            break;  
                        }  
                        case 2: {  
                            hasil = Pengurangan(doubleInput1, doubleInput2);  
                            Console.WriteLine("Bilangan 1: {0}", doubleInput1);
                            Console.WriteLine("Bilangan 2: {0}", doubleInput2);
                            Console.WriteLine("Proses: Bilangan 1 - Bilangan 2 = Hasil");
                            Console.WriteLine("Hasil : {0} - {1} = {2}", doubleInput1, doubleInput2, hasil);
                            break;
                            }  
                        case 3: {  
                            hasil = Perkalian(doubleInput1, doubleInput2); 
                            Console.WriteLine("Bilangan 1: {0}", doubleInput1);
                            Console.WriteLine("Bilangan 2: {0}", doubleInput2);
                            Console.WriteLine("Proses: Bilangan 1 x Bilangan 2 = Hasil");
                            Console.WriteLine("Hasil : {0} x {1} = {2}", doubleInput1, doubleInput2, hasil);
                            break;  
                        }  
                        case 4: { 
                            hasil = Pembagian(doubleInput1, doubleInput2);
                            Console.WriteLine("Bilangan 1: {0}", doubleInput1);
                            Console.WriteLine("Bilangan 2: {0}", doubleInput2);
                            Console.WriteLine("Proses: Bilangan 1 / Bilangan 2 = Hasil");
                            Console.WriteLine("Hasil : {0} / {1} = {2}", doubleInput1, doubleInput2, hasil);  
                            break;  
                        }  
                        default:  
                            Console.WriteLine("Operasi Kalkulator tidak ditemukan!");
                            Console.ReadKey();
                            break;  
                    }  
                    maukeluar = 0;
                    Console.WriteLine("Tekan tombol apapun untuk melanjutkan!");  
                    Console.ReadKey();  
                    Console.Clear();

                    while(maukeluar!=1){
                        do{
                            keluarAman = 0;
                            Console.Clear();
                            Console.WriteLine("Apakah Anda ingin menggunakan Kalkulator lagi?");  
                            Console.WriteLine("Tekan \"1\": Iya");  
                            Console.WriteLine("Tekan \"2\": Tidak \n"); 
                            Console.Write("Pilihan: "); 
                            pilihan = Convert.ToString(Console.ReadLine());
                            bool boolPilihan = int.TryParse(pilihan, out intPilihan);
                            if(intPilihan == 1){
                                maukeluar = 1;
                                keluar = 0;
                            }
                            else if(intPilihan == 2){
                                maukeluar = 1;
                                keluar = 1;
                            }
                            else{
                                maukeluar = 0;
                                keluar = 0;
                                Console.WriteLine("Pilihan tidak ditemukan!");  
                                Console.WriteLine("Tekan tombol untuk coba lagi!");  
                                Console.ReadKey();
                            }
                        } 
                        while(string.IsNullOrEmpty(pilihan) | keluarAman == 1);
                    }
                }
                else {
                    keluar=0;
                    Console.WriteLine("Operasi Kalkulator tidak ditemukan!");  
                    Console.WriteLine("Tekan tombol apapun untuk melanjutkan!");  
                    Console.ReadKey(); 
                }
            }
            while(keluar!=1);
            Console.WriteLine("Terimakasih telah menggunakan kalkulator!");  
            Console.WriteLine("Tekan tombol apapun untuk keluar!");  
            Console.ReadKey(); 
        }
        
        // Class untuk melakukan operasi penambahan  
        public static double Penambahan(double input1, double input2) {  
            double hasil = input1 + input2;  
            return hasil;  
        }

        // Class untuk melakukan operasi perkurangan  
        public static double Pengurangan(double input1, double input2) {  
            double hasil = input1 - input2;  
            return hasil;  
        }

        // Class untuk melakukan operasi perkalian  
        public static double Perkalian(double input1, double input2) {  
            double hasil = input1 * input2;  
            return hasil;  
        }

        // Class untuk melakukan operasi pembagian  
        public static double Pembagian(double input1, double input2) {  
            double hasil = input1 / input2;  
            return hasil;  
        }  
    }  
}