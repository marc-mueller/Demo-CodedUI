﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

using System.Runtime.InteropServices;

namespace SimpleCalculatorWpf.UITests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// CloseApplication - Test Case 1
        /// </summary>
        public void CloseApplication()
        {
            #region Variable Declarations
            WpfButton uICloseButton = this.UISimpleCalculatorWindow.UISimpleCalculatorTitleBar.UICloseButton;
            #endregion

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(20, 6));
        }
        
        /// <summary>
        /// Enterfirstnumberintotheleftfield - Test Case 1 - Use 'EnterfirstnumberintotheleftfieldParams' to pass parameters into this method.
        /// </summary>
        public void Enterfirstnumberintotheleftfield()
        {
            #region Variable Declarations
            WpfEdit uIInputNumber1Edit = this.UISimpleCalculatorWindow.UIInputNumber1Edit;
            #endregion

            // Type '1' in 'InputNumber1' text box
            uIInputNumber1Edit.Text = this.EnterfirstnumberintotheleftfieldParams.UIInputNumber1EditText;
        }
        
        /// <summary>
        /// Entersecondnumberintotherightfield - Test Case 1 - Use 'EntersecondnumberintotherightfieldParams' to pass parameters into this method.
        /// </summary>
        public void Entersecondnumberintotherightfield()
        {
            #region Variable Declarations
            WpfEdit uIInputNumber2Edit = this.UISimpleCalculatorWindow.UIInputNumber2Edit;
            #endregion

            // Type '2' in 'InputNumber2' text box
            uIInputNumber2Edit.Text = this.EntersecondnumberintotherightfieldParams.UIInputNumber2EditText;
        }
        
        /// <summary>
        /// VerifyResult - Use 'VerifyResultExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyResult()
        {
            #region Variable Declarations
            WpfEdit uIResultingNumberEdit = this.UISimpleCalculatorWindow.UIResultingNumberEdit;
            #endregion

            // Verify that the 'Text' property of 'ResultingNumber' text box equals '3'
            Assert.AreEqual(this.VerifyResultExpectedValues.UIResultingNumberEditText, uIResultingNumberEdit.Text, "Result is wrong!");
        }
        
        /// <summary>
        /// PressAdd
        /// </summary>
        public void PressAdd()
        {
            #region Variable Declarations
            WpfButton uIAddNumbersButton = this.UISimpleCalculatorWindow.UIAddNumbersButton;
            #endregion

            // Click 'AddNumbers' button
            Mouse.Click(uIAddNumbersButton, new Point(11, 8));
        }
        
        #region Properties
        public virtual EnterfirstnumberintotheleftfieldParams EnterfirstnumberintotheleftfieldParams
        {
            get
            {
                if ((this.mEnterfirstnumberintotheleftfieldParams == null))
                {
                    this.mEnterfirstnumberintotheleftfieldParams = new EnterfirstnumberintotheleftfieldParams();
                }
                return this.mEnterfirstnumberintotheleftfieldParams;
            }
        }
        
        public virtual EntersecondnumberintotherightfieldParams EntersecondnumberintotherightfieldParams
        {
            get
            {
                if ((this.mEntersecondnumberintotherightfieldParams == null))
                {
                    this.mEntersecondnumberintotherightfieldParams = new EntersecondnumberintotherightfieldParams();
                }
                return this.mEntersecondnumberintotherightfieldParams;
            }
        }
        
        public virtual VerifyResultExpectedValues VerifyResultExpectedValues
        {
            get
            {
                if ((this.mVerifyResultExpectedValues == null))
                {
                    this.mVerifyResultExpectedValues = new VerifyResultExpectedValues();
                }
                return this.mVerifyResultExpectedValues;
            }
        }
        
        public UISimpleCalculatorWindow UISimpleCalculatorWindow
        {
            get
            {
                if ((this.mUISimpleCalculatorWindow == null))
                {
                    this.mUISimpleCalculatorWindow = new UISimpleCalculatorWindow();
                }
                return this.mUISimpleCalculatorWindow;
            }
        }
        #endregion
        
        #region Fields
        private EnterfirstnumberintotheleftfieldParams mEnterfirstnumberintotheleftfieldParams;
        
        private EntersecondnumberintotherightfieldParams mEntersecondnumberintotherightfieldParams;
        
        private VerifyResultExpectedValues mVerifyResultExpectedValues;
        
        private UISimpleCalculatorWindow mUISimpleCalculatorWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'Enterfirstnumberintotheleftfield'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class EnterfirstnumberintotheleftfieldParams
    {
        
        #region Fields
        /// <summary>
        /// Type '1' in 'InputNumber1' text box
        /// </summary>
        public string UIInputNumber1EditText = "1";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'Entersecondnumberintotherightfield'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class EntersecondnumberintotherightfieldParams
    {
        
        #region Fields
        /// <summary>
        /// Type '2' in 'InputNumber2' text box
        /// </summary>
        public string UIInputNumber2EditText = "2";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'VerifyResult'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class VerifyResultExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Text' property of 'ResultingNumber' text box equals '3'
        /// </summary>
        public string UIResultingNumberEditText = "3";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UISimpleCalculatorWindow : WpfWindow
    {
        
        public UISimpleCalculatorWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "Simple Calculator";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Simple Calculator");
            #endregion
        }
        
        #region Properties
        public WpfEdit UIInputNumber1Edit
        {
            get
            {
                if ((this.mUIInputNumber1Edit == null))
                {
                    this.mUIInputNumber1Edit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUIInputNumber1Edit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "SimpleCalculatorTxtFirstNumber";
                    this.mUIInputNumber1Edit.WindowTitles.Add("Simple Calculator");
                    #endregion
                }
                return this.mUIInputNumber1Edit;
            }
        }
        
        public WpfEdit UIInputNumber2Edit
        {
            get
            {
                if ((this.mUIInputNumber2Edit == null))
                {
                    this.mUIInputNumber2Edit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUIInputNumber2Edit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "SimpleCalculatorTxtSecondNumber";
                    this.mUIInputNumber2Edit.WindowTitles.Add("Simple Calculator");
                    #endregion
                }
                return this.mUIInputNumber2Edit;
            }
        }
        
        public WpfButton UIAddNumbersButton
        {
            get
            {
                if ((this.mUIAddNumbersButton == null))
                {
                    this.mUIAddNumbersButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIAddNumbersButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "SimpleCalculatorBtnAdd";
                    this.mUIAddNumbersButton.WindowTitles.Add("Simple Calculator");
                    #endregion
                }
                return this.mUIAddNumbersButton;
            }
        }
        
        public UISimpleCalculatorTitleBar UISimpleCalculatorTitleBar
        {
            get
            {
                if ((this.mUISimpleCalculatorTitleBar == null))
                {
                    this.mUISimpleCalculatorTitleBar = new UISimpleCalculatorTitleBar(this);
                }
                return this.mUISimpleCalculatorTitleBar;
            }
        }
        
        public WpfEdit UIResultingNumberEdit
        {
            get
            {
                if ((this.mUIResultingNumberEdit == null))
                {
                    this.mUIResultingNumberEdit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUIResultingNumberEdit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "SimpleCalculatorTxtResult";
                    this.mUIResultingNumberEdit.WindowTitles.Add("Simple Calculator");
                    #endregion
                }
                return this.mUIResultingNumberEdit;
            }
        }
        #endregion
        
        #region Fields
        private WpfEdit mUIInputNumber1Edit;
        
        private WpfEdit mUIInputNumber2Edit;
        
        private WpfButton mUIAddNumbersButton;
        
        private UISimpleCalculatorTitleBar mUISimpleCalculatorTitleBar;
        
        private WpfEdit mUIResultingNumberEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UISimpleCalculatorTitleBar : WpfTitleBar
    {
        
        public UISimpleCalculatorTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTitleBar.PropertyNames.AutomationId] = "TitleBar";
            this.WindowTitles.Add("Simple Calculator");
            #endregion
        }
        
        #region Properties
        public WpfButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "Close";
                    this.mUICloseButton.WindowTitles.Add("Simple Calculator");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUICloseButton;
        #endregion
    }

    
public static class BrowserWindowExtensions 


 
{ 


 
    [DllImport("user32.dll", SetLastError = true)] 




    [return: MarshalAs(UnmanagedType.Bool)] 




    internal static extern bool SetWindowPos(IntPtr hWnd, IntPtr hwndInsertAfter, int x, int y, int cx, int cy, uint uFlags); 


 
  


 
    public static void ResizeWindow(this BrowserWindow control , int width, int height) 


 
    { 




        //Call the native method to resize the window 




        SetWindowPos(control.WindowHandle ,(IntPtr)(-1), 0, 0, width, height, 0x0002 | 0x0040); 


    } 



} 

}
