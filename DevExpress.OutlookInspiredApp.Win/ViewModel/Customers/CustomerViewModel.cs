namespace DevExpress.OutlookInspiredApp.Win.ViewModel {
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DevAV.ViewModels;

    public partial class CustomerViewModel : CustomerViewModelBase {
        public CustomerViewModel()
            : base(DbUnitOfWorkFactory.Instance) {
        }
        public event System.EventHandler EntityChanged;
        protected override void OnEntityChanged() {
            base.OnEntityChanged();
            System.EventHandler handler = EntityChanged;
            if(handler != null)
                handler(this, System.EventArgs.Empty);
        }
    }
    public partial class synchronizedCustomerViewModel : CustomerViewModel {
        protected override bool EnableSelectedItemSynchronization {
            get { return true; }
        }
        protected override bool EnableEntityChangedSynchronization {
            get { return true; }
        }
    }
}
