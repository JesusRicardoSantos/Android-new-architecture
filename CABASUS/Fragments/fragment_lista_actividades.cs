using Android.App;
using Android.OS;
using Android.Views;

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
            return Vista;
        }
    }
}