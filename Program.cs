using System;
using System.Linq;
using linq.Data;
using Microsoft.EntityFrameworkCore;






// Classe principale du programme
public class Program
{
    public static void Main()
    {
        using (var context = new AnimalDbContext())
        {
            
            var cougarsBlancs = context.Animals
                .Where(a => a.Species.Name == "Cougars blancs")
                .Count();
            Console.WriteLine($"Cougars blancs : {cougarsBlancs}");

            var tigresBlancs = context.Animals
                .Where(a => a.Species.Name == "Tigres blancs")
                .Count();
            Console.WriteLine($"Tigres blancs : {tigresBlancs}");

            var tortuesAlbinos = context.Animals
                .Where(a => a.Species.Name == "Tortues albinos")
                .Count();
            Console.WriteLine($"Tortues albinos : {tortuesAlbinos}");
        }
    }
}
