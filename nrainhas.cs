class Program
{
    static void Main()
    {
        int n = 10;
        distribuirRainhasNoTabuleiro(n);
    }

    static void distribuirRainhasNoTabuleiro(int n)
    {
        bool[,] tabuleiro = new bool[n, n];
        (int, int)[] rainhas = new (int, int)[n];

        for (int i = 0; i < n; i++)
        {
            rainhas[i] = (0,i); 

            for(int j = 0; j < n; j++){

                tabuleiro[i, j] = true; 
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(tabuleiro[i,j] == false){
                    breake;
                }
                for(int c = 1; c < n; c++){
                    if(tabuleiro[i,j]==false){
                        break;
                    }
                }
            }
            
        }
    }
}