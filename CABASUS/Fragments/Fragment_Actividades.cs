using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CABASUS.Fragments
{
    class Fragment_Actividades : Fragment
    {
        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View Vista = inflater.Inflate(Resource.Layout.layout_actividades, container, false);

            //FragmentTransaction transaccion;
            //fragment_caballos_actividades fragment_caballos_actividades = new fragment_caballos_actividades();
            //fragment_lista_actividades fragment_lista_actividades = new fragment_lista_actividades();

            //transaccion = FragmentManager.BeginTransaction();
            //transaccion.Add(Resource.Id.FrameContent, fragment_caballos_actividades, "fragment_caballos_actividades");
            //transaccion.Show(fragment_caballos_actividades);
            //transaccion.Commit();

            //transaccion = FragmentManager.BeginTransaction();
            //transaccion.Add(Resource.Id.FrameContent, fragment_lista_actividades, "fragment_lista_actividades");
            //transaccion.Show(fragment_lista_actividades);
            //transaccion.Commit();
                        
            return Vista;
        }
    }
}