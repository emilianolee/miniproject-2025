﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMrpSimulatorApp.ViewModels
{
    public partial class SettingViewModel : ObservableObject
    {
        #region View와 연동할 멤버 변수들

        private string _basicCode;
        private string _codeName;
        private string? _codeDesc;
        private DateTime? _regDt;
        private DateTime? _modDt; 

        #endregion

        #region View와 연동할 속성
        public string BasicCode
        {
            get => _basicCode;
            set => SetProperty(ref _basicCode, value);
        }

        public string CodeName
        {
            get => _codeName;
            set => SetProperty(ref _codeName, value);
        }

        public string? CodeDesc
        {
            get => _codeDesc;
            set => SetProperty(ref _codeDesc, value);
        }
        
        public DateTime? RegDt {
            get => _regDt;
            set => SetProperty(ref _regDt, value); 
        }

        public DateTime? ModDt { 
            get => _modDt;
            set => SetProperty(ref _modDt, value);
        }

        #endregion

        public SettingViewModel()
        {
        }
    }
}
