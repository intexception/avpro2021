Public NotInheritable Class SplashScreen1

    'TODO: Ten formularz może być łatwo ustawiony jako ekran powitalny dla aplikacji przez przejście do karty „Aplikacja”
    '  Projektanta projektu („Właściwości” w menu „Projekt”).


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Konfiguruj tekst w oknie dialogowym w trakcie wykonywania, zgodnie z informacjami o zestawie aplikacji.  

        'TODO: Dostosuj informacje o zestawie aplikacji w okienku „Aplikacja” projektu 
        '  okno dialogowe właściwości (w menu „Projekt”).

        'Tytuł aplikacji


        'Formatuj informację o wersji przy użyciu tekstu, ustawianego w formancie wersji w czasie projektowania, jako
        '  ciąg formatowania.  Pozwala to na skuteczną lokalizację w razie potrzeby.
        '  Informacja o kompilacji i poprawce mogła zostać dołączona przez użycie następującego kodu i zmianę 
        '  Tekst czasu projektowania formantu wersji na "Wersja {0}.{1:00}.{2}.{3}" lub coś podobnego.  Zobacz
        '  String.Format() w pomocy, aby uzyskać więcej informacji.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
        Timer1.Start()
    End Sub

    Private Sub MainLayoutPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GunaGradientPanel1_Click(sender As Object, e As EventArgs) Handles GunaGradientPanel1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form1.Show()
        Me.Hide()
        Timer1.Stop()
    End Sub
End Class
