using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using Game.UI.Controllers;

namespace Game.UI.Views
{
    /// <summary>
    /// Represents the main menu view in the game.
    /// </summary>
    /// <remarks>
    /// This class is responsible for managing the main menu UI elements and interactions.
    /// </remarks>
    public class MainMenuView : MonoBehaviour
    {
        private MainMenuController mainMenuController;
        private VisualElement root;

		private void OnEnable()
		{
            root = GetComponent<UIDocument>().rootVisualElement;
			root.Clear(); // Clear existing elements to avoid duplication

            AsyncOperationHandle<VisualTreeAsset> handle = Addressables.LoadAssetAsync<VisualTreeAsset>("Assets/UI/UXML/MainMenu.uxml");
			handle.Completed += OnAssetLoaded;
		}

		private void OnDisable()
		{
			
		}

		private void OnAssetLoaded(AsyncOperationHandle<VisualTreeAsset> handle)
        {
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                var tree = handle.Result.CloneTree(); // Clone the main menu UI from the asset
                root.Add(tree);
				mainMenuController = new MainMenuController(tree);
			}
            else
            {
                Debug.LogError("Failed to load MainMenuUXML asset: " + handle.OperationException);
			}
            
            Addressables.Release(handle); // Release the handle to free resources
		}
	}
}
