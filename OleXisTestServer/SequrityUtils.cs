﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace OleXisTestServer
{
    static class SequrityUtils
    {
        static public string DiffieHellmanGetPublicKey(out CngKey generatedKey)
        {
            var df = new ECDiffieHellmanCng(256);
            generatedKey = df.Key;
            return df.PublicKey.ToXmlString();
        }

        static public byte[] DiffieHellmanGetSecretKey(string publicKey, CngKey otherDFInstanceKey)
        {
            var df = new ECDiffieHellmanCng(otherDFInstanceKey);
            return df.DeriveKeyMaterial(ECDiffieHellmanCngPublicKey.FromXmlString(publicKey));
        }

        static public byte[] DiffieHellmanGetSecretKey(string publicKey)
        {
            var df = new ECDiffieHellmanCng(256);
            return df.DeriveKeyMaterial(ECDiffieHellmanCngPublicKey.FromXmlString(publicKey));
        }

        public static byte[] Encrypt(string data, byte[] key)
        {
            //Объявляем объект класса AES
            Aes aes = Aes.Create();
            //Генерируем соль
            aes.GenerateIV();
            //Присваиваем ключ. aeskey - переменная (массив байт), сгенерированная методом GenerateKey() класса AES
            aes.Key = key;
            byte[] encrypted;
            ICryptoTransform crypt = aes.CreateEncryptor(aes.Key, aes.IV);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, crypt, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(data);
                    }
                }
                //Записываем в переменную encrypted зашиврованный поток байтов
                encrypted = ms.ToArray();
            }
            //Возвращаем поток байт + крепим соль
            return encrypted.Concat(aes.IV).ToArray();
        }

        static public string Decrypt(byte[] encryptedData, byte[] key)
        {
            byte[] bytesIv = new byte[16];
            byte[] mess = new byte[encryptedData.Length - 16];
            for (int i = encryptedData.Length - 16, j = 0; i < encryptedData.Length; i++, j++)
                bytesIv[j] = encryptedData[i];
            //Списываем оставшуюся часть сообщения
            for (int i = 0; i < encryptedData.Length - 16; i++)
                mess[i] = encryptedData[i];
            //Объект класса Aes
            Aes aes = Aes.Create();
            //Задаем тот же ключ, что и для шифрования
            aes.Key = key;
            //Задаем соль
            aes.IV = bytesIv;
            //Строковая переменная для результата
            string text = "";
            byte[] data = mess;
            ICryptoTransform crypt = aes.CreateDecryptor(aes.Key, aes.IV);
            using (MemoryStream ms = new MemoryStream(data))
            {
                using (CryptoStream cs = new CryptoStream(ms, crypt, CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(cs))
                    {
                        //Результат записываем в переменную text в вие исходной строки
                        text = sr.ReadToEnd();
                    }
                }
            }
            return text;
        }

        static public string GetHash(string value)
        {
            var sha = SHA256Managed.Create();
            var stringHash = new StringBuilder();
            var arrayHash = sha.ComputeHash(Encoding.UTF8.GetBytes(value));
            foreach (byte b in arrayHash)
                stringHash.Append(b.ToString("x2"));
            return stringHash.ToString();
        }
    }
}
