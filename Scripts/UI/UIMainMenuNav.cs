namespace Fish;

public partial class UIMainMenuNav : Node
{
    public override void _Ready()
    {
        GetNode<Button>("Play").GrabFocus();
    }

    void _on_play_pressed()
    {
        Global.Services.Get<AudioManager>().PlayMusic(Music.Level1, false);
        Global.Services.Get<SceneManager>().SwitchScene("level_3D", 
            SceneManager.TransType.Fade);
    }

    void _on_options_pressed()
    {
        Global.Services.Get<AudioManager>().PlayMusic(Music.Level4);
        Global.Services.Get<SceneManager>().SwitchScene("Prefabs/UI/options");
    }

    void _on_credits_pressed()
    {
        Global.Services.Get<AudioManager>().PlayMusic(Music.Level4);
        Global.Services.Get<SceneManager>().SwitchScene("credits");
    }

    void _on_quit_pressed() => 
        GetNode<Global>("/root/Global").Quit();

    void _on_discord_pressed() =>
        OS.ShellOpen("https://discord.gg/866cg8yfxZ");
    void _on_github_pressed() =>
        OS.ShellOpen("https://github.com/ValksGodotTools/Template");
}
