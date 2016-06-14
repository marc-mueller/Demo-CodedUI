using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleCalculatorWpf.Controls
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:SimpleCalculatorWpf.Controls"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:SimpleCalculatorWpf.Controls;assembly=SimpleCalculatorWpf.Controls"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:NumericUpDown/>
    ///
    /// </summary>
    [TemplatePart(Name = NumericUpDown.ElementNameValue, Type = typeof(TextBox))]
    [TemplatePart(Name = NumericUpDown.ElementNameUp, Type = typeof(Button))]
    [TemplatePart(Name = NumericUpDown.ElementNameDown, Type = typeof(Button))]
    public class NumericUpDown : Control
    {
        internal const string ElementNameValue = "txtValue";
        internal const string ElementNameUp = "btnUp";
        internal const string ElementNameDown = "btnDown";
        static NumericUpDown()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NumericUpDown), new FrameworkPropertyMetadata(typeof(NumericUpDown)));
        }

        protected override AutomationPeer OnCreateAutomationPeer()
        {
            return new NumericUpDownAutomationPeer(this);
        }

        public NumericUpDown()
        {
            
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            var txtValue = this.GetTemplateChild(ElementNameValue) as TextBox;
            var btnUp = this.GetTemplateChild(ElementNameUp) as Button;
            if (btnUp != null)
            {
                btnUp.Click += BtnUp_Click;
            }
            var btnDown = this.GetTemplateChild(ElementNameDown) as Button;
            if (btnDown != null)
            {
                btnDown.Click += BtnDown_Click;
            }
        }

        private void BtnDown_Click(object sender, RoutedEventArgs e)
        {
            this.Value = this.Value - this.DecrementStep;
        }

        private void BtnUp_Click(object sender, RoutedEventArgs e)
        {
            this.Value = this.Value + this.DecrementStep;
        }

        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(NumericUpDown), new PropertyMetadata(0d, OnValueChanged, OnCoerceValue), OnValidateCallback);

        private static object OnCoerceValue(DependencyObject d, object baseValue)
        {
            var num = d as NumericUpDown;
            if(num != null)
            {
                var val = (double)baseValue;

                if (val >= num.MinValue && val <= num.MaxValue)
                {
                    return val;
                }
                else
                {
                    return val > num.MaxValue ? num.MaxValue : num.MinValue;
                }
            }
            return baseValue;
        }

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {


        }

        private static bool OnValidateCallback(object value)
        {
            return true;
        }

        public double MinValue
        {
            get { return (double)GetValue(MinValueProperty); }
            set { SetValue(MinValueProperty, value); }
        }

        public static readonly DependencyProperty MinValueProperty =
            DependencyProperty.Register("MinValue", typeof(double), typeof(NumericUpDown), new PropertyMetadata(-1000d, OnMinValueChanged));



        private static void OnMinValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }

        public double MaxValue
        {
            get { return (double)GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }


        public static readonly DependencyProperty MaxValueProperty =
           DependencyProperty.Register("MaxValue", typeof(double), typeof(NumericUpDown), new PropertyMetadata(1000d, OnMaxValueChanged));

        private static void OnMaxValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }

        public double IncrementStep
        {
            get { return (double)GetValue(IncrementStepProperty); }
            set { SetValue(IncrementStepProperty, value); }
        }

        public static readonly DependencyProperty IncrementStepProperty =
           DependencyProperty.Register("IncrementStep", typeof(double), typeof(NumericUpDown), new PropertyMetadata(1d, OnIncrementStepChanged));

        private static void OnIncrementStepChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }

        public double DecrementStep
        {
            get { return (double)GetValue(DecrementStepProperty); }
            set { SetValue(DecrementStepProperty, value); }
        }


        public static readonly DependencyProperty DecrementStepProperty =
           DependencyProperty.Register("DecrementStep", typeof(double), typeof(NumericUpDown), new PropertyMetadata(1d, OnDecrementStepChanged));

        private static void OnDecrementStepChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }
    }


}

