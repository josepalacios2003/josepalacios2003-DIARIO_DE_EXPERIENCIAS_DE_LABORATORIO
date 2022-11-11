using System;
class Program
{
    public static double calcularPrecio(string tipoHelado, int topping)
    {
        double precio = 0;
        if (tipoHelado == "chocolate" || tipoHelado == "vainilla" || tipoHelado == "fresa")
        {
            precio = 5;
        }
        else if (tipoHelado == "napolitano" || tipoHelado == "pistacho")
        {
            precio = 7;
        }
        switch (topping)
        {
            case 1: // cobertura de chocolate
                precio = precio + 1;
                break;
            case 2: // cobertura de chocolate con mania
                precio = precio + 2;
                break;
            case 3: // cobertura de chocolate con anicillos
                precio = precio + 1;
                break;
        }
        return precio;
    }
    static void Main()
    {

    }
}
