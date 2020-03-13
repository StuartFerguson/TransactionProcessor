// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TransactionProcessor.IntegrationTests.SaleTransaction
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "base")]
    [Xunit.TraitAttribute("Category", "shared")]
    public partial class SaleTransactionFeature : object, Xunit.IClassFixture<SaleTransactionFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "base",
                "shared"};
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "SaleTransactionFeature.feature"
#line hidden
        
        public SaleTransactionFeature(SaleTransactionFeature.FixtureData fixtureData, TransactionProcessor_IntegrationTests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SaleTransaction", null, ProgrammingLanguage.CSharp, new string[] {
                        "base",
                        "shared"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "ResourceName",
                        "DisplayName",
                        "Secret",
                        "Scopes",
                        "UserClaims"});
            table22.AddRow(new string[] {
                        "estateManagement",
                        "Estate Managememt REST",
                        "Secret1",
                        "estateManagement",
                        "MerchantId, EstateId, role"});
            table22.AddRow(new string[] {
                        "transactionProcessor",
                        "Transaction Processor REST",
                        "Secret1",
                        "transactionProcessor",
                        ""});
#line 6
 testRunner.Given("the following api resources exist", ((string)(null)), table22, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "ClientId",
                        "ClientName",
                        "Secret",
                        "AllowedScopes",
                        "AllowedGrantTypes"});
            table23.AddRow(new string[] {
                        "serviceClient",
                        "Service Client",
                        "Secret1",
                        "estateManagement,transactionProcessor",
                        "client_credentials"});
#line 11
 testRunner.Given("the following clients exist", ((string)(null)), table23, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "ClientId"});
            table24.AddRow(new string[] {
                        "serviceClient"});
#line 15
 testRunner.Given("I have a token to access the estate management and transaction processor resource" +
                    "s", ((string)(null)), table24, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "EstateName"});
            table25.AddRow(new string[] {
                        "Test Estate 1"});
            table25.AddRow(new string[] {
                        "Test Estate 2"});
#line 19
 testRunner.Given("I have created the following estates", ((string)(null)), table25, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "EstateName",
                        "OperatorName",
                        "RequireCustomMerchantNumber",
                        "RequireCustomTerminalNumber"});
            table26.AddRow(new string[] {
                        "Test Estate 1",
                        "Safaricom",
                        "True",
                        "True"});
#line 24
 testRunner.Given("I have created the following operators", ((string)(null)), table26, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "MerchantName",
                        "AddressLine1",
                        "Town",
                        "Region",
                        "Country",
                        "ContactName",
                        "EmailAddress",
                        "EstateName"});
            table27.AddRow(new string[] {
                        "Test Merchant 1",
                        "Address Line 1",
                        "TestTown",
                        "Test Region",
                        "United Kingdom",
                        "Test Contact 1",
                        "testcontact1@merchant1.co.uk",
                        "Test Estate 1"});
            table27.AddRow(new string[] {
                        "Test Merchant 2",
                        "Address Line 1",
                        "TestTown",
                        "Test Region",
                        "United Kingdom",
                        "Test Contact 2",
                        "testcontact2@merchant2.co.uk",
                        "Test Estate 1"});
            table27.AddRow(new string[] {
                        "Test Merchant 3",
                        "Address Line 1",
                        "TestTown",
                        "Test Region",
                        "United Kingdom",
                        "Test Contact 3",
                        "testcontact3@merchant2.co.uk",
                        "Test Estate 2"});
#line 28
 testRunner.Given("I create the following merchants", ((string)(null)), table27, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "OperatorName",
                        "MerchantName",
                        "MerchantNumber",
                        "TerminalNumber",
                        "EstateName"});
            table28.AddRow(new string[] {
                        "Safaricom",
                        "Test Merchant 1",
                        "00000001",
                        "10000001",
                        "Test Estate 1"});
#line 34
 testRunner.Given("I have assigned the following  operator to the merchants", ((string)(null)), table28, "Given ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Sale Transactions")]
        [Xunit.TraitAttribute("FeatureTitle", "SaleTransaction")]
        [Xunit.TraitAttribute("Description", "Sale Transactions")]
        [Xunit.TraitAttribute("Category", "PRTest")]
        public virtual void SaleTransactions()
        {
            string[] tagsOfScenario = new string[] {
                    "PRTest"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sale Transactions", null, new string[] {
                        "PRTest"});
