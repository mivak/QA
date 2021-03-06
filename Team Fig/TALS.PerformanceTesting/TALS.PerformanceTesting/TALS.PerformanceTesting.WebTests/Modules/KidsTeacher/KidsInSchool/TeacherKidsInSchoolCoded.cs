﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TALS.PerformanceTesting.WebTest.Modules.KidsTeacher.KidsInSchool
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.WebTesting;
    using Microsoft.VisualStudio.TestTools.WebTesting.Rules;
    using TALS.PerformanceTesting.Utils.RandomDataProvider;

    [DeploymentItem("tals.performancetesting.webtests\\modules\\kidsteacher\\kidsinschool\\Data\\LoginData.csv" +
        "", "tals.performancetesting.webtests\\modules\\kidsteacher\\kidsinschool\\Data")]
    [DataSource("LoginData", "Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\tals.performancetesting.webtests\\modules\\kidsteacher\\kidsinschool\\Da" +
        "ta\\LoginData.csv", Microsoft.VisualStudio.TestTools.WebTesting.DataBindingAccessMethod.Sequential, Microsoft.VisualStudio.TestTools.WebTesting.DataBindingSelectColumns.SelectOnlyBoundColumns, "LoginData#csv")]
    [DataBinding("LoginData", "LoginData#csv", "Username", "LoginData.LoginData#csv.Username")]
    [DataBinding("LoginData", "LoginData#csv", "Password", "LoginData.LoginData#csv.Password")]
    [DeploymentItem("tals.performancetesting.webtests\\modules\\kidsteacher\\kidsinschool\\Data\\KidsInSch" +
        "oolData.csv", "tals.performancetesting.webtests\\modules\\kidsteacher\\kidsinschool\\Data")]
    [DataSource("TeacherData", "Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\tals.performancetesting.webtests\\modules\\kidsteacher\\kidsinschoo" +
        "l\\Data\\KidsInSchoolData.csv", Microsoft.VisualStudio.TestTools.WebTesting.DataBindingAccessMethod.Sequential, Microsoft.VisualStudio.TestTools.WebTesting.DataBindingSelectColumns.SelectOnlyBoundColumns, "KidsInSchoolData#csv")]
    [DataBinding("TeacherData", "KidsInSchoolData#csv", "Username", "TeacherData.KidsInSchoolData#csv.Username")]
    [DataBinding("TeacherData", "KidsInSchoolData#csv", "Email", "TeacherData.KidsInSchoolData#csv.Email")]
    public class TeacherKidsInSchoolCoded : WebTest
    {

        public TeacherKidsInSchoolCoded()
        {
            this.PreAuthenticate = true;
            this.Proxy = "default";
        }

        public void GenerateKidInSchoolData(out string parentFirstName, out string parentLastName, out string parentEmail, out string parentMobilePhone)
        {
            var parentFirstNameLength = int.Parse(RandomStringProvider.GetRandomInt(5, 14));
            parentFirstName = RandomStringProvider.GetRandomBulgarianString(parentFirstNameLength);

            var parentLastNameLength = int.Parse(RandomStringProvider.GetRandomInt(5, 14));
            parentLastName = RandomStringProvider.GetRandomBulgarianString(parentLastNameLength);

            parentEmail = RandomStringProvider.GetRandomEmail();

            parentMobilePhone = RandomStringProvider.GetRandomPhoneNumber();
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
            request1.ThinkTime = 2;
            yield return request1;
            request1 = null;

            WebTestRequest request2 = new WebTestRequest("http://test.telerikacademy.com/Users/Auth/Login");
            request2.ThinkTime = 11;
            request2.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/"));
            yield return request2;
            request2 = null;

            WebTestRequest request3 = new WebTestRequest("http://test.telerikacademy.com/Users/Auth/Login");
            request3.ThinkTime = 1;
            request3.Method = "POST";
            request3.ExpectedResponseUrl = "http://test.telerikacademy.com/";
            request3.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/Users/Auth/Login"));
            FormPostHttpBody request3Body = new FormPostHttpBody();
            request3Body.FormPostParameters.Add("UsernameOrEmail", this.Context["LoginData.LoginData#csv.Username"].ToString());
            request3Body.FormPostParameters.Add("Password", this.Context["LoginData.LoginData#csv.Password"].ToString());
            request3.Body = request3Body;
            yield return request3;
            request3 = null;

            WebTestRequest request4 = new WebTestRequest("http://test.telerikacademy.com/KidsAcademy/AdministrationPanel/Index/8");
            request4.ThinkTime = 1;
            request4.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/"));
            yield return request4;
            request4 = null;

            WebTestRequest request5 = new WebTestRequest("http://test.telerikacademy.com/KidsAcademy/TeacherAdministrationUsersInKidsSchool" +
                    "/Index/8");
            request5.Headers.Add(new WebTestRequestHeader("Accept", "text/html, */*; q=0.01"));
            request5.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request5.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/KidsAcademy/AdministrationPanel/Index/8"));
            request5.QueryStringParameters.Add("_", "1415801375364", false, false);
            yield return request5;
            request5 = null;

            WebTestRequest request6 = new WebTestRequest("http://test.telerikacademy.com/KidsAcademy/TeacherAdministrationUsersInKidsSchool" +
                    "/UsersInKidsSchoolRead");
            request6.ThinkTime = 11;
            request6.Method = "POST";
            request6.Headers.Add(new WebTestRequestHeader("Accept", "*/*"));
            request6.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request6.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/KidsAcademy/AdministrationPanel/Index/8"));
            request6.QueryStringParameters.Add("kidsSchoolId", "8", false, false);
            FormPostHttpBody request6Body = new FormPostHttpBody();
            request6Body.FormPostParameters.Add("sort", "UserId-desc");
            request6Body.FormPostParameters.Add("page", "1");
            request6Body.FormPostParameters.Add("pageSize", "25");
            request6Body.FormPostParameters.Add("group", "");
            request6Body.FormPostParameters.Add("filter", "");
            request6.Body = request6Body;
            yield return request6;
            request6 = null;

            string parentFirstName, parentLastName, parentEmail, parentPhone;
            GenerateKidInSchoolData(out parentFirstName, out parentLastName, out parentEmail, out parentPhone);

            WebTestRequest request7 = new WebTestRequest("http://test.telerikacademy.com/KidsAcademy/TeacherAdministrationUsersInKidsSchool" +
                    "/UserInKidsSchoolCreate");
            request7.ThinkTime = 6;
            request7.Method = "POST";
            request7.Headers.Add(new WebTestRequestHeader("Accept", "*/*"));
            request7.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request7.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/KidsAcademy/AdministrationPanel/Index/8"));
            request7.QueryStringParameters.Add("kidsSchoolId", "8", false, false);
            FormPostHttpBody request7Body = new FormPostHttpBody();
            request7Body.FormPostParameters.Add("sort", "");
            request7Body.FormPostParameters.Add("group", "");
            request7Body.FormPostParameters.Add("filter", "");
            request7Body.FormPostParameters.Add("UserInKidsSchoolId", "0");
            request7Body.FormPostParameters.Add("StatusInKidsSchool", "false");
            request7Body.FormPostParameters.Add("UserId", "0");
            request7Body.FormPostParameters.Add("AcademyNumber", "");
            request7Body.FormPostParameters.Add("Username", this.Context["TeacherData.KidsInSchoolData#csv.Username"].ToString());
            request7Body.FormPostParameters.Add("Email", this.Context["TeacherData.KidsInSchoolData#csv.Email"].ToString());
            request7Body.FormPostParameters.Add("FirstName", "");
            request7Body.FormPostParameters.Add("LastName", "");
            request7Body.FormPostParameters.Add("About", "");
            request7Body.FormPostParameters.Add("SchoolName", "");
            request7Body.FormPostParameters.Add("ClassId", "");
            request7Body.FormPostParameters.Add("Name", "");
            request7Body.FormPostParameters.Add("Gender", "");
            request7Body.FormPostParameters.Add("WorkEducationStatusId", "");
            request7Body.FormPostParameters.Add("WorkEducationStatusName", "");
            request7Body.FormPostParameters.Add("Phone", "");
            request7Body.FormPostParameters.Add("BirthDay", "");
            request7Body.FormPostParameters.Add("CityId", "0");
            request7Body.FormPostParameters.Add("CityName", "");
            request7Body.FormPostParameters.Add("FacultyNumber", "");
            request7Body.FormPostParameters.Add("Website", "");
            request7Body.FormPostParameters.Add("SkypeUsername", "");
            request7Body.FormPostParameters.Add("FacebookUrl", "");
            request7Body.FormPostParameters.Add("GooglePlusUrl", "");
            request7Body.FormPostParameters.Add("LinkedInUrl", "");
            request7Body.FormPostParameters.Add("TwiterUrl", "");
            request7Body.FormPostParameters.Add("RegistrationTime", "");
            request7Body.FormPostParameters.Add("LastLoginTime", "");
            request7Body.FormPostParameters.Add("LastLogoutTime", "");
            request7Body.FormPostParameters.Add("ParentFirstName", parentFirstName);
            request7Body.FormPostParameters.Add("ParentLastName", parentLastName);
            request7Body.FormPostParameters.Add("ParentFullName", "");
            request7Body.FormPostParameters.Add("ParentEmail", parentEmail);
            request7Body.FormPostParameters.Add("ParentPhone", parentPhone);
            request7Body.FormPostParameters.Add("AvatarId", "");
            request7Body.FormPostParameters.Add("ProfileAvatarImagePath", "");
            request7.Body = request7Body;
            yield return request7;
            request7 = null;

            WebTestRequest request8 = new WebTestRequest("http://test.telerikacademy.com/KidsAcademy/TeacherAdministrationUsersInKidsSchool" +
                    "/UserInKidsSchoolDestroy");
            request8.ThinkTime = 4;
            request8.Method = "POST";
            request8.Headers.Add(new WebTestRequestHeader("Accept", "*/*"));
            request8.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request8.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/KidsAcademy/AdministrationPanel/Index/8"));
            request8.QueryStringParameters.Add("kidsSchoolId", "8", false, false);
            FormPostHttpBody request8Body = new FormPostHttpBody();
            request8Body.FormPostParameters.Add("UserInKidsSchoolId", "209");
            request8Body.FormPostParameters.Add("StatusInKidsSchool", "true");
            request8Body.FormPostParameters.Add("Username", this.Context["TeacherData.KidsInSchoolData#csv.Username"].ToString());
            request8Body.FormPostParameters.Add("Email", this.Context["TeacherData.KidsInSchoolData#csv.Email"].ToString());
            request8Body.FormPostParameters.Add("ParentFullName", string.Concat(parentFirstName, " ", parentLastName));
            request8Body.FormPostParameters.Add("ParentEmail", parentEmail);
            request8Body.FormPostParameters.Add("ParentPhone", parentPhone);
            request8Body.FormPostParameters.Add("AvatarId", "5");
            request8Body.FormPostParameters.Add("ProfileAvatarImagePath", "/Content/Avatars/005/5_7c78257b_180x180.jpg");
            request8.Body = request8Body;
            yield return request8;
            request8 = null;

            WebTestRequest request9 = new WebTestRequest("http://test.telerikacademy.com/KidsAcademy/AdministrationPanel/Index/8");
            request9.ThinkTime = 1;
            request9.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/"));
            yield return request9;
            request9 = null;

            WebTestRequest request10 = new WebTestRequest("http://test.telerikacademy.com/KidsAcademy/TeacherAdministrationUsersInKidsSchool" +
                    "/Index/8");
            request10.Headers.Add(new WebTestRequestHeader("Accept", "text/html, */*; q=0.01"));
            request10.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request10.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/KidsAcademy/AdministrationPanel/Index/8"));
            request10.QueryStringParameters.Add("_", "1415801476387", false, false);
            yield return request10;
            request10 = null;

            WebTestRequest request11 = new WebTestRequest("http://test.telerikacademy.com/KidsAcademy/TeacherAdministrationUsersInKidsSchool" +
                    "/UsersInKidsSchoolRead");
            request11.ThinkTime = 4;
            request11.Method = "POST";
            request11.Headers.Add(new WebTestRequestHeader("Accept", "*/*"));
            request11.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request11.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/KidsAcademy/AdministrationPanel/Index/8"));
            request11.QueryStringParameters.Add("kidsSchoolId", "8", false, false);
            FormPostHttpBody request11Body = new FormPostHttpBody();
            request11Body.FormPostParameters.Add("sort", "UserId-desc");
            request11Body.FormPostParameters.Add("page", "1");
            request11Body.FormPostParameters.Add("pageSize", "25");
            request11Body.FormPostParameters.Add("group", "");
            request11Body.FormPostParameters.Add("filter", "");
            request11.Body = request11Body;
            yield return request11;
            request11 = null;

            WebTestRequest request12 = new WebTestRequest("http://test.telerikacademy.com/Users/Auth/LogOut");
            request12.ThinkTime = 1;
            request12.ExpectedResponseUrl = "http://test.telerikacademy.com/";
            request12.Headers.Add(new WebTestRequestHeader("Referer", "http://test.telerikacademy.com/KidsAcademy/AdministrationPanel/Index/8"));
            yield return request12;
            request12 = null;
        }
    }
}
