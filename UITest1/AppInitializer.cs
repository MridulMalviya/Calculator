using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{
                //return ConfigureApp.Android.StartApp();
                return ConfigureApp
                   .Android
                   .EnableLocalScreenshots()
                   .ApkFile(@"C:\Program Files (x86)\Android\android-sdk\build-tools\27.0.3\com.companyname.Calculator.apk")
                   .StartApp();
            }

			return ConfigureApp.iOS.StartApp();
		}
	}
}