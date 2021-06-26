using UnityEngine;
using TMPro;

public class GameHandler : MonoBehaviour {
     
     [SerializeField] private TextMeshProUGUI textComponent;
     [SerializeField] private State startingState;

     private State _state;
     
     private void Start() {
          _state = startingState;
          textComponent.text = _state.GetStateStory();
     }

     private void Update() {
          ManageState();
     }

     private void ManageState() {
          var nextStates = _state.GetNextStates();

          for (var i = 0; i < nextStates.Length; i++) {
               if (Input.GetKeyDown(KeyCode.Alpha1 + i)) {
                    _state = nextStates[i];
               }
          }

          textComponent.text = _state.GetStateStory();
     }
}
