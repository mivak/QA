﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TALS.PerformanceTesting.WebTests.Modules.KidsAcademy.EntryTests
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.WebTesting;
    using Microsoft.VisualStudio.TestTools.WebTesting.Rules;
    using TALS.PerformanceTesting.Utils.RandomDataProvider;


    public class CreateEntryTestCoded : WebTest
    {

        public CreateEntryTestCoded()
        {
            this.PreAuthenticate = true;
            this.Proxy = "default";
        }

        public override IEnumerator<WebTestRequest> GetRequestEnumerator()
        {
            // Initialize validation rules that apply to all requests in the WebTest
            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.Low))
            {
                ValidateResponseUrl validationRule1 = new ValidateResponseUrl();
                this.ValidateResponse += new EventHandler<ValidationEventArgs>(validationRule1.Validate);
            }
            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.Low))
            {
                ValidationRuleResponseTimeGoal validationRule2 = new ValidationRuleResponseTimeGoal();
                validationRule2.Tolerance = 0D;
                this.ValidateResponseOnPageComplete += new EventHandler<ValidationEventArgs>(validationRule2.Validate);
            }

            WebTestRequest request1 = new WebTestRequest("http://test.telerikacademy.com/");
            request1.ThinkTime = 1;
            yield return request1;
            request1 = null;

            WebTestRequest request2 = new WebTestRequest("http://test.telerikacademy.com/Users/Auth/Login");
            request2.ThinkTime = 7;
            request2.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/"));
            yield return request2;
            request2 = null;

            WebTestRequest request3 = new WebTestRequest("http://test.telerikacademy.com/Users/Auth/Login");
            request3.ThinkTime = 1;
            request3.Method = "POST";
            request3.ExpectedResponseUrl = "http://test.telerikacademy.com/";
            request3.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/Users/Auth/Login"));
            FormPostHttpBody request3Body = new FormPostHttpBody();
            request3Body.FormPostParameters.Add("UsernameOrEmail", "demo12");
            request3Body.FormPostParameters.Add("Password", "qwerty");
            request3.Body = request3Body;
            yield return request3;
            request3 = null;

            WebTestRequest request4 = new WebTestRequest("http://test.telerikacademy.com/Administration/Navigation");
            request4.ThinkTime = 2;
            request4.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/"));
            yield return request4;
            request4 = null;

            WebTestRequest request5 = new WebTestRequest("http://test.telerikacademy.com/KidsAcademy/AdministrationKidsCandidatesExams");
            request5.ThinkTime = 1;
            request5.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/Administration/Navigation"));
            WebTestRequest request5Dependent1 = new WebTestRequest("http://test.telerikacademy.com/KidsAcademy/AdministrationKidsCandidatesExams/Read" +
                    "");
            request5Dependent1.ThinkTime = 24;
            request5Dependent1.Method = "POST";
            request5Dependent1.Headers.Add(new WebTestRequestHeader("Accept", "*/*"));
            request5Dependent1.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request5Dependent1.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/KidsAcademy/AdministrationKidsCandidatesExams"));
            FormPostHttpBody request5Dependent1Body = new FormPostHttpBody();
            request5Dependent1Body.FormPostParameters.Add("sort", "KidsCandidateExamId-desc");
            request5Dependent1Body.FormPostParameters.Add("page", "1");
            request5Dependent1Body.FormPostParameters.Add("pageSize", "25");
            request5Dependent1Body.FormPostParameters.Add("group", "");
            request5Dependent1Body.FormPostParameters.Add("filter", "");
            request5Dependent1.Body = request5Dependent1Body;
            request5.DependentRequests.Add(request5Dependent1);
            yield return request5;
            request5 = null;

            WebTestRequest request6 = new WebTestRequest("http://test.telerikacademy.com/KidsAcademy/AdministrationKidsCandidatesExams/Crea" +
                    "te");
            request6.ThinkTime = 2;
            request6.Method = "POST";
            request6.Headers.Add(new WebTestRequestHeader("Accept", "*/*"));
            request6.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request6.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/KidsAcademy/AdministrationKidsCandidatesExams"));
            FormPostHttpBody request6Body = new FormPostHttpBody();
            request6Body.FormPostParameters.Add("sort", "");
            request6Body.FormPostParameters.Add("group", "");
            request6Body.FormPostParameters.Add("filter", "");
            request6Body.FormPostParameters.Add("KidsCandidateExamId", "0");
            request6Body.FormPostParameters.Add("TestScheduleId", "0");
            request6Body.FormPostParameters.Add("TestConfigurationId", RandomStringProvider.GetRandomInt(1,6));
            request6Body.FormPostParameters.Add("StartTime", "15/12/2014 15:56:55");
            request6Body.FormPostParameters.Add("EndTime", "15/01/2015 16:41:55");
            request6Body.FormPostParameters.Add("TrainingRoomId", RandomStringProvider.GetRandomInt(1,4));
            request6Body.FormPostParameters.Add("CandidatesCountLimit", RandomStringProvider.GetRandomInt(10, 250));
            request6Body.FormPostParameters.Add("FreePlaces", "0");
            request6Body.FormPostParameters.Add("UsersCount", "0");
            request6Body.FormPostParameters.Add("CandidateForCityId", "43");
            request6.Body = request6Body;
            yield return request6;
            request6 = null;

            WebTestRequest request7 = new WebTestRequest("http://test.telerikacademy.com/Users/Auth/LogOut");
            request7.ThinkTime = 1;
            request7.ExpectedResponseUrl = "http://test.telerikacademy.com/";
            request7.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/KidsAcademy/AdministrationKidsCandidatesExams"));
            yield return request7;
            request7 = null;
        }
    }
}
