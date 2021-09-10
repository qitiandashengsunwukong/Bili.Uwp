﻿// Copyright (c) Richasy. All rights reserved.

namespace Richasy.Bili.App.Controls
{
    /// <summary>
    /// 播放器说明组件，包括发布者，标题和说明文本等.
    /// </summary>
    public sealed partial class PlayerDescriptor : PlayerComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerDescriptor"/> class.
        /// </summary>
        public PlayerDescriptor()
        {
            this.InitializeComponent();
        }

        private async void OnUserTappedAsync(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            await UserView.Instance.ShowAsync(ViewModel.Publisher);
        }
    }
}
