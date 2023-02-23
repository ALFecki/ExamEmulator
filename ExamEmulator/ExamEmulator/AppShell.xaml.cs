using ExamEmulator.Pages;

namespace ExamEmulator;

public partial class AppShell : Shell
{
	public AppShell()
	{
        InitializeComponent();
        Routing.RegisterRoute("registrationPage", typeof(RegistrationPage));
        Routing.RegisterRoute("examPage", typeof(ExamPage));
        Routing.RegisterRoute("addExamPage", typeof(AddExamPage));
        Routing.RegisterRoute("answerQuestionPage", typeof(AnswerQuestionPage));
        Routing.RegisterRoute("answerTicketPage", typeof(AnswerTicketPage));
        Routing.RegisterRoute("generalQuestionPage", typeof(GeneralQuestionPage));
        Routing.RegisterRoute("genetralTicketPage", typeof(GenetralTicketPage));
        Routing.RegisterRoute("signInPage", typeof(SignInPage));

    }
}
