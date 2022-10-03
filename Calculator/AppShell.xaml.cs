namespace Calculator;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

    void OnDark(object sender, EventArgs e)
    {
        ICollection<ResourceDictionary> mergedDictionaries = App.Current.Resources.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();
            mergedDictionaries.Add(new DarkMode());
        }
    }
}

