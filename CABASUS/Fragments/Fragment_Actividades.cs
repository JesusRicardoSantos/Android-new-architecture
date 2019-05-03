using Android.App;
using Android.OS;
using Android.Views;

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
            return Vista;
        }
    }
}