public class Estacionamiento
{
    private int lugaresDisponibles;
    private const int capacidadMaxima = 80;

    public Estacionamiento(int lugaresIniciales)
    {
        if (lugaresIniciales < 0 || lugaresIniciales > capacidadMaxima)
        {
            throw new ArgumentException("El número inicial de lugares no puede ser negativo ni mayor que la capacidad máxima.");
        }
        
        this.lugaresDisponibles = lugaresIniciales;
    }

    public int ConsultarLugaresDisponibles()
    {
        return lugaresDisponibles;
    }

    public void AgregarLugares(int cantidad)
    {
        if (cantidad < 0)
        {
            throw new ArgumentException("La cantidad de lugares a agregar no puede ser negativa.");
        }

        if (lugaresDisponibles + cantidad > capacidadMaxima)
        {
            throw new InvalidOperationException("No se puede agregar más lugares de los que permite el límite (80 lugares).");
        }

        lugaresDisponibles += cantidad;
    }

    public void EliminarLugares(int cantidad)
    {
        if (cantidad < 0)
        {
            throw new ArgumentException("La cantidad de lugares a eliminar no puede ser negativa.");
        }

        if (lugaresDisponibles - cantidad < 0)
        {
            throw new InvalidOperationException("No se puede eliminar más lugares de los disponibles actualmente.");
        }

        lugaresDisponibles -= cantidad;
    }
}