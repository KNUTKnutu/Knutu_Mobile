public static class constantsLib
{
    private const string SCENE_PATH_PREFIX = "Scenes/";
    public const string GAME_SCENE = "GameScene"; // 게임씬
    public const string LOBBY_SCENE = "LobbyScene"; // 로비씬
    public const string INTRO_SCENE = "IntroScene"; // 대기씬

    public static string GetScenePath(string _sceneName)
    {
        return SCENE_PATH_PREFIX + _sceneName;
    }
}