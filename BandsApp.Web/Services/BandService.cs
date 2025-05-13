using BandsApp.Web.Models;
namespace BandsApp.Web.Services
{
    public class BandService
    {
        List<Band> bands = [

           new Band { Id = 1, Name = "The Baboon Show", Description ="The Baboon Show är ett svenskt punkband som började som ett renodlat liveband 2003."},
           new Band { Id = 2, Name = "Therapie TAXI", Description ="Thérapie TAXI var ett franskt pop-rock/électro-band aktivt mellan 2016 och 2021, känt för sina provokativa texter och energi."},
           new Band { Id = 3, Name = "Alanis Morrissette", Description ="A Canadian musician known for her confessional lyrics and a layered rock-influenced sound."}
         ];

        public Band? GetById(int id) => bands
            .SingleOrDefault(b => b.Id == id);

        public Band[] GetAllBands() => bands
            .OrderBy(o => o.Name)
            .ToArray();

        //test
        //test2
        //test3

    }
}
