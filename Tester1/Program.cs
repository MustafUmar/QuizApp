using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tester1
{
    class Program
    {
        int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.loopthru();
            var list = new List<Int32>() { 2, 5, 9, 3, 2 };
            var rnd = new Random();
            //list.RemoveAll(x => x == 2);
            //list.ForEach(x => Console.WriteLine(x));

            //var products = new List<Product>() {
            //    new Product { name = "Shirt", price = 25.0 },
            //    new Product { name = "Trouser", price = 30.0 },
            //    new Product { name = "Jersey", price = 50.0 },
            //};
            //var usingfind = products.FindIndex(p => p.name.Equals("Jsey"));
            //Console.WriteLine(usingfind);

            //var lowest = p.nums.Reverse().ToList().FindIndex(x => x < 6);
            //Console.WriteLine(p.nums.Reverse().ToList()[lowest]);


            //list.Remove(11);
            //list.ForEach(x => Console.WriteLine(x));

            //Stopwatch sp = new Stopwatch();
            //sp.Start();
            //Console.WriteLine("Started");
            //Thread.Sleep(7000);
            //sp.Stop();
            //Console.WriteLine("Stopped");
            //Console.WriteLine("Elapsed time: "+sp.ElapsedMilliseconds/1000);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[rnd.Next(list.Count)]);
            //}

            var cleartext = "Richmond Boakye";
            string secret = Program.Encrypt(cleartext);
            Console.WriteLine(secret);
            Console.WriteLine(Program.Decrypt(secret)); 
            Console.ReadKey();
        }

        //Testing asynchronous delay in function
        public async void loopthru()
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
                await Task.Delay(2000);
            }
        }

        //Encryption test
        public static string Encrypt(string clearText)
        {
            string EncryptionKey = "abc123";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        //cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "abc123";
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        //cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }

    class Product
    {
        public string name { get; set; }
        public double price { get; set; }
    }

}
