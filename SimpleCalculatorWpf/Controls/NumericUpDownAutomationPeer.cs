using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Providers;

namespace SimpleCalculatorWpf.Controls
{
    public class NumericUpDownAutomationPeer : FrameworkElementAutomationPeer, IValueProvider, IRangeValueProvider
    {
        public NumericUpDownAutomationPeer(FrameworkElement owner) : base(owner)
        {
            this.NumericUpDownOwner = owner as NumericUpDown;
        }

        public string Value
        {
            get
            {
                return this.NumericUpDownOwner.Value.ToString();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public NumericUpDown NumericUpDownOwner { get; private set; }

        double IRangeValueProvider.Value
        {
            get
            {
                return this.NumericUpDownOwner.Value;
            }
        }

        public double Maximum
        {
            get
            {
                return this.NumericUpDownOwner.MaxValue;
            }
        }

        public double Minimum
        {
            get
            {
                return this.NumericUpDownOwner.MinValue;
            }
        }

        public double LargeChange
        {
            get
            {
                return this.NumericUpDownOwner.IncrementStep;
            }
        }

        public double SmallChange
        {
            get
            {
                return this.NumericUpDownOwner.IncrementStep;
            }
        }

        protected override string GetClassNameCore()
        {
            return "NumericUpDown";
        }

        protected override AutomationControlType GetAutomationControlTypeCore()
        {
            return AutomationControlType.Edit;
        }

        
        public override object GetPattern(PatternInterface patternInterface)
        {
            if(patternInterface == PatternInterface.Value)
            {
                return this;
            }
            else if (patternInterface == PatternInterface.RangeValue)
            {
                return this;
            }
            return base.GetPattern(patternInterface);
        }

        public void SetValue(string value)
        {
            this.NumericUpDownOwner.Value = double.Parse(value);
        }

        public void SetValue(double value)
        {
            this.NumericUpDownOwner.Value = value;
        }
    }
}
