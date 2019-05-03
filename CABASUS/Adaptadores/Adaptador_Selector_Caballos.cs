using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace CABASUS.Adaptadores
{
    class Adaptador_Selector_Caballos : PagerAdapter
    {
        List<int> caballos;
        Context context;
        LayoutInflater layoutinflater;

        public Adaptador_Selector_Caballos(List<int> _caballos, Context _context)
        {
            caballos = _caballos;
            context = _context;
            layoutinflater = LayoutInflater.From(_context);
        }

        public override int Count => caballos.Count;

        public override bool IsViewFromObject(View view, Java.Lang.Object @object)
        {
            return view.Equals(@object);
        }

        public override void DestroyItem(ViewGroup container, int position, Java.Lang.Object @object)
        {
            container.RemoveView((View)@object);
        }

        public override Java.Lang.Object InstantiateItem(ViewGroup container, int position)
        {
            View view = layoutinflater.Inflate(Resource.Layout.ItemCaballoActividades, container, false);

            var imgCaballo = view.FindViewById<ImageView>(Resource.Id.imgCaballo);
            var txtNombre = view.FindViewById<TextView>(Resource.Id.txtNombre);

            imgCaballo.SetImageResource(caballos[position]);
            txtNombre.Text = "Caballo " + position;
            container.AddView(view);
            return view;

        }
    }
}