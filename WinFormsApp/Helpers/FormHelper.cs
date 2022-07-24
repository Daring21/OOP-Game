namespace WinFormsApp.Helpers;

public static class FormHelper
{
    public static void OpenForm(Form currentForm, Form newForm)
    {
        currentForm.Hide();
        newForm.Show();
    }
}