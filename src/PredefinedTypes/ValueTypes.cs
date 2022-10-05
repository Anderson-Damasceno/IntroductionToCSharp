namespace src.PredefinedTypes;

public class ValueTypes {

    public static void PrintTypes(){
        // Integral-signed
        sbyte numSbyte = 8; //8-bits
        sbyte minSbyte = sbyte.MinValue;
        sbyte maxSbyte = sbyte.MaxValue;

        Console.WriteLine("{0} {1} {2}", numSbyte, minSbyte, maxSbyte);

        short numShort = 8; //16-bits
        short minShort = short.MinValue;
        short maxShort = short.MaxValue;

        Console.WriteLine("{0} {1} {2}", numShort, minShort, maxShort);

        int numInt = 8; // 32-bits
        int minInt = int.MinValue;
        int maxInt = int.MaxValue;

        Console.WriteLine("{0} {1} {2}", numInt, minInt, maxInt); 

        long numLong = 8; // 64-bits  
        long minLong = long.MinValue;
        long maxLong = long.MaxValue;

        Console.WriteLine("{0} {1} {2}", numLong, minLong, maxLong); 

        // Integral-unsigned

        byte nunByte = 8; // 8-bits
        byte minByte = byte.MinValue;
        byte maxByte = byte.MaxValue;

        Console.WriteLine("{0} {1} {2}", nunByte, minByte, maxByte);

        ushort numUshort = 8; // 16-bits
        ushort minUshort = ushort.MinValue;
        ushort maxUshort = ushort.MaxValue;

        Console.WriteLine("{0} {1} {2}", numUshort, minUshort, maxUshort);

        uint numUint = 8; // 32-bits
        uint minUint = uint.MinValue;
        uint maxUint = uint.MaxValue;

        Console.WriteLine("{0} {1} {2}", numUint, minUint, maxUint);
        
        ulong numUlong = 8; // 64-bits
        ulong minUlong = ulong.MinValue;
        ulong maxUlong = ulong.MaxValue;

        Console.WriteLine("{0} {1} {2}", numUlong, minUlong, maxUlong);

        // Real

        float numFloat = 8.1F; // 32-bits
        float minFloat = float.MinValue;
        float maxFloat = float.MaxValue;

        Console.WriteLine("{0} {1} {2}", numFloat, minFloat, maxFloat);

        double numDouble = 8.1D; // 64-bits
        double minDouble = double.MinValue;
        double maxDouble = double.MaxValue;

        Console.WriteLine("{0} {1} {2}", numDouble, minDouble, maxDouble);

        decimal nunDec = 8.1M; //128-bits
        decimal minDec = decimal.MinValue;
        decimal maxDec = decimal.MaxValue;

        Console.WriteLine("{0} {1} {2}", nunDec, minDec, maxDec);

        //Boolean

        bool valueT = true;
        bool valueF = false;

        Console.WriteLine("{0} {1}", valueT, valueF);

        //Char

        char letter = 'A';
        char unicode = '\u03A9';
        int minChar = char.MinValue;
        int maxChar = char.MaxValue;

        Console.WriteLine("{0} {1}",letter, unicode);
        Console.WriteLine("{0} {1}", minChar, maxChar);

    }
}