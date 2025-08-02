using UnityEngine.UIElements;
using UnityEngine;

namespace Game.UI.Controllers
{
	/// <summary>
	/// Controller for the main menu UI.
	/// </summary>
	public class MainMenuController
	{
		private Button newGameBtn, continueBtn, soundBtn, optionsBtn, creditsBtn, exitBtn;

		private VisualElement root;
		/// <summary>
		/// Initializes the main menu controller.
		/// </summary>
		/// <param name="root">The root element of the UI.</param>
		public MainMenuController(VisualElement root)
		{
			this.root = root;
			InitializeUIElements();
			RegisterButtonCallbacks();
		}
		private void InitializeUIElements()
		{
			newGameBtn = root.Q<Button>("NewGameButton");
			continueBtn = root.Q<Button>("ContinueButton");
			soundBtn = root.Q<Button>("SoundButton");
			optionsBtn = root.Q<Button>("OptionsButton");
			creditsBtn = root.Q<Button>("CreditsButton");
			exitBtn = root.Q<Button>("ExitButton");
		}
		private void RegisterButtonCallbacks()
		{
			newGameBtn.clicked += OnNewGameClicked;
			continueBtn.clicked += OnContinueClicked;
			soundBtn.clicked += OnSoundClicked;
			optionsBtn.clicked += OnOptionsClicked;
			creditsBtn.clicked += OnCreditsClicked;
			exitBtn.clicked += OnExitClicked;
		}
		private void OnNewGameClicked() { Debug.Log("New Game");/* Logic for starting a new game */ }
		private void OnContinueClicked() { Debug.Log("Continue");/* Logic for continuing a game */ }
		private void OnSoundClicked() { /* Logic for toggling sound */ }
		private void OnOptionsClicked() { /* Logic for opening options */ }
		private void OnCreditsClicked() { /* Logic for showing credits */ }
		private void OnExitClicked()
		{ /* Logic for exiting the game */
		}
	}
}
