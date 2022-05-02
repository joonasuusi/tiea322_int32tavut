using System;
using System.Text;
public class test
{
    public static void Main()
    {
        byte[] tavut = SsrcTavuiksi(424242);
        System.Console.WriteLine("Arvolla 424242 koodisi antaa tavut ");
        string s = "";
        for (int i = 0; i < 4; i++)
        {
            s += Convert.ToString(tavut[i], 2).PadLeft(8, '0') + " ";
        }
        System.Console.WriteLine(s);
        Console.WriteLine("00000000 00000110 01111001 00110010");
    }


    // BYCODEBEGIN
    /// <summary>
    /// Funktio palauttaa 32- bittisen int-arvon jaettuna neljään tavuun.
    /// </summary>
    /// <param name="ssrc">32-bittinen int</param>
    /// <returns>32-bittinen int jaettuna tavuihin</returns>
    public static byte[] SsrcTavuiksi(int ssrc)
    {
        byte[] tavut = new byte[4];
        tavut[0] = (byte)((ssrc >> 24) & 0xFF);
        tavut[1] = (byte)((ssrc >> 16) & 0xFF);
        tavut[2] = (byte)((ssrc >> 8) & 0xFF);
        tavut[3] = (byte)(ssrc & 0xFF);
        return tavut;
    }
    // BYCODEEND

}

