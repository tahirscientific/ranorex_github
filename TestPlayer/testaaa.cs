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
    ///The testaaa recording.
    /// </summary>
    [TestModule("82df426d-a506-42f4-b833-b494f8969be7", ModuleType.Recording, 1)]
    public partial class testaaa : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TestPlayerRepository repository.
        /// </summary>
        public static TestPlayerRepository repo = TestPlayerRepository.Instance;

        static testaaa instance = new testaaa();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public testaaa()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static testaaa Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1' at 26;41.", repo.Form1.SelfInfo, new RecordItemIndex(0));
            repo.Form1.Self.Click("26;41");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'Player.Gestion' at 133;12.", repo.Player.GestionInfo, new RecordItemIndex(1));
            repo.Player.Gestion.MoveTo("133;12");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'Player.Gestion' at 172;11.", repo.Player.GestionInfo, new RecordItemIndex(2));
            repo.Player.Gestion.MoveTo("172;11");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Player.Joueur' at 60;10.", repo.Player.JoueurInfo, new RecordItemIndex(3));
            repo.Player.Joueur.Click("60;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'RANO{LShiftKey down}000{LShiftKey up}{Tab}REX{LShiftKey down}000{LShiftKey up}' with focus on 'RechercheClient23101456'.", repo.RechercheClient23101456.SelfInfo, new RecordItemIndex(4));
            repo.RechercheClient23101456.Self.EnsureVisible();
            Keyboard.Press("RANO{LShiftKey down}000{LShiftKey up}{Tab}REX{LShiftKey down}000{LShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RechercheClient23101456.ButtonOK' at 28;14.", repo.RechercheClient23101456.ButtonOKInfo, new RecordItemIndex(5));
            repo.RechercheClient23101456.ButtonOK.Click("28;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.ImBackSplash' at 1317;441.", repo.Form1.ImBackSplashInfo, new RecordItemIndex(6));
            repo.Form1.ImBackSplash.Click("1317;441");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'RANO{LShiftKey down}103{LShiftKey up}{Tab down}{LShiftKey down}REX103{LShiftKey up}{Tab up}' with focus on 'Form1'.", repo.Form1.SelfInfo, new RecordItemIndex(7));
            repo.Form1.Self.EnsureVisible();
            Keyboard.Press("RANO{LShiftKey down}103{LShiftKey up}{Tab down}{LShiftKey down}REX103{LShiftKey up}{Tab up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.ImBackSplash' at 931;519.", repo.Form1.ImBackSplashInfo, new RecordItemIndex(8));
            repo.Form1.ImBackSplash.Click("931;519");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.ImBackSplash' at 987;510.", repo.Form1.ImBackSplashInfo, new RecordItemIndex(9));
            repo.Form1.ImBackSplash.Click("987;510");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}2000{LShiftKey up}' with focus on 'Form1'.", repo.Form1.SelfInfo, new RecordItemIndex(10));
            repo.Form1.Self.EnsureVisible();
            Keyboard.Press("{LShiftKey down}2000{LShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.ImBackSplash' at 1082;515.", repo.Form1.ImBackSplashInfo, new RecordItemIndex(11));
            repo.Form1.ImBackSplash.Click("1082;515");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'PARIS' with focus on 'Form1'.", repo.Form1.SelfInfo, new RecordItemIndex(12));
            repo.Form1.Self.EnsureVisible();
            Keyboard.Press("PARIS");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.ImBackSplash' at 1239;515.", repo.Form1.ImBackSplashInfo, new RecordItemIndex(13));
            repo.Form1.ImBackSplash.Click("1239;515");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fr{Return}' with focus on 'Form1'.", repo.Form1.SelfInfo, new RecordItemIndex(14));
            repo.Form1.Self.EnsureVisible();
            Keyboard.Press("fr{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.ImBackSplash' at 1090;586.", repo.Form1.ImBackSplashInfo, new RecordItemIndex(15));
            repo.Form1.ImBackSplash.Click("1090;586");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}3{Space down}{LShiftKey up}{Space up}RUE DU TEST' with focus on 'Form1'.", repo.Form1.SelfInfo, new RecordItemIndex(16));
            repo.Form1.Self.EnsureVisible();
            Keyboard.Press("{LShiftKey down}3{Space down}{LShiftKey up}{Space up}RUE DU TEST");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.ImBackSplash' at 1343;443.", repo.Form1.ImBackSplashInfo, new RecordItemIndex(17));
            repo.Form1.ImBackSplash.Click("1343;443");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Confirmer.ButtonNon' at 14;7.", repo.Confirmer.ButtonNonInfo, new RecordItemIndex(18));
            repo.Confirmer.ButtonNon.Click("14;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GestionDesComptesJoueurs23101456.ButtonFermer' at 6;21.", repo.GestionDesComptesJoueurs23101456.ButtonFermerInfo, new RecordItemIndex(19));
            repo.GestionDesComptesJoueurs23101456.ButtonFermer.Click("6;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.ImBackSplash' at 2528;1236.", repo.Form1.ImBackSplashInfo, new RecordItemIndex(20));
            repo.Form1.ImBackSplash.Click("2528;1236");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='10662362') on item 'VIPlayers23101456.PlayerID'.", repo.VIPlayers23101456.PlayerIDInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.VIPlayers23101456.PlayerIDInfo, "Text", "10662362");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
