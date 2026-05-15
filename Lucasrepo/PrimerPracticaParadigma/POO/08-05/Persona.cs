using System.Globalization;

namespace PrimerPracticaParadigma.POO._08_05;

public class Persona
{
    private int _legajo;
    private string _apellido;
    private float _sueldo;
    private string deporte;

    public Persona()
    {
        this._legajo = 0;
        this._apellido = string.Empty;
        this._sueldo = 1000;
    }

    public Persona(int leg, string dep)
    {
        this._legajo = leg;
        this._apellido = string.Empty;
        this.deporte = dep;
        this._sueldo = 0;
    }
    public Persona(int leg, string apel, float sue)
    {
        this._legajo = leg;
        this._apellido = apel;
        this._sueldo = sue;
    }
    public int Legajo
    {
        get => _legajo;
        set
        {
            if (value > 5000)
                _sueldo = value;
            else
                throw new ArgumentOutOfRangeException("No puede haber un legajo mayor a 5000" );
        }
    }

    public string Apellido
    {
        get => _apellido;
        set => _apellido = value;
    }

    public float Sueldo
    {
        get => _sueldo;
        set
        {
            if (value >= 0)
            {
                _sueldo = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("No se puede poner un sueldo negativo");
            }
        }
    }

    public string Deporte
    {
        get => deporte;
        set => deporte = value;
    }
}