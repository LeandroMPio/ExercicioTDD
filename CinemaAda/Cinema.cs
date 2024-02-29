namespace CinemaAda;

public class Cinema
{
    public bool MeiaEntrada(Cliente cliente)
    {
        //return false;

        //if (cliente.Estudante == true)
        //{
        //    return true;
        //}


        //if (cliente.Estudante == true || cliente.DoadorDeSangue == true)
        //{
        //    return true;
        //}

        if (cliente.Estudante ||
            cliente.DoadorDeSangue ||
            (cliente.TrabalhaNaPrefeitura && cliente.PrefeituraTemContratoComCinema))
        {
            return true;
        }

        return false;
    }
}
