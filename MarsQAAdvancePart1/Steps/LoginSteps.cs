using MarsQAAdvancePart1.Pages.Components.SignIn;
using MarsQAAdvancePart1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQAAdvancePart1.Model;
using MarsQAAdvancePart1.Helpers;

namespace MarsQAAdvancePart1.Steps
{
    public class LoginSteps
    {
        SplashPage loginPage;
        LoginComponent loginComponent;

        public LoginSteps()
        {
            loginPage = new SplashPage();
            loginComponent = new LoginComponent();
        }

        public void doLogin()
        {
            UserInformationModel userInformation = new UserInformationModel();
            userInformation.userName = ConstantHelpers.UserName;
            userInformation.password = ConstantHelpers.Password;

            loginPage.clickSignInButton();
            loginComponent.doSignIn(userInformation);
        }
    }
}
