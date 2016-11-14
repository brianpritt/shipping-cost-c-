using System;
using Nancy;
using ParcelPage.Objects;

namespace ParcelPage
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/parcel-estimate"] = _ => {

        if(Request.Query["height"]=="" || Request.Query["weight"] == "" || Request.Query["width"] == "")
        {
          return View["error.cshtml"];
        }else
        {
          Parcel myParcel = new Parcel(Request.Query["height"], Request.Query["weight"], Request.Query["width"]);
          myParcel.SetVolume();
          myParcel.SetCostToShip();

          return View["package-information.cshtml", myParcel];
        }
        return View["error.cshtml"] ;


      };
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
    }
  }
}
