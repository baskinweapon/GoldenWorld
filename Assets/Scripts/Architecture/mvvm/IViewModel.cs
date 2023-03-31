public interface IViewModel: System.IDisposable {
}

public abstract class BaseViewModel : IViewModel {

   public virtual void Dispose()   { }
}
