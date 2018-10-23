﻿using GalaSoft.MvvmLight.Ioc;
using Foundation;
using UIKit;
using Microsoft.Practices.ServiceLocation;
using HockeyApp.iOS;

namespace XamarinNativeTemplate.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations

        public override UIWindow Window
        {
            get;
            set;
        }

        UINavigationController Navigation;

        //public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        //{
        //    // Override point for customization after application launch.
        //    // If not required for your application you can safely delete this method

        //    // UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, false);

        //    //ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

        //    //Window = new UIWindow(UIScreen.MainScreen.Bounds);

        //    //Navigation = new UINavigationController();
        //    //Navigation.PushViewController(new EmpViewController(this.Handle), true);
        //    //Window.RootViewController = Navigation;

        //    //Window.MakeKeyAndVisible();

        //    return true;
        //}
        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // Override point for customization after application launch.
            // If not required for your application you can safely delete this method

             //UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, false);

            Couchbase.Lite.Storage.SQLCipher.Plugin.Register();

            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            var hcManager = BITHockeyManager.SharedHockeyManager;

            hcManager.Configure("f03e1146e3a043ba8966147b8d9d8249");

            // TODO: comment this line, if you want to record user metrics
            hcManager.DisableMetricsManager = true;
            hcManager.StartManager();
            hcManager.Authenticator.AuthenticateInstallation();

         //   Settings.AppVersion = NSBundle.MainBundle.InfoDictionary[new NSString("CFBundleShortVersionString")].ToString();

            //Window = new UIWindow(UIScreen.MainScreen.Bounds);

            //Navigation = new UINavigationController();
            //Navigation.PushViewController(new MyTableViewController(), true);
            //Window.RootViewController = Navigation;

            //Window.MakeKeyAndVisible();
            return true;
        }

        public override void OnResignActivation(UIApplication application)
        {
            // Invoked when the application is about to move from active to inactive state.
            // This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
            // or when the user quits the application and it begins the transition to the background state.
            // Games should use this method to pause the game.
        }

        public override void DidEnterBackground(UIApplication application)
        {
            // Use this method to release shared resources, save user data, invalidate timers and store the application state.
            // If your application supports background exection this method is called instead of WillTerminate when the user quits.
        }

        public override void WillEnterForeground(UIApplication application)
        {
            // Called as part of the transiton from background to active state.
            // Here you can undo many of the changes made on entering the background.
        }

        public override void OnActivated(UIApplication application)
        {
            // Restart any tasks that were paused (or not yet started) while the application was inactive. 
            // If the application was previously in the background, optionally refresh the user interface.
        }

        public override void WillTerminate(UIApplication application)
        {
            // Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
        }

        static ViewModelLocator locator;
        public static ViewModelLocator Locator
        {
            get
            {
                if (locator == null)
                {
                    locator = new ViewModelLocator();
                }

                return locator;
            }
        }
    }
}