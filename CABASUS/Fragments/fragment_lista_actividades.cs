using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;

namespace CABASUS.Fragments
{
    class fragment_lista_actividades : Fragment
    {
        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View Vista = inflater.Inflate(Resource.Layout.layout_lista_actividades, container, false);

            //agregar fecha al primero eliminar esto cuando la logica sea la chida
            var primero = true;
            TextView txtFecha = new TextView(Context);
            var LayoutParameters = new LinearLayout.LayoutParams(-1, ViewGroup.LayoutParams.WrapContent);
            LayoutParameters.SetMargins(0, 20, 0, 20);
            txtFecha.LayoutParameters = LayoutParameters;
            txtFecha.Text = DateTime.Now.ToString("dd MMMM yyyy");
            txtFecha.TextAlignment = TextAlignment.Center;
            txtFecha.SetTextColor(Color.Black);
            txtFecha.TextSize = 22;
            txtFecha.SetTypeface(null, TypefaceStyle.Italic);

            Vista.FindViewById<LinearLayout>(Resource.Id.listaActividades).AddView(txtFecha);

            for (int i = 0; i < 20; i++)
            {
                //vista para colocar la fecha
                Random r = new Random();

                if (r.Next(0, 10) >= 5 && !primero)
                {
                    txtFecha = new TextView(Context);
                    LayoutParameters = new LinearLayout.LayoutParams(-1, ViewGroup.LayoutParams.WrapContent);
                    LayoutParameters.SetMargins(0, 20, 0, 20);
                    txtFecha.LayoutParameters = LayoutParameters;
                    txtFecha.Text = DateTime.Now.AddDays(i).ToString("dd MMMM yyyy");
                    txtFecha.TextAlignment = TextAlignment.Center;
                    txtFecha.SetTextColor(Color.Black);
                    txtFecha.TextSize = 22;
                    txtFecha.SetTypeface(null, TypefaceStyle.Italic);

                    Vista.FindViewById<LinearLayout>(Resource.Id.listaActividades).AddView(txtFecha);
                }

                //vista con datos para cada actividad
                var layout = inflater.Inflate(Resource.Layout.ItemActividad, container, false);
                Vista.FindViewById<LinearLayout>(Resource.Id.listaActividades).AddView(layout);

                primero = false;
            }
            return Vista;
        }
    }
}