using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using WpfIoTSimulatorApp.ViewModels;

namespace WpfIoTSimulatorApp.Views
{
    /// <summary>
    /// MainView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainView : MetroWindow
    {
        private readonly MainViewModel _viewmodel;
        public MainView()
        {
            InitializeComponent();
        }

        // View상에 있는 이벤트핸들러를 전부 제거
        // WPF 상의 객체 애니메이션 추가. 애니메이션은 디자이너 역할(View)
        public void StartHmiAni()
        {
            // 기어 애니메이션
            DoubleAnimation ga = new DoubleAnimation
            {
                From = 0,
                To = 360,    // 360도 회전
                Duration = TimeSpan.FromSeconds(2), // 계획 로드타임(Schedules의 LoadTime 값이 들어가야 함)
            };

            RotateTransform rt = new RotateTransform();
            GearStart.RenderTransform = rt;
            GearStart.RenderTransformOrigin = new System.Windows.Point(0.5, 0.5);
            GearEnd.RenderTransform = rt;
            GearEnd.RenderTransformOrigin = new System.Windows.Point(0.5, 0.5);

            rt.BeginAnimation(RotateTransform.AngleProperty, ga);

            // 제품 애니메이션
            DoubleAnimation pa = new DoubleAnimation
            {
                From = 127,
                To = 454,  // x축: 센서 아래 위치
                Duration = TimeSpan.FromSeconds(2), // 계획 로드타임(Schedules의 LoadTime 값이 들어가야 함)
            };  // 위와 같은 초기화가 좀 더 최신 트렌드

            // 아래와 같은 초기화는 구식 트렌드
            //pa.From = 127;
            //pa.To = 454; 
            //pa.Duration = TimeSpan.FromSeconds(2);

            Product.BeginAnimation(Canvas.LeftProperty, pa);
        }


        public void StartSensorCheck()
        {
            // 센서 애니메이션
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                DoubleAnimation sa = new DoubleAnimation
                {
                    From = 1,
                    To = 0,
                    Duration = TimeSpan.FromSeconds(1),
                    AutoReverse = true
                };

                SortingSensor.BeginAnimation(OpacityProperty, sa);
                
                //Thread.Sleep(2000); // 1초 딜레이
                
            }));

            // 랜덤으로 색상을 결정짓는 작업
            Random rand = new Random();
            int result = rand.Next(1, 3);   // 1~2 중 하나 선별

        }
    }
}
