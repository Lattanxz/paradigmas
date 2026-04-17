namespace PrimerPracticaParadigma;

public class ParametrosSalida
{
    public ParametrosSalida()
    {}
    public static void buscarMayor(int x, int y, out int may, out int men)
    {
        if (x > y)
        {
            may = x;
            men = y;
        }
        else
        {
            may = y;
            men = x;
        }
    }
    public static bool buscarPlus(int x, int y, out int may, out int men)
    {
        bool todoBien = true;
        if (x == y)
        {
            may = 0;
            men = 0;
            todoBien = false;
        } else if (x > y)
        {
            may = x;
            men = y;
        }
        else
        {
            may = y;
            men = x;
        }

        return todoBien;
    }
}