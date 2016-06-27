using Nancy;
using Triangle.Objects;

namespace TriangleCsharp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> {
        TriangleVariables Triangle = new TriangleVariables();

        Triangle.Set_side1(Request.Query["firstSide"]);
        Triangle.Set_side2(Request.Query["secondSide"]);
        Triangle.Set_side3(Request.Query["thirdSide"]);
        return View["index.cshtml", Triangle];
      };
      Get["/form"] =_=> {
        return View["form.cshtml"];
      };

    }
  }
}
