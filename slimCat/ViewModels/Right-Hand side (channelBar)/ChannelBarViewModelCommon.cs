﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using lib;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using Models;
using slimCat;

namespace ViewModels
{
    /// <summary>
    /// Contains some things the channelbar viewmodels have in common
    /// </summary>
    public class ChannelbarViewModelCommon : ViewModelBase
    {
        #region Fields
        private GenericSearchSettingsModel _searchSettings = new GenericSearchSettingsModel();
        public GenericSearchSettingsModel SearchSettings { get { return _searchSettings; } }
        #endregion

        #region Constructors
        public ChannelbarViewModelCommon(IUnityContainer contain, IRegionManager regman,
                                          IEventAggregator events, IChatModel cm)
            : base(contain, regman, events, cm)
        {
        }

        public override void Initialize() { }
        #endregion
    }
}