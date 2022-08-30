internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Bir sayi giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmis oldugunuz sayi :" + sayi);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Hata: "+ ex.Message.ToString());
        }
        finally
        {
            Console.WriteLine("İslem Tamamlandi");
        }

        try
        {
            //int a = int.Parse(null);
            //int a = int.Parse("test");
            int a = int.Parse("-2123123123123");
        }
        catch (ArgumentNullException ex)
        {
            
            Console.WriteLine("Bos deger girdiniz");
            Console.WriteLine(ex);
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Veri tipi uygun degil");
            Console.WriteLine(ex);
        }
        catch(OverflowException ex)
        {
            Console.WriteLine("Cok kucuk yada cok buyuk bır deger gırdınız");
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine("Islem basariyla tamamlandi");
        }
    }
}