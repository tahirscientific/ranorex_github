﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace TestPlayer
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CreateNewPlayerWithoutAccount recording.
    /// </summary>
    [TestModule("ad81877b-7879-4ed1-87a8-a54d51e44abf", ModuleType.Recording, 1)]
    public partial class CreateNewPlayerWithoutAccount : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TestPlayerRepository repository.
        /// </summary>
        public static TestPlayerRepository repo = TestPlayerRepository.Instance;

        static CreateNewPlayerWithoutAccount instance = new CreateNewPlayerWithoutAccount();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateNewPlayerWithoutAccount()
        {
            LastName = "RANO000";
            FirstName = "REX000";
            BirthPlace = "AAAA";
            Address = "0 rue du test";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateNewPlayerWithoutAccount Instance
        {
            get { return instance; }
        }

#region Variables

        string _LastName;

        /// <summary>
        /// Gets or sets the value of variable LastName.
        /// </summary>
        [TestVariable("06f0d41d-401f-4bda-92fc-030ac711ae26")]
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        string _FirstName;

        /// <summary>
        /// Gets or sets the value of variable FirstName.
        /// </summary>
        [TestVariable("0b7e047f-4bef-46c5-bf9f-c1df38b78672")]
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        string _BirthPlace;

        /// <summary>
        /// Gets or sets the value of variable BirthPlace.
        /// </summary>
        [TestVariable("f8f00928-7f2e-4e79-9f04-f7368c85f9f6")]
        public string BirthPlace
        {
            get { return _BirthPlace; }
            set { _BirthPlace = value; }
        }

        string _Address;

        /// <summary>
        /// Gets or sets the value of variable Address.
        /// </summary>
        [TestVariable("1326e0d9-197b-419e-ac2d-de79a745a2c3")]
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VIPlayers23101456.SomeButton' at Center.", repo.VIPlayers23101456.SomeButtonInfo, new RecordItemIndex(0));
            repo.VIPlayers23101456.SomeButton.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.ImBackSplash' at 1063;479.", repo.Form1.ImBackSplashInfo, new RecordItemIndex(1));
            //repo.Form1.ImBackSplash.Click("1063;479");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LastName' with focus on 'Form1'.", repo.Form1.SelfInfo, new RecordItemIndex(2));
            repo.Form1.Self.EnsureVisible();
            Keyboard.Press(LastName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.ImBackSplash' at 1223;478.", repo.Form1.ImBackSplashInfo, new RecordItemIndex(3));
            repo.Form1.ImBackSplash.Click("1223;478");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FirstName' with focus on 'Form1'.", repo.Form1.SelfInfo, new RecordItemIndex(4));
            repo.Form1.Self.EnsureVisible();
            Keyboard.Press(FirstName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.ImBackSplash' at 933;517.", repo.Form1.ImBackSplashInfo, new RecordItemIndex(5));
            repo.Form1.ImBackSplash.Click("933;517");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.ImBackSplash' at 987;511.", repo.Form1.ImBackSplashInfo, new RecordItemIndex(6));
            repo.Form1.ImBackSplash.Click("987;511");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '2000' with focus on 'Form1'.", repo.Form1.SelfInfo, new RecordItemIndex(7));
            repo.Form1.Self.EnsureVisible();
            Keyboard.Press("2000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.ImBackSplash' at 1053;515.", repo.Form1.ImBackSplashInfo, new RecordItemIndex(8));
            repo.Form1.ImBackSplash.Click("1053;515");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '' with focus on 'Form1'.", repo.Form1.SelfInfo, new RecordItemIndex(9));
            repo.Form1.Self.EnsureVisible();
            Keyboard.Press("");
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$BirthPlace' with focus on 'Form1'.", repo.Form1.SelfInfo, new RecordItemIndex(10));
            repo.Form1.Self.EnsureVisible();
            Keyboard.Press(BirthPlace);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.ImBackSplash' at 1252;512.", repo.Form1.ImBackSplashInfo, new RecordItemIndex(11));
            repo.Form1.ImBackSplash.Click("1252;512");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fr{Return}' with focus on 'Form1'.", repo.Form1.SelfInfo, new RecordItemIndex(12));
            repo.Form1.Self.EnsureVisible();
            Keyboard.Press("fr{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.ImBackSplash' at 1067;581.", repo.Form1.ImBackSplashInfo, new RecordItemIndex(13));
            repo.Form1.ImBackSplash.Click("1067;581");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Address' with focus on 'Form1'.", repo.Form1.SelfInfo, new RecordItemIndex(14));
            repo.Form1.Self.EnsureVisible();
            Keyboard.Press(Address);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.ImBackSplash' at 1339;441.", repo.Form1.ImBackSplashInfo, new RecordItemIndex(15));
            repo.Form1.ImBackSplash.Click("1339;441");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Confirmer.ButtonNon' at 34;7.", repo.Confirmer.ButtonNonInfo, new RecordItemIndex(16));
            repo.Confirmer.ButtonNon.Click("34;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GestionDesComptesJoueurs23101456.ButtonFermer' at 39;16.", repo.GestionDesComptesJoueurs23101456.ButtonFermerInfo, new RecordItemIndex(17));
            repo.GestionDesComptesJoueurs23101456.ButtonFermer.Click("39;16");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(18));
            //Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=22,Height=18}) on item 'VIPlayers23101456.SomeButton'.", repo.VIPlayers23101456.SomeButtonInfo, new RecordItemIndex(19));
            //Validate.CompareImage(repo.VIPlayers23101456.SomeButtonInfo, SomeButton_Screenshot1, SomeButton_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage SomeButton_Screenshot1
        { get { return repo.VIPlayers23101456.SomeButtonInfo.GetScreenshot1(new Rectangle(0, 0, 22, 18)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions SomeButton_Screenshot1_Options
        { get { return Imaging.FindOptions.Parse("1;None;0,0,22,18;True;10000000;0ms"); } }

#endregion
    }
#pragma warning restore 0436
}
