using BandsApp.Web.Models;
namespace BandsApp.Web.Services
{
    public class BandService
    {
        List<Band> bands = [

           new Band { 
                   Id = 1,
                   Name = "The Baboon Show", 
                   Description ="The Baboon Show är ett svenskt punkband som började som ett renodlat liveband 2003.", 
                   ImagePath = "/Images/BaboonShow.jpg",
                   VideoUrl = "https://www.youtube.com/embed/pcx-Qzjmm5A?si=npfoqrg3-ItpcX_I"},
           new Band { 
               Id = 2, 
               Name = "Therapie TAXI", 
               Description ="Thérapie TAXI var ett franskt pop-rock/électro-band aktivt mellan 2016 och 2021, känt för sina provokativa texter och energi.", 
               ImagePath = "/Images/therapieTaxi.jpeg", 
               VideoUrl="https://www.youtube.com/embed/CpTLFchI8Zk?si=fUiEf-Lk13u6zlqI" },
           new Band { 
               Id = 3, 
               Name = "Alanis Morrissette", 
               Description ="A Canadian musician known for her confessional lyrics and a layered rock-influenced sound.", 
               ImagePath = "/Images/AlanisMorissette.jpg",
               VideoUrl = "https://www.youtube.com/embed/Jne9t8sHpUc?si=mUFKVAytIB8yT0Z0"}
         ];

        public Band? GetById(int id) => bands
            .SingleOrDefault(b => b.Id == id);

        public Band[] GetAllBands() => bands
            .OrderBy(o => o.Name)
            .ToArray();

    }
}
