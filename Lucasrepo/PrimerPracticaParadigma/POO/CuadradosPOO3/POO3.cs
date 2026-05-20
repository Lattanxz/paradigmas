namespace PrimerPracticaParadigma.POO.CuadradosPOO3;

public enum relleno
{
    Vacio,
    Relleno,
    Liso,
}

public class Cuadrado
{
    private relleno _fondo;
    private int _lado;

    public Cuadrado()
    {
        this.Fondo = relleno.Vacio;
        this.Lado = 1;

    }

    public relleno Fondo
    {
        get => _fondo;
        set => _fondo = value;
    }

    public int Lado
    {
        get => _lado;
        set
        {
            if (value > 0)
            {
                this._lado = value;
            }
        }
    }
    public int Perimetro
    {
        get
        {
            // Defino que el perimetro es solo de lectura.
            return this.Lado * 4;
        }
    }

    public int superficie
    {
        get
        {
            return this.Lado * this.Lado;
        }
    }
}