namespace OOP.Indexers;

public class Suduko
{
    private int[,] _matrix;

    public int this[int col, int row]
    {
        set
        {
            if(value < 1 || value>_matrix.GetLength(0) )
                return;
            _matrix[col, row] = value;
        }
        get
        {
            if(row<0 || row>_matrix.GetLength(0)-1 )
                return -1;
            if(col<0 || col>_matrix.GetLength(0)-1 )
                return -1;
            return _matrix[col,row];
        }
    }

    public Suduko(int[,] matrix)
    {
        _matrix = matrix;
        
    }
}