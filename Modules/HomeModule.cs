using Nancy;
using Parcels.Objects;

namespace Parcels
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/calculate"] = _ => {
        ParcelVariables myParcelVariables = new ParcelVariables();
        myParcelVariables.SetWidth(Request.Query["width"]);
        myParcelVariables.SetLength(Request.Query["length"]);
        myParcelVariables.SetHeight(Request.Query["height"]);
        myParcelVariables.SetWeight(Request.Query["weight"]);
        return View["index.cshtml", myParcelVariables];
      };
      Get["/favorite_photos"] = _ => View["favorite_photos.cshtml"];
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
  }
  }
}
