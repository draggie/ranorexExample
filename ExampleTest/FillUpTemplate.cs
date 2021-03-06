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

namespace ExampleTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FillUpTemplate recording.
    /// </summary>
    [TestModule("8a263235-8f85-4893-a973-30035f5a4d3f", ModuleType.Recording, 1)]
    public partial class FillUpTemplate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ExampleTestRepository repository.
        /// </summary>
        public static ExampleTestRepository repo = ExampleTestRepository.Instance;

        static FillUpTemplate instance = new FillUpTemplate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FillUpTemplate()
        {
            email = "";
            name = "";
            surname = "";
            country = "";
            city = "";
            postalCode = "";
            address = "";
            content = "";
            testNumber = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FillUpTemplate Instance
        {
            get { return instance; }
        }

#region Variables

        string _email;

        /// <summary>
        /// Gets or sets the value of variable email.
        /// </summary>
        [TestVariable("e3ae6a08-4ba2-4d30-8419-7cf2718dfc44")]
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        string _name;

        /// <summary>
        /// Gets or sets the value of variable name.
        /// </summary>
        [TestVariable("7da71767-b732-4909-89f7-519458f8ab57")]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        string _surname;

        /// <summary>
        /// Gets or sets the value of variable surname.
        /// </summary>
        [TestVariable("6aa5eac3-ef3b-4ee8-966e-1e56a074fecb")]
        public string surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        string _country;

        /// <summary>
        /// Gets or sets the value of variable country.
        /// </summary>
        [TestVariable("47c21fca-e5f7-4672-925d-bf25f3f3e0d3")]
        public string country
        {
            get { return _country; }
            set { _country = value; }
        }

        string _city;

        /// <summary>
        /// Gets or sets the value of variable city.
        /// </summary>
        [TestVariable("60314ac4-9209-41e6-835d-c2aede3b4855")]
        public string city
        {
            get { return _city; }
            set { _city = value; }
        }

        string _postalCode;

        /// <summary>
        /// Gets or sets the value of variable postalCode.
        /// </summary>
        [TestVariable("0986aabd-6808-4743-8a18-fb7bb84fac75")]
        public string postalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }

        string _address;

        /// <summary>
        /// Gets or sets the value of variable address.
        /// </summary>
        [TestVariable("9538c6a3-5c76-4e71-be3e-83fc1ad5cd27")]
        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        string _content;

        /// <summary>
        /// Gets or sets the value of variable content.
        /// </summary>
        [TestVariable("08b88b1f-5ac0-4874-b7c8-90498f5a5755")]
        public string content
        {
            get { return _content; }
            set { _content = value; }
        }

        string _testNumber;

        /// <summary>
        /// Gets or sets the value of variable testNumber.
        /// </summary>
        [TestVariable("8d8581ee-92b6-4abf-b793-4032bb70c339")]
        public string testNumber
        {
            get { return _testNumber; }
            set { _testNumber = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking WaitForDocumentLoaded('30000ms') on item 'OficjalnaStronaPrezydentaRzeczypospol'.", repo.OficjalnaStronaPrezydentaRzeczypospol.SelfInfo, new RecordItemIndex(0));
            repo.OficjalnaStronaPrezydentaRzeczypospol.Self.WaitForDocumentLoaded(ValueConverter.ArgumentFromString<Ranorex.Duration>("timeout", "30000ms"));
            Delay.Milliseconds(0);
            
            // Validation
            Report.Log(ReportLevel.Info, "Section", "Validation", new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='') on item 'OficjalnaStronaPrezydentaRzeczypospol.Email'.", repo.OficjalnaStronaPrezydentaRzeczypospol.EmailInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.OficjalnaStronaPrezydentaRzeczypospol.EmailInfo, "Value", "");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='') on item 'OficjalnaStronaPrezydentaRzeczypospol.Imie'.", repo.OficjalnaStronaPrezydentaRzeczypospol.ImieInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.OficjalnaStronaPrezydentaRzeczypospol.ImieInfo, "Value", "");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='') on item 'OficjalnaStronaPrezydentaRzeczypospol.Nazwisko'.", repo.OficjalnaStronaPrezydentaRzeczypospol.NazwiskoInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.OficjalnaStronaPrezydentaRzeczypospol.NazwiskoInfo, "Value", "");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'OficjalnaStronaPrezydentaRzeczypospol.KontaktFormularzKraj'.", repo.OficjalnaStronaPrezydentaRzeczypospol.KontaktFormularzKrajInfo, new RecordItemIndex(5));
            Validate.Exists(repo.OficjalnaStronaPrezydentaRzeczypospol.KontaktFormularzKrajInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='') on item 'OficjalnaStronaPrezydentaRzeczypospol.Miejscowosc'.", repo.OficjalnaStronaPrezydentaRzeczypospol.MiejscowoscInfo, new RecordItemIndex(6));
            Validate.Attribute(repo.OficjalnaStronaPrezydentaRzeczypospol.MiejscowoscInfo, "Value", "");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='') on item 'OficjalnaStronaPrezydentaRzeczypospol.KodPocztowy'.", repo.OficjalnaStronaPrezydentaRzeczypospol.KodPocztowyInfo, new RecordItemIndex(7));
            Validate.Attribute(repo.OficjalnaStronaPrezydentaRzeczypospol.KodPocztowyInfo, "Value", "");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='') on item 'OficjalnaStronaPrezydentaRzeczypospol.Adres'.", repo.OficjalnaStronaPrezydentaRzeczypospol.AdresInfo, new RecordItemIndex(8));
            Validate.Attribute(repo.OficjalnaStronaPrezydentaRzeczypospol.AdresInfo, "Value", "");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'OficjalnaStronaPrezydentaRzeczypospol.Tresc'.", repo.OficjalnaStronaPrezydentaRzeczypospol.TrescInfo, new RecordItemIndex(9));
            Validate.Exists(repo.OficjalnaStronaPrezydentaRzeczypospol.TrescInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'OficjalnaStronaPrezydentaRzeczypospol.KodObrazkowy'.", repo.OficjalnaStronaPrezydentaRzeczypospol.KodObrazkowyInfo, new RecordItemIndex(10));
            Validate.Exists(repo.OficjalnaStronaPrezydentaRzeczypospol.KodObrazkowyInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='1') on item 'OficjalnaStronaPrezydentaRzeczypospol.Zgoda'.", repo.OficjalnaStronaPrezydentaRzeczypospol.ZgodaInfo, new RecordItemIndex(11));
            Validate.Attribute(repo.OficjalnaStronaPrezydentaRzeczypospol.ZgodaInfo, "Value", "1");
            Delay.Milliseconds(100);
            
            // Setting
            Report.Log(ReportLevel.Info, "Section", "Setting", new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Value to '$email' on item 'OficjalnaStronaPrezydentaRzeczypospol.Email'.", repo.OficjalnaStronaPrezydentaRzeczypospol.EmailInfo, new RecordItemIndex(13));
            repo.OficjalnaStronaPrezydentaRzeczypospol.Email.Element.SetAttributeValue("Value", email);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Value to '$name' on item 'OficjalnaStronaPrezydentaRzeczypospol.Imie'.", repo.OficjalnaStronaPrezydentaRzeczypospol.ImieInfo, new RecordItemIndex(14));
            repo.OficjalnaStronaPrezydentaRzeczypospol.Imie.Element.SetAttributeValue("Value", name);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Value to '$surname' on item 'OficjalnaStronaPrezydentaRzeczypospol.Nazwisko'.", repo.OficjalnaStronaPrezydentaRzeczypospol.NazwiskoInfo, new RecordItemIndex(15));
            repo.OficjalnaStronaPrezydentaRzeczypospol.Nazwisko.Element.SetAttributeValue("Value", surname);
            Delay.Milliseconds(0);
            
            SetCountry(country);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OficjalnaStronaPrezydentaRzeczypospol.Form' at 481;220.", repo.OficjalnaStronaPrezydentaRzeczypospol.FormInfo, new RecordItemIndex(17));
            repo.OficjalnaStronaPrezydentaRzeczypospol.Form.Click("481;220");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Value to '$city' on item 'OficjalnaStronaPrezydentaRzeczypospol.Miejscowosc'.", repo.OficjalnaStronaPrezydentaRzeczypospol.MiejscowoscInfo, new RecordItemIndex(18));
            repo.OficjalnaStronaPrezydentaRzeczypospol.Miejscowosc.Element.SetAttributeValue("Value", city);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Value to '$postalCode' on item 'OficjalnaStronaPrezydentaRzeczypospol.KodPocztowy'.", repo.OficjalnaStronaPrezydentaRzeczypospol.KodPocztowyInfo, new RecordItemIndex(19));
            repo.OficjalnaStronaPrezydentaRzeczypospol.KodPocztowy.Element.SetAttributeValue("Value", postalCode);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Value to '$address' on item 'OficjalnaStronaPrezydentaRzeczypospol.Adres'.", repo.OficjalnaStronaPrezydentaRzeczypospol.AdresInfo, new RecordItemIndex(20));
            repo.OficjalnaStronaPrezydentaRzeczypospol.Adres.Element.SetAttributeValue("Value", address);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Value to '$content' on item 'OficjalnaStronaPrezydentaRzeczypospol.Tresc'.", repo.OficjalnaStronaPrezydentaRzeczypospol.TrescInfo, new RecordItemIndex(21));
            repo.OficjalnaStronaPrezydentaRzeczypospol.Tresc.Element.SetAttributeValue("Value", content);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Value to '$testNumber' on item 'OficjalnaStronaPrezydentaRzeczypospol.KodObrazkowy'.", repo.OficjalnaStronaPrezydentaRzeczypospol.KodObrazkowyInfo, new RecordItemIndex(22));
            repo.OficjalnaStronaPrezydentaRzeczypospol.KodObrazkowy.Element.SetAttributeValue("Value", testNumber);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Success, "User", "", repo.OficjalnaStronaPrezydentaRzeczypospol.Self, false, new RecordItemIndex(23));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
