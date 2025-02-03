﻿namespace CollectionViewFooterHeight;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        CollectionView.ItemsSource = new [] { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10", "Item 11", "Item 12", "Item 13", "Item 14", "Item 15" };
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        FooterView.IsVisible = !FooterView.IsVisible;
        
        //not resize also with height change request
        //FooterView.HeightRequest = FooterView.Height / 2;
    }
}