#line 39
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                            "DateTime",
                            "TransactionNumber",
                            "TransactionType",
                            "MerchantName",
                            "DeviceIdentifier",
                            "EstateName",
                            "OperatorName",
                            "TransactionAmount"});
                table29.AddRow(new string[] {
                            "Today",
                            "1",
                            "Sale",
                            "Test Merchant 1",
                            "123456780",
                            "Test Estate 1",
                            "Safaricom",
                            "100.00"});
#line 41
 testRunner.When("I perform the following transactions", ((string)(null)), table29, "When ");
#line hidden
                TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                            "EstateName",
                            "MerchantName",
                            "TransactionNumber",
                            "ResponseCode",
                            "ResponseMessage"});
                table30.AddRow(new string[] {
                            "Test Estate 1",
                            "Test Merchant 1",
                            "1",
                            "0000",
                            "SUCCESS"});
#line 47
 testRunner.Then("transaction response should contain the following information", ((string)(null)), table30, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Sale Transaction with Existing Device")]
        [Xunit.TraitAttribute("FeatureTitle", "SaleTransaction")]
        [Xunit.TraitAttribute("Description", "Sale Transaction with Existing Device")]
        public virtual void SaleTransactionWithExistingDevice()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sale Transaction with Existing Device", null, ((string[])(null)));
#line 53
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                            "DeviceIdentifier",
                            "MerchantName",
                            "MerchantNumber",
                            "EstateName"});
                table31.AddRow(new string[] {
                            "123456780",
                            "Test Merchant 1",
                            "00000001",
                            "Test Estate 1"});
#line 55
 testRunner.Given("I have assigned the following devices to the merchants", ((string)(null)), table31, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                            "DateTime",
                            "TransactionNumber",
                            "TransactionType",
                            "MerchantName",
                            "DeviceIdentifier",
                            "EstateName",
                            "OperatorName",
                            "TransactionAmount"});
                table32.AddRow(new string[] {
                            "Today",
                            "1",
                            "Sale",
                            "Test Merchant 1",
                            "123456780",
                            "Test Estate 1",
                            "Safaricom",
                            "100.00"});
#line 59
 testRunner.When("I perform the following transactions", ((string)(null)), table32, "When ");
#line hidden
                TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                            "EstateName",
                            "MerchantName",
                            "TransactionNumber",
                            "ResponseCode",
                            "ResponseMessage"});
                table33.AddRow(new string[] {
                            "Test Estate 1",
                            "Test Merchant 1",
                            "1",
                            "0000",
                            "SUCCESS"});
#line 63
 testRunner.Then("transaction response should contain the following information", ((string)(null)), table33, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Sale Transaction with Invalid Device")]
        [Xunit.TraitAttribute("FeatureTitle", "SaleTransaction")]
        [Xunit.TraitAttribute("Description", "Sale Transaction with Invalid Device")]
        [Xunit.TraitAttribute("Category", "PRTest")]
        public virtual void SaleTransactionWithInvalidDevice()
        {
            string[] tagsOfScenario = new string[] {
                    "PRTest"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sale Transaction with Invalid Device", null, new string[] {
                        "PRTest"});
#line 68
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                            "DeviceIdentifier",
                            "MerchantName",
                            "MerchantNumber",
                            "EstateName"});
                table34.AddRow(new string[] {
                            "123456780",
                            "Test Merchant 1",
                            "00000001",
                            "Test Estate 1"});
#line 70
 testRunner.Given("I have assigned the following devices to the merchants", ((string)(null)), table34, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                            "DateTime",
                            "TransactionNumber",
                            "TransactionType",
                            "MerchantName",
                            "DeviceIdentifier",
                            "EstateName",
                            "OperatorName",
                            "TransactionAmount"});
                table35.AddRow(new string[] {
                            "Today",
                            "1",
                            "Sale",
                            "Test Merchant 1",
                            "123456781",
                            "Test Estate 1",
                            "Safaricom",
                            "100.00"});
#line 74
 testRunner.When("I perform the following transactions", ((string)(null)), table35, "When ");
