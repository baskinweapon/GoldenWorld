using UnityEngine;

namespace Architecture.mvvm {
    public abstract class BaseScreen : MonoBehaviour {
    
           public abstract System.Type ModelType { get; }
           public abstract void Show();
           public abstract void Close();
           public abstract void Bind(object model);
        
           public virtual void Dispose() {
           }
    }
    
    public abstract class AbstractScreen<TModel> : BaseScreen where TModel:IViewModel
    {
       public override System.Type ModelType => typeof(TModel);
       protected TModel _model;
    
       public override void Show() {
           gameObject.SetActive(true);
       }
    
       public override void Close() {
           gameObject.SetActive(false);
       }
    
       public override void Bind(object model) {
           if (model is TModel)
               Bind((TModel) model);
       }
    
       public void Bind(TModel model) {
           _model = model;
           OnBind(model);
       }
    
       protected abstract void OnBind(TModel model);
    }
}