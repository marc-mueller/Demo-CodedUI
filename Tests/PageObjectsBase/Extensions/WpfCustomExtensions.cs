using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace PageObjectsBase.Extensions
{
    public static class WpfCustomExtensions
    {
        public static void SetValue(this WpfControl ctrl, string value)
        {
            var ae = ctrl.NativeElement as AutomationElement;
            if(ae != null)
            {
                var supportedPatterns = ae.GetSupportedPatterns();

                object objValuePattern;
                if(ae.TryGetCurrentPattern(ValuePattern.Pattern, out objValuePattern))
                {
                    ((ValuePattern)objValuePattern).SetValue(value);
                }
                else
                {
                    throw new Exception("Cannot execute pattern!");
                }
            }
        }

        public static string GetValue(this WpfControl ctrl)
        {
            var ae = ctrl.NativeElement as AutomationElement;
            if (ae != null)
            {
                object objValuePattern;
                if (ae.TryGetCurrentPattern(ValuePattern.Pattern, out objValuePattern))
                {
                   return ((ValuePattern)objValuePattern).Current.Value;
                }
            }
            throw new Exception("Cannot read value from AutomationElement");
        }
    }
}
