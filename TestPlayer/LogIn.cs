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
    ///The LogIn recording.
    /// </summary>
    [TestModule("54374d0b-4845-4845-97cf-b740f2549398", ModuleType.Recording, 1)]
    public partial class LogIn : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TestPlayerRepository repository.
        /// </summary>
        public static TestPlayerRepository repo = TestPlayerRepository.Instance;

        static LogIn instance = new LogIn();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LogIn()
        {
            UserPassword = "123456";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LogIn Instance
        {
            get { return instance; }
        }

#region Variables

        string _UserPassword;

        /// <summary>
        /// Gets or sets the value of variable UserPassword.
        /// </summary>
        [TestVariable("ae624899-f0fe-4014-9d27-1aeb0f156800")]
        public string UserPassword
        {
            get { return _UserPassword; }
            set { _UserPassword = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MotDePasse.Password' at 32;9.", repo.MotDePasse.PasswordInfo, new RecordItemIndex(0));
            repo.MotDePasse.Password.Click("32;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$UserPassword' with focus on 'MotDePasse.Password'.", repo.MotDePasse.PasswordInfo, new RecordItemIndex(1));
            repo.MotDePasse.Password.PressKeys(UserPassword);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MotDePasse.ButtonOK' at 21;7.", repo.MotDePasse.ButtonOKInfo, new RecordItemIndex(2));
            repo.MotDePasse.ButtonOK.Click("21;7");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
