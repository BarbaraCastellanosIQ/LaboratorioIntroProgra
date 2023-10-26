using System;

class Circulo
{
    private double radio;
    private double perimetro;
    private double area;
    private double volumen;

    public Circulo(double radio)
    {
        this.radio = radio;
        CalcularGeometria();
    }

    private void CalcularGeometria()
    {
        perimetro = 2 * radio * Math.PI;
        area = radio * radio * Math.PI;
        volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
    }

    public double Perimetro
    {
        get { return perimetro; }
    }

    public double Area
    {
        get { return area; }
    }

    public double Volumen
    {
        get { return volumen; }
    }
}

class TrianguloRectangulo
{
    private double catetoA;
    private double anguloOpuestoA;

    public TrianguloRectangulo(double catetoA, double anguloOpuestoA)
    {
        this.catetoA = catetoA;
        this.anguloOpuestoA = anguloOpuestoA;
    }

    public double ObtenerCatetoA()
    {
        return catetoA;
    }

    public double ObtenerCatetoB()
    {
        return catetoA / Math.Tan(anguloOpuestoA * (Math.PI / 180));
    }

    public double ObtenerHipotenusa()
    {
        return catetoA / Math.Sin(anguloOpuestoA * (Math.PI / 180));
    }

    public double ObtenerAnguloOpuestoA()
    {
        return anguloOpuestoA;
    }

    public double ObtenerAnguloOpuestoB()
    {
        return 90 - anguloOpuestoA;
    }

    public double ObtenerArea()
    {
        return 0.5 * catetoA * ObtenerCatetoB();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Problema 1: Área y circunferencia de un círculo");

        Console.WriteLine("Ingrese el radio del círculo (en metros): ");
        double radioCirculo = double.Parse(Console.ReadLine());

        Circulo circulo = new Circulo(radioCirculo);
        Console.WriteLine("Radio del círculo: " + circulo.Perimetro.ToString("F3") + " metros");
        Console.WriteLine("Perímetro del círculo: " + circulo.Area.ToString("F3") + " metros");
        Console.WriteLine("Área del círculo: " + circulo.Volumen.ToString("F3") + " metros cúbicos");

        Console.WriteLine("\nProblema 2: Triángulo Rectángulo");

        Console.WriteLine("Ingrese la longitud de un cateto del triángulo (en metros): ");
        double catetoA = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el ángulo opuesto al cateto A (en grados): ");
        double anguloOpuestoA = double.Parse(Console.ReadLine());

        TrianguloRectangulo triangulo = new TrianguloRectangulo(catetoA, anguloOpuestoA);
        Console.WriteLine("Cateto A: " + triangulo.ObtenerCatetoA().ToString("F3") + " metros");
        Console.WriteLine("Cateto B: " + triangulo.ObtenerCatetoB().ToString("F3") + " metros");
        Console.WriteLine("Hipotenusa: " + triangulo.ObtenerHipotenusa().ToString("F3") + " metros");
        Console.WriteLine("Ángulo Opuesto a A: " + triangulo.ObtenerAnguloOpuestoA().ToString("F3") + " grados");
        Console.WriteLine("Ángulo Opuesto a B: " + triangulo.ObtenerAnguloOpuestoB().ToString("F3") + " grados");
        Console.WriteLine("Área: " + triangulo.ObtenerArea().ToString("F3") + " metros cuadrados");
    }
}