#line hidden
                TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                            "EstateName",
                            "MerchantName",
                            "TransactionNumber",
                            "ResponseCode",
                            "ResponseMessage"});
                table36.AddRow(new string[] {
                            "Test Estate 1",
                            "Test Merchant 1",
                            "1",
                            "1000",
                            "Device Identifier 123456781 not valid for Merchant Test Merchant 1"});
#line 78
 testRunner.Then("transaction response should contain the following information", ((string)(null)), table36, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Sale Transaction with Invalid Estate")]
        [Xunit.TraitAttribute("FeatureTitle", "SaleTransaction")]
        [Xunit.TraitAttribute("Description", "Sale Transaction with Invalid Estate")]
        public virtual void SaleTransactionWithInvalidEstate()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sale Transaction with Invalid Estate", null, ((string[])(null)));
#line 82
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                            "DeviceIdentifier",
                            "MerchantName",
                            "MerchantNumber",
                            "EstateName"});
                table37.AddRow(new string[] {
                            "123456780",
                            "Test Merchant 1",
                            "00000001",
                            "Test Estate 1"});
#line 84
 testRunner.Given("I have assigned the following devices to the merchants", ((string)(null)), table37, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                            "DateTime",
                            "TransactionNumber",
                            "TransactionType",
                            "MerchantName",
                            "DeviceIdentifier",
                            "EstateName",
                            "OperatorName",
                            "TransactionAmount"});
                table38.AddRow(new string[] {
                            "Today",
                            "1",
                            "Sale",
                            "Test Merchant 1",
                            "123456781",
                            "InvalidEstate",
                            "Safaricom",
                            "100.00"});
#line 88
 testRunner.When("I perform the following transactions", ((string)(null)), table38, "When ");
#line hidden
                TechTalk.SpecFlow.Table table39 = new TechTalk.SpecFlow.Table(new string[] {
                            "EstateName",
                            "MerchantName",
                            "TransactionNumber",
                            "ResponseCode",
                            "ResponseMessage"});
                table39.AddRow(new string[] {
                            "InvalidEstate",
                            "Test Merchant 1",
                            "1",
                            "1001",
                            "Estate Id [79902550-64df-4491-b0c1-4e78943928a3] is not a valid estate"});
#line 92
 testRunner.Then("transaction response should contain the following information", ((string)(null)), table39, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Sale Transaction with Invalid Merchant")]
        [Xunit.TraitAttribute("FeatureTitle", "SaleTransaction")]
        [Xunit.TraitAttribute("Description", "Sale Transaction with Invalid Merchant")]
        public virtual void SaleTransactionWithInvalidMerchant()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sale Transaction with Invalid Merchant", null, ((string[])(null)));
#line 96
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table40 = new TechTalk.SpecFlow.Table(new string[] {
                            "DeviceIdentifier",
                            "MerchantName",
                            "MerchantNumber",
                            "EstateName"});
                table40.AddRow(new string[] {
                            "123456780",
                            "Test Merchant 1",
                            "00000001",
                            "Test Estate 1"});
#line 98
 testRunner.Given("I have assigned the following devices to the merchants", ((string)(null)), table40, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table41 = new TechTalk.SpecFlow.Table(new string[] {
                            "DateTime",
                            "TransactionNumber",
                            "TransactionType",
                            "MerchantName",
                            "DeviceIdentifier",
                            "EstateName",
                            "OperatorName",
                            "TransactionAmount"});
                table41.AddRow(new string[] {
                            "Today",
                            "1",
                            "Sale",
                            "InvalidMerchant",
                            "123456781",
                            "Test Estate 1",
                            "Safaricom",
                            "100.00"});
#line 102
 testRunner.When("I perform the following transactions", ((string)(null)), table41, "When ");
#line hidden
                TechTalk.SpecFlow.Table table42 = new TechTalk.SpecFlow.Table(new string[] {
                            "EstateName",
                            "MerchantName",
                            "TransactionNumber",
                            "ResponseCode",
                            "ResponseMessage"});
                table42.AddRow(new string[] {
                            "Test Estate 1",
                            "InvalidMerchant",
                            "1",
                            "1002",
                            "Merchant Id [d59320fa-4c3e-4900-a999-483f6a10c69a] is not a valid merchant for es" +
                                "tate [Test Estate 1]"});
#line 106
 testRunner.Then("transaction response should contain the following information", ((string)(null)), table42, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SaleTransactionFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SaleTransactionFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
