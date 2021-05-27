﻿using System;
using System.IO;
using System.Windows.Input;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;
using Codexzier.Wpf.ApplicationFramework.Views.Base;
using WpfAppTemplateForNuget.Components.LegacyData;
using WpfAppTemplateForNuget.Views.Base;

namespace WpfAppTemplateForNuget.Views.Dialog
{
    internal class ButtonCommandSelectedPathDialogAccept : ICommand
    {
        private readonly DialogViewModel _viewModel;

        public ButtonCommandSelectedPathDialogAccept(DialogViewModel viewModel) => this._viewModel = viewModel;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter)
        {
            EventBusManager.CloseView<DialogView>(10);

            var selectedFolder = this._viewModel.SelectedDirectoryPath.FolderName;

            if (string.IsNullOrEmpty(selectedFolder))
            {
                SimpleStatusOverlays.Show("Import Fehler", "Kein Ordner ausgewählt");
                return;
            }

            if (!Directory.Exists(selectedFolder))
            {
                SimpleStatusOverlays.Show("Import Fehler", $"Dieser Ordner ist nicht gültig! {selectedFolder}");
                return;
            }

            var count = new LegacyDataConverter().Run(selectedFolder);

            SimpleStatusOverlays.Show("Import abgeschlossen", $"Es wurden {count} Dateien importiert aus dem Ordner '{selectedFolder}'");
        }
    }
}