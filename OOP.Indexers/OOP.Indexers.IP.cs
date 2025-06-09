namespace OOP.Indexers;

public class IP
{
    private int[] _seqment = new int[4];

    public int this[int index]
    {
        set
        {
            _seqment[index] = value;   
        }
        get
        {
            return _seqment[index];
        }
    }
    public IP(int seqment1, int seqment2, int seqment3, int seqment4)
    {
        _seqment[0] = seqment1;
        _seqment[1] = seqment2;
        _seqment[2] = seqment3;
        _seqment[3] = seqment4;
    }

    public IP(string ipString)
    {
        var split = ipString.Split('.');
        for (int i = 0; i < split.Length; i++)
            _seqment[i] = Convert.ToInt32(split[i]);
    }
    public String Address=> String.Join(".", _seqment);
}