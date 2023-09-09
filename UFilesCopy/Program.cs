using UFilesCopy.Coroutine;

namespace UFilesCopy;

static class Program
{

    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Main form = new Main();
        form.Visible = false;
        Application.Run(form);
    }
}