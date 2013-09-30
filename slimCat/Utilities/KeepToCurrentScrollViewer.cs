﻿namespace Slimcat.Utilities
{
    using System;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// This handles scroll management for async loading objects.
    /// </summary>
    public class KeepToCurrentScrollViewer
    {
        #region Fields

        private readonly ScrollViewer scroller;

        private double lastValue = 0.0;

        private double lastHeight = 0.0;

        private bool hookedToBottom = true;

        #endregion

        #region Constructors and Destructors

        public KeepToCurrentScrollViewer(DependencyObject toManage)
        {
            toManage.ThrowIfNull("toManage");

            this.scroller = StaticFunctions.FindChild<ScrollViewer>(toManage);
            if (this.scroller == null)
            {
                throw new ArgumentException("toManage");
            }

            this.scroller.ScrollChanged += this.OnScrollChanged;
        }

        private void OnScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            var difference = Math.Abs(this.scroller.ScrollableHeight - this.lastHeight);
            this.lastHeight = this.scroller.ScrollableHeight;

            if (difference != 0)
            {
                if (this.hookedToBottom)
                {
                    this.scroller.ScrollToBottom();
                }
            }
            else if (Math.Abs(e.VerticalOffset - this.scroller.ScrollableHeight) < 20)
            {
                this.hookedToBottom = true;
            }
            else
            {
                this.hookedToBottom = false;
            }
        }

        #endregion

        #region Public Methods and Operators

        public void Stick()
        {
            this.lastValue = this.scroller.ScrollableHeight;
        }

        public void ScrollToStick()
        {
            var change = this.scroller.ScrollableHeight - this.lastValue;
            this.scroller.ScrollToVerticalOffset(this.scroller.VerticalOffset + change);
        }

        #endregion
    }
}