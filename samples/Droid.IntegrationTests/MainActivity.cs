﻿using Android.App;
using Android.OS;
using Xunit.Runners.UI;
using Xunit.Sdk;

namespace Droid.IntegrationTests
{
    [Activity(Label = "Droid.IntegrationTests", MainLauncher = true)]
    public class MainActivity : RunnerActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            AddExecutionAssembly(typeof(ExtensibilityPointFactory).Assembly);

            // tests can be inside the main assembly
            AddTestAssembly(typeof(MainActivity).Assembly);

            // Once you called base.OnCreate(), you cannot add more assemblies.
            base.OnCreate(bundle);
        }
    }
}
