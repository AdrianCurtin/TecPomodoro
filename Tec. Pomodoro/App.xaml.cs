﻿using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.System.Profile;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Tec.Pomodoro
{
    /// <summary>
    ///Fornece o comportamento específico do aplicativo para complementar a classe Application padrão.
    /// </summary>
    sealed partial class App : Application
    {
        public static readonly string ISFIRSTTIME = "IsFirstTime";

        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;



        }


        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
#if DEBUG
            if (System.Diagnostics.Debugger.IsAttached)
            {
                this.DebugSettings.EnableFrameRateCounter = true;
            }
#endif
            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    if (AnalyticsInfo.VersionInfo.DeviceFamily == "Windows.Mobile")
                        ApplicationView.GetForCurrentView().TryEnterFullScreenMode();


                    ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

                    try
                    {
                        bool isFirstTime = (bool)localSettings.Values[ISFIRSTTIME];

                        if (isFirstTime)
                            rootFrame.Navigate(typeof(Help));
                        else
                            rootFrame.Navigate(typeof(Vision.PageSilencePhone));

                    }
                    catch (NullReferenceException)
                    {
                        ApplicationData.Current.LocalSettings.Values[ISFIRSTTIME] = true;
                        rootFrame.Navigate(typeof(Help));
                    }

                }
                // Ensure the current window is active
                Window.Current.Activate();
            }
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }

    }
}

