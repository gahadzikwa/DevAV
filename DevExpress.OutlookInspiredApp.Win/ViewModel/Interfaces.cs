﻿namespace DevExpress.OutlookInspiredApp {
    using System;
    using System.ComponentModel.DataAnnotations;
    using DevExpress.DevAV;

    public enum ModuleType {
        Unknown,
        [Display(Name = "Employees")]
        Employees,
        EmployeesFilterPane,
        EmployeesFilterPaneCollapsed,
        EmployeesPeek,
        EmployeeView,
        [Display(Name = "Edit Contact")]
        EmployeeEditView,
        [Display(Name = "Contact Map")]
        EmployeeMapView,
        EmployeesCustomFilter,
        EmployeesGroupFilter,
        EmployeesExport,
        EmployeesPrint,
        [Display(Name = "Contact Mail Merge")]
        EmployeeMailMerge,
        [Display(Name = "Customers")]
        Customers,
        CustomersFilterPane,
        CustomersFilterPaneCollapsed,
        CustomersPeek,
        CustomerView,
        CustomerEditView,
        [Display(Name = "Sales Map")]
        CustomerMapView,
        [Display(Name = "Sales Analysis")]
        CustomerAnalysis,
        CustomersCustomFilter,
        CustomersGroupFilter,
        CustomersExport,
        CustomersPrint,
        [Display(Name = "Products")]
        Products,
        ProductsFilterPane,
        ProductsFilterPaneCollapsed,
        ProductsPeek,
        ProductView,
        ProductEditView,
        [Display(Name = "Sales Map")]
        ProductMapView,
        [Display(Name = "Sales Analysis")]
        ProductAnalysis,
        ProductsCustomFilter,
        ProductsGroupFilter,
        ProductsExport,
        ProductsPrint,
        [Display(Name = "Sales")]
        Orders,
        OrdersFilterPane,
        OrdersFilterPaneCollapsed,
        OrdersCustomFilter,
        OrdersPeek,
        OrderView,
        OrderEditView,
        [Display(Name = "Shipping Map")]
        OrderMapView,
        OrdersExport,
        OrdersPrint,
        [Display(Name = "Sales Mail Merge")]
        OrderMailMerge,
        [Display(Name = "Opportunities")]
        Quotes,
        QuotesFilterPane,
        QuotesFilterPaneCollapsed,
        QuotesCustomFilter,
        QuotesPeek,
        QuoteView,
        QuoteEditView,
        [Display(Name = "Opportunities Map")]
        QuoteMapView,
        QuotesExport,
        QuotesPrint,
        Dashboards,
<<<<<<< HEAD
        DashboardsFilterPane,
        DashboardsEditView
=======
        DashboardsPane,
        DashboardsEdit
>>>>>>> 58d5963b05133ab1068392b2084d015cb969dfb8
    }
    //
    public interface IMainModule : IPeekModulesHost,
        ISupportModuleLayout, ISupportTransitions {
    }
    public interface ISupportCompactLayout {
        bool Compact { get; set; }
    }
    public interface ISupportZoom {
        int ZoomLevel { get; set; }
        event EventHandler ZoomChanged;
    }
    public interface ISupportTransitions {
        void StartTransition(bool forward, object waitParameter);
        void EndTransition();
    }
    public interface ISupportModuleLayout {
        void SaveLayoutToStream(System.IO.MemoryStream ms);
        void RestoreLayoutFromStream(System.IO.MemoryStream ms);
    }
    public interface IPeekModulesHost {
        bool IsDocked(ModuleType type);
        void DockModule(ModuleType moduleType);
        void UndockModule(ModuleType moduleType);
        void ShowPeek(ModuleType moduleType);
    }
    public interface ISupportMap {
        void ShowMap();
    }
    public interface ISupportAnalysis {
        void ShowAnalysis();
    }
    public interface IZoomViewModel {
        object ZoomModule { get; }
        event EventHandler ZoomModuleChanged;
    }
    public interface ISupportModifications {
        bool Modified { get; }
        void Save();
    }
    public interface ISupportCustomFilters {
        void ResetCustomFilters();
        event EventHandler CustomFiltersReset;
    }
    public interface IRouteMapViewModel {
        DevExpress.XtraMap.BingTravelMode TravelMode { get; set; }
        Address PointA { get; set; }
        Address PointB { get; set; }
        double RouteDistance { get; set; }
        TimeSpan RouteTime { get; set; }
        //
        event EventHandler TravelModeChanged;
        event EventHandler PointAChanged;
        event EventHandler PointBChanged;
        event EventHandler UpdateRoute;
    }
    public interface ISalesMapViewModel {
        DevAV.ViewModels.Sales.Period Period { get; set; }
        event EventHandler PeriodChanged;
    }
}
