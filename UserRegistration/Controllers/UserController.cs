using System.Web.Mvc;
using UserManagement.BLL;
using UserManagement.DAL;
using UserManagement.DAL.Model;

public class UserController : Controller
{
    private readonly UserManager userManager;

    public UserController()
    {
        var dataAccess = new UserDataAccess();
        userManager = new UserManager(dataAccess);
    }
    // GET: Home
    public ActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public ActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Register(UserModel model)
    {
        if (ModelState.IsValid && userManager.RegisterUser(model))
        {
            return RedirectToAction("DisplayUserDetails", model);
        }
        return View(model);
    }

    public ActionResult DisplayUserDetails(UserModel model)
    {
        return View(model);
    }


}
