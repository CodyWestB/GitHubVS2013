using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using www.CodyBerndt.com.Models.About;

namespace www.CodyBerndt.com.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult About()
        {
            var model = new AboutModels() {};
            model.HaloImages.Add("Art_of_Scoping_Halo_Landscape.jpg");
            model.HaloImages.Add("Concept_Art_Forerunner_AI.jpg");
            model.HaloImages.Add("Concept_Art_Forerunner_Towers.jpg");
            model.HaloImages.Add("Concept_Art_Sangheili.jpg");
            model.HaloImages.Add("Coventant_Ship_Corridor.jpg");
            model.HaloImages.Add("Forerunner_City.jpg");
            model.HaloImages.Add("Forerunner_Installation_Tower.jpg");
            model.HaloImages.Add("Halo_Broken_Platform.jpg");
            model.HaloImages.Add("Halo_Four_Moutainous_Desert.jpg");
            model.HaloImages.Add("Halo_Four_Planet_Asteriod_Belt.jpg");
            model.HaloImages.Add("Halo_Four_Requim_Lush_Forest.jpg");
            model.HaloImages.Add("Halo_Four_UNSC_Pelican_Docking_Bay.jpg");
            model.HaloImages.Add("Halo_Installation_Side_View.jpg");
            model.HaloImages.Add("Halo_One_Covenant_Ship_Ambush.jpg");
            model.HaloImages.Add("Halo_One_Installation_Tether.jpg");
            model.HaloImages.Add("Halo_One_Internal_Containment_Area.jpg");
            model.HaloImages.Add("Halo_One_Leaking_Coolant.jpg");
            model.HaloImages.Add("Halo_One_Rainy_Jungle.jpg");
            model.HaloImages.Add("Halo_Stormy_Landscape.jpg");
            model.HaloImages.Add("Halo_Three_Ark_Foggy_Swamp.jpg");
            model.HaloImages.Add("Halo_Three_Cortana_Flood.jpg");
            model.HaloImages.Add("Halo_Three_Covenant_UNSC_Ship_Battle.jpg");
            model.HaloImages.Add("Halo_Three_Earth_Portal_Key_Ship.jpg");
            model.HaloImages.Add("Halo_Three_Master_Chief_Desert_Overview.jpg");
            model.HaloImages.Add("Halo_Three_UNSC_Cryopods.jpg");
            model.HaloImages.Add("Halo_Two_African_City_Overview.jpg");
            model.HaloImages.Add("Halo_Two_Brute_Elite_Ship_Battle.jpg");
            model.HaloImages.Add("Halo_Two_Earth_MAC_Installation.jpg");
            model.HaloImages.Add("Halo_Two_Forerunner_Key_Ship.jpg");
            model.HaloImages.Add("Halo_Two_Gravemind.jpg");
            model.HaloImages.Add("Halo_Two_Gravemind_Master_Chief.jpg");
            model.HaloImages.Add("Halo_Two_Green_Scenery.jpg");
            model.HaloImages.Add("Halo_Two_Planetary_Sandstorm.jpg");
            model.HaloImages.Add("Halo_Two_Prophit_Speech.jpg");
            model.HaloImages.Add("Halo_Two_Scarab.jpg");
            model.HaloImages.Add("Halo_Two_Snowy_Walkways.jpg");
            model.HaloImages.Add("Halo_Two_Zanzibar_Hotel.jpg");
            model.HaloImages.Add("Master_Chief_4_Variable_Lighting.jpg");
            model.HaloImages.Add("Master_Chief_Military_Salute.jpg");
            model.HaloImages.Add("Remember_Reach_Spartan.jpg");
            model.HaloImages.Add("Rocky_Beach.jpg");
            model.HaloImages.Add("Ship_Wreckage.jpg");
            model.HaloImages.Add("Underside_of_Covenant_Crusiser.jpg");
            model.HaloImages.Add("UNSC_Pelican.jpg");
            model.HaloImages.Add("UNSC_Ship_Corridor.jpg");
            model.HaloImages.Add("UNSC_Ship_Human_Grunt_Battle.jpg");

            return View(model);
        }
    }
}
