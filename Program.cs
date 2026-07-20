using System;
using QRCoder;

public class Program
{
    public static void Main()
    {
        string metin = "https://google.com"; // QR yapmak istediğiniz metni buraya yazın
        
        using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
        {
            using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(metin, QRCodeGenerator.ECCLevel.Q))
            {
                // Konsol ekranına metin tabanlı (ASCII) QR çizen motor
                using (AsciiQRCode qrCode = new AsciiQRCode(qrCodeData))
                {
                    string qrKoduMetni = qrCode.GetGraphic(1);
                    Console.WriteLine("Web Üzerinde C# ile Üretilen QR Kodunuz:\n");
                    Console.WriteLine(qrKoduMetni);
                }
            }
        }
    }
}
