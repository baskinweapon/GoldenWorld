using Architecture.mvvm;
using TMPro;
using UnityEngine.UI;

public class MaterialViewModel : BaseViewModel {
   private readonly DiggerMaterials diggerMaterials;

   public MaterialViewModel(DiggerMaterials _diggerMaterials) {
       diggerMaterials = _diggerMaterials;
   }

   public void Press() {
       // _gameData.AddHealth();
   }
}

public class materialPanel : AbstractScreen<MaterialViewModel>
{
    public TextMeshProUGUI currencyText;
    public Image icon;
    
    protected override void OnBind(MaterialViewModel model) {
        throw new System.NotImplementedException();
    }
}
