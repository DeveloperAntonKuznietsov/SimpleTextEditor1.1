using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEditor.BL;

namespace SimpleTextRedactor
{
	class MainPresenter
	{
			private readonly IMainForm view;
			private readonly IFileManager manager;
			private readonly IMessageService messageService;

		private string currentFilePath;


			public MainPresenter(IMainForm view, IFileManager manager, IMessageService messageService)
			{
				this.view = view;
				this.manager = manager;
				this.messageService = messageService;

			view.SetSymbolCount(0);
			view.ContentChanged += new EventHandler(view_ContentChanged);
			view.FileOpenClick += view_FileOpenClick;
			view.FileSaveClick += view_FileSaveClick;
			}

		private void view_FileSaveClick(object sender, EventArgs e)
		{
			try
			{
				string content = view.Content;
				manager.SaveContent(content, currentFilePath);
				messageService.ShowMessage("File successfully saved");
			}
			catch (Exception ex)
			{
				messageService.ShowError(ex.Message);
			}
		}

		private void view_FileOpenClick(object sender, EventArgs e)
		{
			try
			{
				string filePath = view.FilePath;
				bool isExist = manager.IsExist(filePath);

				if (!isExist)
				{
					messageService.ShowExclamation("The selected file does not exist");
					return;
				}

				currentFilePath = filePath;

				string content = manager.GetContent(filePath);
				int count = manager.GetSymbolCount(content);

				view.Content = content;
				view.SetSymbolCount(count);
			}
			catch (Exception ex)
			{
				messageService.ShowError(ex.Message);
			}
		}

		void view_ContentChanged(object sender, EventArgs e)
		{
			string content = view.Content;

			int count = manager.GetSymbolCount(content);

			view.SetSymbolCount(count);
		}
	}
}
