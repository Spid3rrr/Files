// Copyright (c) 2023 Files Community
// Licensed under the MIT License. See the LICENSE.

using Microsoft.UI.Xaml;
using System;
using System.Threading.Tasks;

namespace Files.App.UserControls.MultitaskingControl
{
	public interface ITabItemContainer
	{
		public ITabItemContent TabItemContent { get; }

		public event EventHandler<TabItemArguments> ContentChanged;
	}

	public interface ITabItemContent
	{
		public bool IsCurrentInstance { get; set; }

		public TabItemArguments TabItemArguments { get; }

		public event EventHandler<TabItemArguments> ContentChanged;

		public Task TabItemDragOver(object sender, DragEventArgs e);

		public Task TabItemDrop(object sender, DragEventArgs e);
	}

	public interface ITabItem
	{
		public TabItemArguments TabItemArguments { get; }
	}
}