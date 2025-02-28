﻿using Content.Client.Message;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._NF.ShuttleRecords.UI;

[GenerateTypedNameReferences]
public sealed partial class ShuttleRecordDetailsControl : PanelContainer
{
    public sealed class ViewState(string shuttleName, string shuttleOwnerName, string activity, string toolTip, string timeOfPurchase, string voucherStatus, string transactionCost, string shuttlePrice)
    {
        public string ShuttleName { get; } = shuttleName;

        public string ShuttleOwnerName { get; } = shuttleOwnerName;

        public string Activity { get; } = activity;

        public string ShuttlePrice { get; } = shuttlePrice;

        public string ToolTip { get; } = toolTip;

        public string TimeOfPurchase { get; } = timeOfPurchase;

        public string VoucherStatus { get; } = voucherStatus;

        public string TransactionCost { get; } = transactionCost;
    }

    public ShuttleRecordDetailsControl(ViewState state)
    {
        RobustXamlLoader.Load(this);
        ShuttleName.Text = state.ShuttleName;
        ShuttleOwner.Text = state.ShuttleOwnerName;
        ShuttleActivity.Text = state.Activity;
        ShuttlePrice.Text = state.ShuttlePrice;
        VoucherStatus.Text = state.VoucherStatus;
        TimeOfPurchase.SetMarkup(state.TimeOfPurchase);
        TransactionCostLabel.Text = state.TransactionCost;
        ToolTip = state.ToolTip;
    }
}
