using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Android.Content;
using Android.Support.V7.Widget;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;

namespace RecyclerVIewSample.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IEnumerable<Assembly> AndroidViewAssemblies => new List<Assembly>(base.AndroidViewAssemblies.ToList())
        {
            typeof(MvvmCross.Droid.Support.V7.RecyclerView.MvxRecyclerView).Assembly,
            typeof(CardView).Assembly
        };

        protected override IMvxApplication CreateApp()
        {
            return new RecyclerVIewSample.Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}
