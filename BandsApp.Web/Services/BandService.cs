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
                   VideoUrl = "https://www.youtube.com/embed/pcx-Qzjmm5A?si=npfoqrg3-ItpcX_I",
                   Albums = ["This is it!", "Boredom Boredom Go Away!", "It's A Sin", "Don't Don't Don't", "Pep Talk", "Betsy's Revenge",
                    "Money Money Money", "Punk Rock Harbour", "People's Republic Of The Baboon Show Formerly Known As Sweden", "Damnation", "Havanna Sessions",
                    "The World Is Bigger Than You", "Best of 2.0", "Radio Rebelde", "I never say goodnight", "Odball", "God Bless You All"]},
           new Band {
               Id = 2,
               Name = "Therapie TAXI",
               Description ="Thérapie TAXI var ett franskt pop-rock/électro-band aktivt mellan 2016 och 2021, känt för sina provokativa texter och energi.",
               ImagePath = "/Images/therapieTaxi.jpeg",
               VideoUrl="https://www.youtube.com/embed/CpTLFchI8Zk?si=fUiEf-Lk13u6zlqI",
            Albums = ["Hit Sale", "Cadavre exquis"]},
           new Band {
               Id = 3,
               Name = "Alanis Morissette",
               Description = "A Canadian musician known for her confessional lyrics and a layered rock-influenced sound.",
               ImagePath = "/Images/AlanisMorissette.jpg",
               VideoUrl = "https://www.youtube.com/embed/Jne9t8sHpUc?si=mUFKVAytIB8yT0Z0",
               Albums = ["Alanis", "Now Is The Time", "Jagged Little Pill", "Supposed Former Infatuation Junkie", "Under Rug Swept", "So Called Chaos", "Flavors Of Entaglement", "Havoc And Bright Lights", "Such Pretty Forks in the Road"]
           }
           ];
     

        public Band? GetById(int id) => bands
            .SingleOrDefault(b => b.Id == id);

        public Band[] GetAllBands() => bands
            .OrderBy(o => o.Name)
            .ToArray();

    }
}
