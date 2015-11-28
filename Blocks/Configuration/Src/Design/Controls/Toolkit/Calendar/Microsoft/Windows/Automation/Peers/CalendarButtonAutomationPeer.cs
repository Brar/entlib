﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Core
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

//---------------------------------------------------------------------------
//
// Copyright (C) Microsoft Corporation.  All rights reserved.
//
//---------------------------------------------------------------------------

using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design.Controls.Toolkit.Windows.Controls.Primitives;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design.Controls.Toolkit.Windows.Controls;

using Calendar = Microsoft.Practices.EnterpriseLibrary.Configuration.Design.Controls.Toolkit.Windows.Controls.Calendar;
using CalendarMode = Microsoft.Practices.EnterpriseLibrary.Configuration.Design.Controls.Toolkit.Windows.Controls.CalendarMode;
using CalendarSelectionMode = Microsoft.Practices.EnterpriseLibrary.Configuration.Design.Controls.Toolkit.Windows.Controls.CalendarSelectionMode;

namespace Microsoft.Practices.EnterpriseLibrary.Configuration.Design.Controls.Toolkit.Windows.Automation.Peers
{
    /// <summary>
    /// AutomationPeer for CalendarButton
    /// </summary>
    public sealed class CalendarButtonAutomationPeer : ButtonAutomationPeer, IGridItemProvider, ISelectionItemProvider
    {
        /// <summary>
        /// Initializes a new instance of the CalendarButtonAutomationPeer class.
        /// </summary>
        /// <param name="owner">Owning CalendarButton</param>
        public CalendarButtonAutomationPeer(CalendarButton owner)
            : base(owner)
        {
        }

        #region Private Properties

        private Calendar OwningCalendar
        {
            get
            {
                return this.OwningCalendarButton.Owner;
            }
        }

        private IRawElementProviderSimple OwningCalendarAutomationPeer
        {
            get
            {
                if (this.OwningCalendar != null)
                {
                    AutomationPeer peer = CreatePeerForElement(this.OwningCalendar);

                    if (peer != null)
                    {
                        return ProviderFromPeer(peer);
                    }
                }

                return null;
            }
        }

        private CalendarButton OwningCalendarButton
        {
            get
            {
                return this.Owner as CalendarButton;
            }
        }

        private DateTime? Date
        {
            get
            {
                if (this.OwningCalendarButton != null && this.OwningCalendarButton.DataContext is DateTime)
                {
                    return (DateTime?)this.OwningCalendarButton.DataContext;
                }
                else
                {
                    return null;
                }
            }
        }

        #endregion Private Properties

        #region Public Methods

        /// <summary>
        /// Gets the control pattern that is associated with the specified System.Windows.Automation.Peers.PatternInterface.
        /// </summary>
        /// <param name="patternInterface">A value from the System.Windows.Automation.Peers.PatternInterface enumeration.</param>
        /// <returns>The object that supports the specified pattern, or null if unsupported.</returns>
        public override object GetPattern(PatternInterface patternInterface)
        {
            object result = null;

            switch (patternInterface)
            {
                case PatternInterface.SelectionItem:
                case PatternInterface.GridItem:
                    {
                        if (this.OwningCalendar != null && this.OwningCalendar.MonthControl != null && this.OwningCalendarButton != null)
                        {
                            result = this;
                        }
                        else
                        {
                            result = base.GetPattern(patternInterface);
                        }

                        break;
                    }

                default:
                    {
                        result = base.GetPattern(patternInterface);
                        break;
                    }
            }

            return result;
        }

        #endregion Public methods

        #region Protected Methods

        /// <summary>
        /// Gets the control type for the element that is associated with the UI Automation peer.
        /// </summary>
        /// <returns>The control type.</returns>
        protected override AutomationControlType GetAutomationControlTypeCore()
        {
            return AutomationControlType.Button;
        }

        /// <summary>
        /// Called by GetClassName that gets a human readable name that, in addition to AutomationControlType, 
        /// differentiates the control represented by this AutomationPeer.
        /// </summary>
        /// <returns>The string that contains the name.</returns>
        protected override string GetClassNameCore()
        {
            return Owner.GetType().Name;
        }

        /// <summary>
        /// Overrides the GetLocalizedControlTypeCore method for CalendarButtonAutomationPeer
        /// </summary>
        /// <returns></returns>
        protected override string GetLocalizedControlTypeCore()
        {
            return SR.Get(SRID.CalendarAutomationPeer_CalendarButtonLocalizedControlType);
        }

        /// <summary>
        /// Overrides the GetHelpTextCore method for CalendarButtonAutomationPeer
        /// </summary>
        /// <returns></returns>
        protected override string GetHelpTextCore()
        {
            DateTime? date = this.Date;
            return date.HasValue ? DateTimeHelper.ToLongDateString(date, DateTimeHelper.GetCulture(this.OwningCalendarButton)) : base.GetHelpTextCore();
        }

        /// <summary>
        /// Overrides the GetNameCore method for CalendarButtonAutomationPeer
        /// </summary>
        /// <returns></returns>
        protected override string GetNameCore()
        {
            DateTime? date = this.Date;
            if (date.HasValue)
            {
                if (this.OwningCalendar.DisplayMode == CalendarMode.Decade)
                {
                    return DateTimeHelper.ToYearString(date, DateTimeHelper.GetCulture(this.OwningCalendarButton));
                }
                else
                {
                    return DateTimeHelper.ToYearMonthPatternString(date, DateTimeHelper.GetCulture(this.OwningCalendarButton));
                }
            }
            else
            {
                return base.GetNameCore();
            }
        }

        #endregion Protected Methods

        #region IGridItemProvider

        int IGridItemProvider.Column
        {
            get
            {
                return (int)this.OwningCalendarButton.GetValue(Grid.ColumnProperty);
            }
        }

        int IGridItemProvider.ColumnSpan 
        {
            get
            {
                return (int)this.OwningCalendarButton.GetValue(Grid.ColumnSpanProperty);
            }
        }

        IRawElementProviderSimple IGridItemProvider.ContainingGrid
        {
            get
            {
                return this.OwningCalendarAutomationPeer;
            }
        }

        int IGridItemProvider.Row
        {
            get
            {
                return (int)this.OwningCalendarButton.GetValue(Grid.RowSpanProperty);
            }
        }

        int IGridItemProvider.RowSpan 
        { 
            get 
            { 
                return 1; 
            } 
        }

        #endregion IGridItemProvider

        #region ISelectionItemProvider

        bool ISelectionItemProvider.IsSelected 
        { 
            get 
            { 
                return this.OwningCalendarButton.IsFocused; 
            } 
        }

        IRawElementProviderSimple ISelectionItemProvider.SelectionContainer
        {
            get
            {
                return this.OwningCalendarAutomationPeer;
            }
        }

        void ISelectionItemProvider.AddToSelection()
        {
            return;
        }

        void ISelectionItemProvider.RemoveFromSelection()
        {
            return;
        }

        void ISelectionItemProvider.Select()
        {
            if (this.OwningCalendarButton.IsEnabled)
            {
                this.OwningCalendarButton.MoveFocus(new TraversalRequest(FocusNavigationDirection.First));
            }
            else
            {
                throw new ElementNotEnabledException();
            }
        }

        #endregion ISelectionItemProvider
    }
}
