﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.261
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.Registration.AllFeaturesEndToEnd
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class SelfRegistrantEndToEndScenarioForMakingARegistrationForAConferenceSadPathFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SelfRegistrationEndToEndSad.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Self Registrant end to end scenario for making a Registration for a Conference (s" +
                    "ad path)", "In order to register for a conference\r\nAs an Attendee\r\nI want to be able to regis" +
                    "ter for the conference, pay for the Registration Order and associate myself with" +
                    " the paid Order automatically", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Self Registrant end to end scenario for making a Registration for a Conference (s" +
                            "ad path)")))
            {
                Conference.Specflow.Features.Registration.AllFeaturesEndToEnd.SelfRegistrantEndToEndScenarioForMakingARegistrationForAConferenceSadPathFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "rate",
                        "quota"});
            table1.AddRow(new string[] {
                        "General admission",
                        "$199",
                        "10"});
            table1.AddRow(new string[] {
                        "CQRS Workshop",
                        "$500",
                        "10"});
            table1.AddRow(new string[] {
                        "Additional cocktail party",
                        "$50",
                        "10"});
#line 7
 testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference with th" +
                    "e slug code SelfRegE2Esad", ((string)(null)), table1);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table2.AddRow(new string[] {
                        "General admission",
                        "1"});
            table2.AddRow(new string[] {
                        "CQRS Workshop",
                        "1"});
            table2.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 12
 testRunner.And("the selected Order Items", ((string)(null)), table2);
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("All Seat Types are available, one get reserved and two get waitlisted")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Self Registrant end to end scenario for making a Registration for a Conference (s" +
            "ad path)")]
        public virtual void AllSeatTypesAreAvailableOneGetReservedAndTwoGetWaitlisted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All Seat Types are available, one get reserved and two get waitlisted", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type"});
            table3.AddRow(new string[] {
                        "CQRS Workshop"});
            table3.AddRow(new string[] {
                        "Additional cocktail party"});
#line 25
 testRunner.Given("these Seat Types becomes unavailable before the Registrant make the reservation", ((string)(null)), table3);
#line 29
 testRunner.When("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table4.AddRow(new string[] {
                        "CQRS Workshop",
                        "1"});
            table4.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 30
 testRunner.Then("the Registrant is offered to be waitlisted for these Order Items", ((string)(null)), table4);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table5.AddRow(new string[] {
                        "General admission",
                        "1"});
#line 34
 testRunner.And("these Order Items should be reserved", ((string)(null)), table5);
#line 37
 testRunner.And("the total should read $199");
#line 38
 testRunner.And("the countdown started");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("1 order item is available, 2 are waitlisted, 1 available and 1 waitlisted are sel" +
            "ected, then 1 get reserved and 1 get waitlisted")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Self Registrant end to end scenario for making a Registration for a Conference (s" +
            "ad path)")]
        public virtual void _1OrderItemIsAvailable2AreWaitlisted1AvailableAnd1WaitlistedAreSelectedThen1GetReservedAnd1GetWaitlisted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1 order item is available, 2 are waitlisted, 1 available and 1 waitlisted are sel" +
                    "ected, then 1 get reserved and 1 get waitlisted", ((string[])(null)));
#line 43
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table6.AddRow(new string[] {
                        "General admission",
                        "1"});
#line 44
 testRunner.Given("the list of available Order Items selected by the Registrant", ((string)(null)), table6);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table7.AddRow(new string[] {
                        "CQRS Workshop",
                        "1"});
            table7.AddRow(new string[] {
                        "Additional cocktail party",
                        "0"});
#line 47
 testRunner.And("the list of these Order Items offered to be waitlisted and selected by the Regist" +
                    "rant", ((string)(null)), table7);
#line 51
 testRunner.When("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table8.AddRow(new string[] {
                        "CQRS Workshop",
                        "1"});
#line 52
 testRunner.Then("these order itmes get confirmed being waitlisted", ((string)(null)), table8);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table9.AddRow(new string[] {
                        "General admission",
                        "1"});
#line 55
 testRunner.And("these other order items get reserved", ((string)(null)), table9);
#line 58
 testRunner.And("the countdown started");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Checkout:Registrant Invalid Details")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Self Registrant end to end scenario for making a Registration for a Conference (s" +
            "ad path)")]
        public virtual void CheckoutRegistrantInvalidDetails()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Checkout:Registrant Invalid Details", ((string[])(null)));
#line 61
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 62
 testRunner.Given("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "First name",
                        "Last name",
                        "email address"});
            table10.AddRow(new string[] {
                        "Gregory",
                        "",
                        "gregoryweber@invalid"});
