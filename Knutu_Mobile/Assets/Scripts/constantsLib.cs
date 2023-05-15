public static class constantsLib
{
    public const string GAME_SCENE = "Scenes/GameScene"; //게임씬
    public const string LOBBY_SCENE = "Scenes/LobbyScene"; //로비씬
    public const string INTRO_SCENE = "Scenes/IntroScene"; //대기씬

    public static string GetScenePath(string sceneName)
    {
        switch (sceneName)
        {
            case "GAME_SCENE":
                return GAME_SCENE;
            case "LOBBY_SCENE":
                return LOBBY_SCENE;
            case "INTRO_SCENE":
                return INTRO_SCENE;
            default:
                return null;
        }
    }
}