using Android.App;
using Android.OS;
using Android.Views;
using Com.Gigamole.Infinitecycleviewpager;
using System.Collections.Generic;

namespace CABASUS.Fragments
{
    class fragment_caballos_actividades : Fragment
    {
        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View Vista = inflater.Inflate(Resource.Layout.layout_caballos_actividades, container, false);

            List<int> imagenes = new List<int>();
            imagenes.Add(Resource.Drawable.imagen1);
            imagenes.Add(Resource.Drawable.imagen2);
            imagenes.Add(Resource.Drawable.imagen3);

            var HICVP= Vista.FindViewById<HorizontalInfiniteCycleViewPager>(Resource.Id.selector_caballos_actividades);
            //Adaptadores.Adaptador_Selector_Caballos adaptador = new Adaptadores.Adaptador_Selector_Caballos(imagenes, Context);
            //HICVP.Adapter = adaptador;
            return Vista;
        }
    }
}