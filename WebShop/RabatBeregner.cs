namespace WebShop;

public class Rabatberegner
{
    public double GetPrisEfterRabat(int antalVarer, double stykPris)
    {
        double bruttoPris = antalVarer * stykPris;
        double resultPrice = bruttoPris;
        if (bruttoPris > 1000)
        {
            // Indkøb over 1000 kr. giver 3% rabat
            double rabat = bruttoPris * 0.03;
            resultPrice = resultPrice - rabat;
        }
        if (antalVarer > 10)
        {
            // Flere end 10 varer giver 2% rabat
            double rabat = bruttoPris * 0.02;
            resultPrice = resultPrice - rabat;
        }
 
        return resultPrice;
    }
}