#line 63
 testRunner.And("the Registrant enter these details", ((string)(null)), table10);
#line 66
 testRunner.When("the Registrant proceed to Checkout:Payment");
#line 67
 testRunner.Then("the message \'The LastName field is required.\' will show up");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Checkout:Payment with cancellation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Self Registrant end to end scenario for making a Registration for a Conference (s" +
            "ad path)")]
        public virtual void CheckoutPaymentWithCancellation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Checkout:Payment with cancellation", ((string[])(null)));
#line 70
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 71
 testRunner.Given("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "First name",
                        "Last name",
                        "email address"});
            table11.AddRow(new string[] {
                        "Gregory",
                        "Weber",
                        "gregoryweber@contoso.com"});
#line 72
 testRunner.And("the Registrant enter these details", ((string)(null)), table11);
#line 75
 testRunner.And("the Registrant proceed to Checkout:Payment");
#line 76
 testRunner.When("the Registrant proceed to cancel the payment");
#line 77
    testRunner.Then("the message \'Payment cancelled.\' will show up");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Partial Promotional Code for none of the selected items")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Self Registrant end to end scenario for making a Registration for a Conference (s" +
            "ad path)")]
        public virtual void PartialPromotionalCodeForNoneOfTheSelectedItems()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Partial Promotional Code for none of the selected items", ((string[])(null)));
#line 80
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table12.AddRow(new string[] {
                        "CQRS Workshop",
                        "1"});
#line 81
 testRunner.Given("the selected Order Items", ((string)(null)), table12);
#line 84
 testRunner.And("the total amount should be of $500");
#line 85
 testRunner.When("the Registrant apply the \'VOLUNTEER\' Promotional Code");
#line 86
 testRunner.Then("the \'VOLUNTEER\' Promo code will not be applied and an error message will inform a" +
                    "bout the problem");
#line 87
 testRunner.And("the total amount should be of $500");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Partiall Seats allocation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Self Registrant end to end scenario for making a Registration for a Conference (s" +
            "ad path)")]
        public virtual void PartiallSeatsAllocation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Partiall Seats allocation", ((string[])(null)));
#line 90
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 91
testRunner.Given("the ConfirmSuccessfulRegistration for the selected Order Items");
#line 92
testRunner.And("the Order Access code is 6789");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "First name",
                        "Last name",
                        "email address",
                        "Seat type"});
            table13.AddRow(new string[] {
                        "Gregory",
                        "Weber",
                        "gregoryweber@contoso.com",
                        "General admission"});
#line 93
testRunner.And("I assign the purchased seats to attendees as following", ((string)(null)), table13);
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "First name",
                        "Last name",
                        "email address",
                        "Seat type"});
            table14.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "Additional cocktail party"});
#line 96
testRunner.And("leave unassigned these seats", ((string)(null)), table14);
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "First name",
                        "Last name",
                        "email address",
                        "Seat type"});
            table15.AddRow(new string[] {
                        "Gregory",
                        "Weber",
                        "gregoryweber@contoso.com",
                        "General admission"});
#line 99
testRunner.Then("I should be getting a seat assignment confirmation for the seats", ((string)(null)), table15);
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Access code",
                        "email address",
                        "Seat type"});
            table16.AddRow(new string[] {
                        "6789-1",
                        "gregoryweber@contoso.com",
                        "General admission"});
#line 102
testRunner.And("the Attendees should get an email informing about the conference and the Seat Typ" +
                    "e with Seat Access Code", ((string)(null)), table16);
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Complete Seats allocation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Self Registrant end to end scenario for making a Registration for a Conference (s" +
            "ad path)")]
        public virtual void CompleteSeatsAllocation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Complete Seats allocation", ((string[])(null)));
#line 107
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 108
testRunner.Given("the ConfirmSuccessfulRegistration for the selected Order Items");
#line 109
testRunner.And("the Order Access code is 6789");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "First name",
                        "Last name",
                        "email address",
                        "Seat type"});
            table17.AddRow(new string[] {
                        "Gregory",
                        "Weber",
                        "gregoryweber@contoso.com",
                        "Additional cocktail party"});
#line 110
testRunner.And("the Registrant assign the purchased seats to attendees as following", ((string)(null)), table17);
#line 113
testRunner.Then("the Registrant should be get a Seat Assignment confirmation");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Access code",
                        "email address",
                        "Seat type"});
            table18.AddRow(new string[] {
                        "6789-2",
                        "gregoryweber@contoso.com",
                        "Additional cocktail party"});
#line 114
testRunner.And("the Attendees should get an email informing about the conference and the Seat Typ" +
                    "e with Seat Access Code", ((string)(null)), table18);
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
