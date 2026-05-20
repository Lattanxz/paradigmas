namespace PrimerPracticaParadigma.POO.Bolilleros;

public class Bolilla
{
    private colores _color;
    private int _nro;

    public Bolilla()
    {
        this.color = colores.Amarillo;
        this.nro = 0;
    }

    public Bolilla(colores color, int nro)
    {
        this.color = color;
        this.nro = nro;
    }
    
    public colores color
    {
        get => _color;
        set
        {
            if (value != colores.Amarillo || value != colores.Azul || value != colores.Blanco)
            {
                throw new ArgumentOutOfRangeException("Manda un valor bostero.");
            }
            else
            {
                color = value;
            }
        }
    }

    public int nro
    {
        get => _nro;
        set
        {
            if (value == 0 || value <= 36)
            {
                _nro = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("manda un numero entre 0 y 36");
            }
        }
    }
}