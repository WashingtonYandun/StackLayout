namespace LomasNunezYandun_StackLayout;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        Title = "Vertical StackLayout demo";

        StackLayout stackLayout = new StackLayout { Margin = new Thickness(0), BackgroundColor = Colors.Gray };

        stackLayout.Add(new Label { Text = "Argentina", TextColor = Colors.White });
        stackLayout.Add(new BoxView { Color = Colors.SkyBlue, HeightRequest = 45 });
        stackLayout.Add(new BoxView { Color = Colors.White, HeightRequest = 45 });
        stackLayout.Add(new BoxView { Color = Colors.SkyBlue, HeightRequest = 45 });
        stackLayout.Add(new Label { Text = "Polonia", TextColor = Colors.White });
        stackLayout.Add(new BoxView { Color = Colors.Red, HeightRequest = 65 });
        stackLayout.Add(new BoxView { Color = Colors.White, HeightRequest = 65 });

        stackLayout.Add(new Label { Text = "Holanda", TextColor = Colors.White });
        stackLayout.Add(new BoxView { Color = Colors.Red, HeightRequest = 45 });
        stackLayout.Add(new BoxView { Color = Colors.White, HeightRequest = 45 });
        stackLayout.Add(new BoxView { Color = Colors.Blue, HeightRequest = 45 });
        stackLayout.Add(new Label { Text = "Ecuador", TextColor = Colors.White });
        stackLayout.Add(new BoxView { Color = Colors.Yellow, HeightRequest = 65 });
        stackLayout.Add(new BoxView { Color = Colors.Blue, HeightRequest = 45 });
        stackLayout.Add(new BoxView { Color = Colors.Red, HeightRequest = 45 });

        Content = stackLayout;
    }


}

