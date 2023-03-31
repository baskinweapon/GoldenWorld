using UnityEngine;
using UnityEngine.UI;

namespace Architecture.mvvm {
    public class ConcreteScreen : AbstractScreen<ConcreteViewModel> {
       [SerializeField] private Text _health;
       [SerializeField] private Button _someButton;
       private ConcreteViewModel _model1;
    
       private void Start() {
           _someButton.onClick.AddListener(AddHealth);
       }
    
       protected override void OnBind(ConcreteViewModel model)
       {
           _model1 = model;
           _health.text = model.Health.ToString();
       }
    
       // button Action
       private void AddHealth() {
           _model1.DoSomething();
       }
    }
    
    public class ConcreteViewModel : BaseViewModel {
       private readonly IGameData _gameData;
       public int Health => _gameData.Health;
       
       public ConcreteViewModel(IGameData gameData) {
           _gameData = gameData;
       }
       
       public void DoSomething() {
           _gameData.AddHealth();
       }
    }
}

public interface IGameData {
    int Health { get; }
    void AddHealth();
}

