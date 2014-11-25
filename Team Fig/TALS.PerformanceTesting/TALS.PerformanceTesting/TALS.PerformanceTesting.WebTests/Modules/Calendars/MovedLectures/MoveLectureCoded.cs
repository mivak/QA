﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TALS.PerformanceTesting.WebTest
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.WebTesting;
    using Microsoft.VisualStudio.TestTools.WebTesting.Rules;


    public class MoveLectureCoded : WebTest
    {

        public MoveLectureCoded()
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
            request2.ThinkTime = 12;
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
            request4.ThinkTime = 6;
            request4.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/"));
            yield return request4;
            request4 = null;

            WebTestRequest request5 = new WebTestRequest("http://test.telerikacademy.com/Administration_Calendar/MovedLectures");
            request5.ThinkTime = 1;
            request5.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/Administration/Navigation"));
            WebTestRequest request5Dependent1 = new WebTestRequest("http://test.telerikacademy.com/Administration_Calendar/MovedLectures/GetCascadeCo" +
                    "urses");
            request5Dependent1.Headers.Add(new WebTestRequestHeader("Accept", "*/*"));
            request5Dependent1.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request5Dependent1.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/Administration_Calendar/MovedLectures"));
            request5.DependentRequests.Add(request5Dependent1);
            WebTestRequest request5Dependent2 = new WebTestRequest("http://test.telerikacademy.com/Administration_Calendar/MovedLectures/MovedLecture" +
                    "s_Read");
            request5Dependent2.ThinkTime = 2;
            request5Dependent2.Method = "POST";
            request5Dependent2.Headers.Add(new WebTestRequestHeader("Accept", "*/*"));
            request5Dependent2.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request5Dependent2.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/Administration_Calendar/MovedLectures"));
            FormPostHttpBody request5Dependent2Body = new FormPostHttpBody();
            request5Dependent2Body.FormPostParameters.Add("sort", "MovedLectureId-desc");
            request5Dependent2Body.FormPostParameters.Add("page", "1");
            request5Dependent2Body.FormPostParameters.Add("pageSize", "25");
            request5Dependent2Body.FormPostParameters.Add("group", "");
            request5Dependent2Body.FormPostParameters.Add("filter", "");
            request5Dependent2.Body = request5Dependent2Body;
            request5.DependentRequests.Add(request5Dependent2);
            yield return request5;
            request5 = null;

            WebTestRequest request6 = new WebTestRequest("http://test.telerikacademy.com/Administration_Calendar/MovedLectures/GetCascadeCo" +
                    "urses");
            request6.ThinkTime = 26;
            request6.Headers.Add(new WebTestRequestHeader("Accept", "*/*"));
            request6.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request6.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/Administration_Calendar/MovedLectures"));
            request6.QueryStringParameters.Add("isAllCoursesListItemIncluded", "false", false, false);
            yield return request6;
            request6 = null;

            WebTestRequest request7 = new WebTestRequest("http://test.telerikacademy.com/Administration_Calendar/MovedLectures/MovedLecture" +
                    "s_Create");
            request7.ThinkTime = 4;
            request7.Method = "POST";
            request7.Headers.Add(new WebTestRequestHeader("Accept", "*/*"));
            request7.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request7.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/Administration_Calendar/MovedLectures"));
            FormPostHttpBody request7Body = new FormPostHttpBody();
            request7Body.FormPostParameters.Add("sort", "");
            request7Body.FormPostParameters.Add("group", "");
            request7Body.FormPostParameters.Add("filter", "");
            request7Body.FormPostParameters.Add("MovedLectureId", "0");
            request7Body.FormPostParameters.Add("CourseInstanceId", "");
            request7Body.FormPostParameters.Add("CourseInstanceName", "");
            request7Body.FormPostParameters.Add("StartTime", "01/12/2014 15:30:00");
            request7Body.FormPostParameters.Add("NewStartTime", "");
            request7Body.FormPostParameters.Add("NewTrainingRoomId", "");
            request7.Body = request7Body;
            yield return request7;
            request7 = null;

            WebTestRequest request8 = new WebTestRequest("http://test.telerikacademy.com/Users/Auth/LogOut");
            request8.ThinkTime = 1;
            request8.ExpectedResponseUrl = "http://test.telerikacademy.com/";
            request8.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/Administration_Calendar/MovedLectures"));
            yield return request8;
            request8 = null;
        }
    }
}