namespace OOP.Struct;

struct DigitalSize
{
    private long _bit;
    public string Bit => $"{(_bit / bitsinBit)} Bit";
    public string Byte => $"{(_bit / bitsinByte)} Byte";
    public string KB => $"{(_bit / bitsinKB)} KB";
    public string MB => $"{(_bit / bitsinMB)} MB";
    public string GB => $"{(_bit / bitsinGB)} GB";
    public string TB => $"{(_bit / bitsinTB)} TB";
    
    
    private const long bitsinBit = 1;
    private const long bitsinByte = 8*bitsinBit;
    private const long bitsinKB = bitsinByte * 1024;
    private const long bitsinMB = bitsinKB * 1024;
    private const long bitsinGB = bitsinMB * 1024;
    private const long bitsinTB = bitsinGB * 1024;
    
    

    public DigitalSize(long bit)
    {
        this._bit = bit;
    }



    public DigitalSize AddBit(long bit)
    {
        return  Add(bit,bitsinBit);
    }

    public DigitalSize Add(long value,long scale)
    {
        return new DigitalSize(value * scale);
        
        
    }
    

}