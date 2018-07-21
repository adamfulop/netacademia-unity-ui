public class ExitGameButton : ButtonBehaviour<MainMenuController> {
    protected override void OnClick() {
        Controller.ExitGame();
    }
}
