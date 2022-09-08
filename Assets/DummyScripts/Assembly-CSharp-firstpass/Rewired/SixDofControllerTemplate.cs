/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Rewired
{
	public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate // TypeDefIndex: 9824
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_positionX = 1; // Metadata: 0x00AE687C
		public const int elementId_positionY = 2; // Metadata: 0x00AE6880
		public const int elementId_positionZ = 0; // Metadata: 0x00AE6884
		public const int elementId_rotationX = 3; // Metadata: 0x00AE6888
		public const int elementId_rotationY = 5; // Metadata: 0x00AE688C
		public const int elementId_rotationZ = 4; // Metadata: 0x00AE6890
		public const int elementId_throttle1Axis = 6; // Metadata: 0x00AE6894
		public const int elementId_throttle1MinDetent = 50; // Metadata: 0x00AE6898
		public const int elementId_throttle2Axis = 7; // Metadata: 0x00AE689C
		public const int elementId_throttle2MinDetent = 51; // Metadata: 0x00AE68A0
		public const int elementId_extraAxis1 = 8; // Metadata: 0x00AE68A4
		public const int elementId_extraAxis2 = 9; // Metadata: 0x00AE68A8
		public const int elementId_extraAxis3 = 10; // Metadata: 0x00AE68AC
		public const int elementId_extraAxis4 = 11; // Metadata: 0x00AE68B0
		public const int elementId_button1 = 12; // Metadata: 0x00AE68B4
		public const int elementId_button2 = 13; // Metadata: 0x00AE68B8
		public const int elementId_button3 = 14; // Metadata: 0x00AE68BC
		public const int elementId_button4 = 15; // Metadata: 0x00AE68C0
		public const int elementId_button5 = 16; // Metadata: 0x00AE68C4
		public const int elementId_button6 = 17; // Metadata: 0x00AE68C8
		public const int elementId_button7 = 18; // Metadata: 0x00AE68CC
		public const int elementId_button8 = 19; // Metadata: 0x00AE68D0
		public const int elementId_button9 = 20; // Metadata: 0x00AE68D4
		public const int elementId_button10 = 21; // Metadata: 0x00AE68D8
		public const int elementId_button11 = 22; // Metadata: 0x00AE68DC
		public const int elementId_button12 = 23; // Metadata: 0x00AE68E0
		public const int elementId_button13 = 24; // Metadata: 0x00AE68E4
		public const int elementId_button14 = 25; // Metadata: 0x00AE68E8
		public const int elementId_button15 = 26; // Metadata: 0x00AE68EC
		public const int elementId_button16 = 27; // Metadata: 0x00AE68F0
		public const int elementId_button17 = 28; // Metadata: 0x00AE68F4
		public const int elementId_button18 = 29; // Metadata: 0x00AE68F8
		public const int elementId_button19 = 30; // Metadata: 0x00AE68FC
		public const int elementId_button20 = 31; // Metadata: 0x00AE6900
		public const int elementId_button21 = 55; // Metadata: 0x00AE6904
		public const int elementId_button22 = 56; // Metadata: 0x00AE6908
		public const int elementId_button23 = 57; // Metadata: 0x00AE690C
		public const int elementId_button24 = 58; // Metadata: 0x00AE6910
		public const int elementId_button25 = 59; // Metadata: 0x00AE6914
		public const int elementId_button26 = 60; // Metadata: 0x00AE6918
		public const int elementId_button27 = 61; // Metadata: 0x00AE691C
		public const int elementId_button28 = 62; // Metadata: 0x00AE6920
		public const int elementId_button29 = 63; // Metadata: 0x00AE6924
		public const int elementId_button30 = 64; // Metadata: 0x00AE6928
		public const int elementId_button31 = 65; // Metadata: 0x00AE692C
		public const int elementId_button32 = 66; // Metadata: 0x00AE6930
		public const int elementId_hat1Up = 32; // Metadata: 0x00AE6934
		public const int elementId_hat1UpRight = 33; // Metadata: 0x00AE6938
		public const int elementId_hat1Right = 34; // Metadata: 0x00AE693C
		public const int elementId_hat1DownRight = 35; // Metadata: 0x00AE6940
		public const int elementId_hat1Down = 36; // Metadata: 0x00AE6944
		public const int elementId_hat1DownLeft = 37; // Metadata: 0x00AE6948
		public const int elementId_hat1Left = 38; // Metadata: 0x00AE694C
		public const int elementId_hat1UpLeft = 39; // Metadata: 0x00AE6950
		public const int elementId_hat2Up = 40; // Metadata: 0x00AE6954
		public const int elementId_hat2UpRight = 41; // Metadata: 0x00AE6958
		public const int elementId_hat2Right = 42; // Metadata: 0x00AE695C
		public const int elementId_hat2DownRight = 43; // Metadata: 0x00AE6960
		public const int elementId_hat2Down = 44; // Metadata: 0x00AE6964
		public const int elementId_hat2DownLeft = 45; // Metadata: 0x00AE6968
		public const int elementId_hat2Left = 46; // Metadata: 0x00AE696C
		public const int elementId_hat2UpLeft = 47; // Metadata: 0x00AE6970
		public const int elementId_hat1 = 48; // Metadata: 0x00AE6974
		public const int elementId_hat2 = 49; // Metadata: 0x00AE6978
		public const int elementId_throttle1 = 52; // Metadata: 0x00AE697C
		public const int elementId_throttle2 = 53; // Metadata: 0x00AE6980
		public const int elementId_stick = 54; // Metadata: 0x00AE6984
	
		// Properties
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis1 { /* [XID] */ /* 0x0000000189B16E20-0x0000000189B16E40 */ get => default; } // 0x0000000187355F50-0x0000000187356000 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis2 { /* [XID] */ /* 0x0000000189B1E640-0x0000000189B1E660 */ get => default; } // 0x0000000187356000-0x00000001873560B0 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis3 { /* [XID] */ /* 0x0000000189B26030-0x0000000189B26050 */ get => default; } // 0x00000001873560B0-0x0000000187356160 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis4 { /* [XID] */ /* 0x0000000189B2D2E0-0x0000000189B2D300 */ get => default; } // 0x0000000187356160-0x0000000187356210 
		IControllerTemplateButton ISixDofControllerTemplate.button1 { /* [XID] */ /* 0x0000000189B34830-0x0000000189B34850 */ get => default; } // 0x0000000187355030-0x00000001873550E0 
		IControllerTemplateButton ISixDofControllerTemplate.button2 { /* [XID] */ /* 0x0000000189B3C070-0x0000000189B3C090 */ get => default; } // 0x00000001873557C0-0x0000000187355870 
		IControllerTemplateButton ISixDofControllerTemplate.button3 { /* [XID] */ /* 0x00000001899D7280-0x00000001899D72A0 */ get => default; } // 0x0000000187355A80-0x0000000187355B30 
		IControllerTemplateButton ISixDofControllerTemplate.button4 { /* [XID] */ /* 0x0000000189B4B240-0x0000000189B4B260 */ get => default; } // 0x0000000187355B30-0x0000000187355BE0 
		IControllerTemplateButton ISixDofControllerTemplate.button5 { /* [XID] */ /* 0x0000000189B52A90-0x0000000189B52AB0 */ get => default; } // 0x0000000187355BE0-0x0000000187355C90 
		IControllerTemplateButton ISixDofControllerTemplate.button6 { /* [XID] */ /* 0x0000000189B5A460-0x0000000189B5A480 */ get => default; } // 0x0000000187355C90-0x0000000187355D40 
		IControllerTemplateButton ISixDofControllerTemplate.button7 { /* [XID] */ /* 0x0000000189B618C0-0x0000000189B618E0 */ get => default; } // 0x0000000187355D40-0x0000000187355DF0 
		IControllerTemplateButton ISixDofControllerTemplate.button8 { /* [XID] */ /* 0x0000000189A33130-0x0000000189A33150 */ get => default; } // 0x0000000187355DF0-0x0000000187355EA0 
		IControllerTemplateButton ISixDofControllerTemplate.button9 { /* [XID] */ /* 0x0000000189B70970-0x0000000189B70990 */ get => default; } // 0x0000000187355EA0-0x0000000187355F50 
		IControllerTemplateButton ISixDofControllerTemplate.button10 { /* [XID] */ /* 0x0000000189B77F90-0x0000000189B77FB0 */ get => default; } // 0x0000000187354950-0x0000000187354A00 
		IControllerTemplateButton ISixDofControllerTemplate.button11 { /* [XID] */ /* 0x0000000189B7F4C0-0x0000000189B7F4E0 */ get => default; } // 0x0000000187354A00-0x0000000187354AB0 
		IControllerTemplateButton ISixDofControllerTemplate.button12 { /* [XID] */ /* 0x0000000189B870D0-0x0000000189B870F0 */ get => default; } // 0x0000000187354AB0-0x0000000187354B60 
		IControllerTemplateButton ISixDofControllerTemplate.button13 { /* [XID] */ /* 0x000000018960E540-0x000000018960E560 */ get => default; } // 0x0000000187354B60-0x0000000187354C10 
		IControllerTemplateButton ISixDofControllerTemplate.button14 { /* [XID] */ /* 0x00000001895F0560-0x00000001895F0580 */ get => default; } // 0x0000000187354C10-0x0000000187354CC0 
		IControllerTemplateButton ISixDofControllerTemplate.button15 { /* [XID] */ /* 0x00000001896D6480-0x00000001896D64A0 */ get => default; } // 0x0000000187354CC0-0x0000000187354D70 
		IControllerTemplateButton ISixDofControllerTemplate.button16 { /* [XID] */ /* 0x0000000189BA4410-0x0000000189BA4430 */ get => default; } // 0x0000000187354D70-0x0000000187354E20 
		IControllerTemplateButton ISixDofControllerTemplate.button17 { /* [XID] */ /* 0x0000000189BAB9D0-0x0000000189BAB9F0 */ get => default; } // 0x0000000187354E20-0x0000000187354ED0 
		IControllerTemplateButton ISixDofControllerTemplate.button18 { /* [XID] */ /* 0x0000000189BB2F00-0x0000000189BB2F20 */ get => default; } // 0x0000000187354ED0-0x0000000187354F80 
		IControllerTemplateButton ISixDofControllerTemplate.button19 { /* [XID] */ /* 0x0000000189BBA480-0x0000000189BBA4A0 */ get => default; } // 0x0000000187354F80-0x0000000187355030 
		IControllerTemplateButton ISixDofControllerTemplate.button20 { /* [XID] */ /* 0x0000000189967E60-0x0000000189967E80 */ get => default; } // 0x00000001873550E0-0x0000000187355190 
		IControllerTemplateButton ISixDofControllerTemplate.button21 { /* [XID] */ /* 0x000000018998D7C0-0x000000018998D7E0 */ get => default; } // 0x0000000187355190-0x0000000187355240 
		IControllerTemplateButton ISixDofControllerTemplate.button22 { /* [XID] */ /* 0x0000000189BD11D0-0x0000000189BD11F0 */ get => default; } // 0x0000000187355240-0x00000001873552F0 
		IControllerTemplateButton ISixDofControllerTemplate.button23 { /* [XID] */ /* 0x0000000189BD8850-0x0000000189BD8870 */ get => default; } // 0x00000001873552F0-0x00000001873553A0 
		IControllerTemplateButton ISixDofControllerTemplate.button24 { /* [XID] */ /* 0x0000000189BDFFF0-0x0000000189BE0010 */ get => default; } // 0x00000001873553A0-0x0000000187355450 
		IControllerTemplateButton ISixDofControllerTemplate.button25 { /* [XID] */ /* 0x00000001899B9440-0x00000001899B9460 */ get => default; } // 0x0000000187355450-0x0000000187355500 
		IControllerTemplateButton ISixDofControllerTemplate.button26 { /* [XID] */ /* 0x0000000189763C80-0x0000000189763CA0 */ get => default; } // 0x0000000187355500-0x00000001873555B0 
		IControllerTemplateButton ISixDofControllerTemplate.button27 { /* [XID] */ /* 0x00000001895FBC20-0x00000001895FBC40 */ get => default; } // 0x00000001873555B0-0x0000000187355660 
		IControllerTemplateButton ISixDofControllerTemplate.button28 { /* [XID] */ /* 0x00000001899B21C0-0x00000001899B21E0 */ get => default; } // 0x0000000187355660-0x0000000187355710 
		IControllerTemplateButton ISixDofControllerTemplate.button29 { /* [XID] */ /* 0x000000018960AF50-0x000000018960AF70 */ get => default; } // 0x0000000187355710-0x00000001873557C0 
		IControllerTemplateButton ISixDofControllerTemplate.button30 { /* [XID] */ /* 0x0000000189612330-0x0000000189612350 */ get => default; } // 0x0000000187355870-0x0000000187355920 
		IControllerTemplateButton ISixDofControllerTemplate.button31 { /* [XID] */ /* 0x00000001896CF220-0x00000001896CF240 */ get => default; } // 0x0000000187355920-0x00000001873559D0 
		IControllerTemplateButton ISixDofControllerTemplate.button32 { /* [XID] */ /* 0x0000000189621150-0x0000000189621170 */ get => default; } // 0x00000001873559D0-0x0000000187355A80 
		IControllerTemplateHat ISixDofControllerTemplate.hat1 { /* [XID] */ /* 0x000000018968C8C0-0x000000018968C8E0 */ get => default; } // 0x0000000187356210-0x00000001873562C0 
		IControllerTemplateHat ISixDofControllerTemplate.hat2 { /* [XID] */ /* 0x0000000189BC7030-0x0000000189BC7050 */ get => default; } // 0x00000001873562C0-0x0000000187356370 
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle1 { /* [XID] */ /* 0x0000000189637F70-0x0000000189637F90 */ get => default; } // 0x0000000187356420-0x00000001873564D0 
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle2 { /* [XID] */ /* 0x0000000189A66430-0x0000000189A66450 */ get => default; } // 0x00000001873564D0-0x0000000187356580 
		IControllerTemplateStick6D ISixDofControllerTemplate.stick { /* [XID] */ /* 0x00000001896469C0-0x00000001896469E0 */ get => default; } // 0x0000000187356370-0x0000000187356420 
	
		// Constructors
		public SixDofControllerTemplate() {} // Dummy constructor
		public SixDofControllerTemplate(object payload) {} // 0x0000000187356610-0x0000000187356690
		static SixDofControllerTemplate() {} // 0x0000000187356580-0x0000000187356610
	}
}
