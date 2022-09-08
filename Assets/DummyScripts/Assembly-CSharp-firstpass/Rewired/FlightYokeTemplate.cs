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
	public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate // TypeDefIndex: 9822
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_rotateYoke = 0; // Metadata: 0x00AE673C
		public const int elementId_yokeZ = 1; // Metadata: 0x00AE6740
		public const int elementId_leftPaddle = 59; // Metadata: 0x00AE6744
		public const int elementId_rightPaddle = 60; // Metadata: 0x00AE6748
		public const int elementId_lever1Axis = 2; // Metadata: 0x00AE674C
		public const int elementId_lever1MinDetent = 64; // Metadata: 0x00AE6750
		public const int elementId_lever2Axis = 3; // Metadata: 0x00AE6754
		public const int elementId_lever2MinDetent = 65; // Metadata: 0x00AE6758
		public const int elementId_lever3Axis = 4; // Metadata: 0x00AE675C
		public const int elementId_lever3MinDetent = 66; // Metadata: 0x00AE6760
		public const int elementId_lever4Axis = 5; // Metadata: 0x00AE6764
		public const int elementId_lever4MinDetent = 67; // Metadata: 0x00AE6768
		public const int elementId_lever5Axis = 6; // Metadata: 0x00AE676C
		public const int elementId_lever5MinDetent = 68; // Metadata: 0x00AE6770
		public const int elementId_leftGripButton1 = 7; // Metadata: 0x00AE6774
		public const int elementId_leftGripButton2 = 8; // Metadata: 0x00AE6778
		public const int elementId_leftGripButton3 = 9; // Metadata: 0x00AE677C
		public const int elementId_leftGripButton4 = 10; // Metadata: 0x00AE6780
		public const int elementId_leftGripButton5 = 11; // Metadata: 0x00AE6784
		public const int elementId_leftGripButton6 = 12; // Metadata: 0x00AE6788
		public const int elementId_rightGripButton1 = 13; // Metadata: 0x00AE678C
		public const int elementId_rightGripButton2 = 14; // Metadata: 0x00AE6790
		public const int elementId_rightGripButton3 = 15; // Metadata: 0x00AE6794
		public const int elementId_rightGripButton4 = 16; // Metadata: 0x00AE6798
		public const int elementId_rightGripButton5 = 17; // Metadata: 0x00AE679C
		public const int elementId_rightGripButton6 = 18; // Metadata: 0x00AE67A0
		public const int elementId_centerButton1 = 19; // Metadata: 0x00AE67A4
		public const int elementId_centerButton2 = 20; // Metadata: 0x00AE67A8
		public const int elementId_centerButton3 = 21; // Metadata: 0x00AE67AC
		public const int elementId_centerButton4 = 22; // Metadata: 0x00AE67B0
		public const int elementId_centerButton5 = 23; // Metadata: 0x00AE67B4
		public const int elementId_centerButton6 = 24; // Metadata: 0x00AE67B8
		public const int elementId_centerButton7 = 25; // Metadata: 0x00AE67BC
		public const int elementId_centerButton8 = 26; // Metadata: 0x00AE67C0
		public const int elementId_wheel1Up = 53; // Metadata: 0x00AE67C4
		public const int elementId_wheel1Down = 54; // Metadata: 0x00AE67C8
		public const int elementId_wheel1Press = 55; // Metadata: 0x00AE67CC
		public const int elementId_wheel2Up = 56; // Metadata: 0x00AE67D0
		public const int elementId_wheel2Down = 57; // Metadata: 0x00AE67D4
		public const int elementId_wheel2Press = 58; // Metadata: 0x00AE67D8
		public const int elementId_leftGripHatUp = 27; // Metadata: 0x00AE67DC
		public const int elementId_leftGripHatUpRight = 28; // Metadata: 0x00AE67E0
		public const int elementId_leftGripHatRight = 29; // Metadata: 0x00AE67E4
		public const int elementId_leftGripHatDownRight = 30; // Metadata: 0x00AE67E8
		public const int elementId_leftGripHatDown = 31; // Metadata: 0x00AE67EC
		public const int elementId_leftGripHatDownLeft = 32; // Metadata: 0x00AE67F0
		public const int elementId_leftGripHatLeft = 33; // Metadata: 0x00AE67F4
		public const int elementId_leftGripHatUpLeft = 34; // Metadata: 0x00AE67F8
		public const int elementId_rightGripHatUp = 35; // Metadata: 0x00AE67FC
		public const int elementId_rightGripHatUpRight = 36; // Metadata: 0x00AE6800
		public const int elementId_rightGripHatRight = 37; // Metadata: 0x00AE6804
		public const int elementId_rightGripHatDownRight = 38; // Metadata: 0x00AE6808
		public const int elementId_rightGripHatDown = 39; // Metadata: 0x00AE680C
		public const int elementId_rightGripHatDownLeft = 40; // Metadata: 0x00AE6810
		public const int elementId_rightGripHatLeft = 41; // Metadata: 0x00AE6814
		public const int elementId_rightGripHatUpLeft = 42; // Metadata: 0x00AE6818
		public const int elementId_consoleButton1 = 43; // Metadata: 0x00AE681C
		public const int elementId_consoleButton2 = 44; // Metadata: 0x00AE6820
		public const int elementId_consoleButton3 = 45; // Metadata: 0x00AE6824
		public const int elementId_consoleButton4 = 46; // Metadata: 0x00AE6828
		public const int elementId_consoleButton5 = 47; // Metadata: 0x00AE682C
		public const int elementId_consoleButton6 = 48; // Metadata: 0x00AE6830
		public const int elementId_consoleButton7 = 49; // Metadata: 0x00AE6834
		public const int elementId_consoleButton8 = 50; // Metadata: 0x00AE6838
		public const int elementId_consoleButton9 = 51; // Metadata: 0x00AE683C
		public const int elementId_consoleButton10 = 52; // Metadata: 0x00AE6840
		public const int elementId_mode1 = 61; // Metadata: 0x00AE6844
		public const int elementId_mode2 = 62; // Metadata: 0x00AE6848
		public const int elementId_mode3 = 63; // Metadata: 0x00AE684C
		public const int elementId_yoke = 69; // Metadata: 0x00AE6850
		public const int elementId_lever1 = 70; // Metadata: 0x00AE6854
		public const int elementId_lever2 = 71; // Metadata: 0x00AE6858
		public const int elementId_lever3 = 72; // Metadata: 0x00AE685C
		public const int elementId_lever4 = 73; // Metadata: 0x00AE6860
		public const int elementId_lever5 = 74; // Metadata: 0x00AE6864
		public const int elementId_leftGripHat = 75; // Metadata: 0x00AE6868
		public const int elementId_rightGripHat = 76; // Metadata: 0x00AE686C
	
		// Properties
		IControllerTemplateButton IFlightYokeTemplate.leftPaddle { /* [XID] */ /* 0x000000018984AF50-0x000000018984AF70 */ get => default; } // 0x000000018654FA80-0x000000018654FB30 
		IControllerTemplateButton IFlightYokeTemplate.rightPaddle { /* [XID] */ /* 0x00000001898521B0-0x00000001898521D0 */ get => default; } // 0x0000000186550580-0x0000000186550630 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton1 { /* [XID] */ /* 0x00000001895ED890-0x00000001895ED8B0 */ get => default; } // 0x000000018654F5B0-0x000000018654F660 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton2 { /* [XID] */ /* 0x00000001899A8620-0x00000001899A8640 */ get => default; } // 0x000000018654F660-0x000000018654F710 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton3 { /* [XID] */ /* 0x00000001899AFE10-0x00000001899AFE30 */ get => default; } // 0x000000018654F710-0x000000018654F7C0 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton4 { /* [XID] */ /* 0x00000001899B7230-0x00000001899B7250 */ get => default; } // 0x000000018654F7C0-0x000000018654F870 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton5 { /* [XID] */ /* 0x00000001897C9300-0x00000001897C9320 */ get => default; } // 0x000000018654F870-0x000000018654F920 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton6 { /* [XID] */ /* 0x00000001897D0930-0x00000001897D0950 */ get => default; } // 0x000000018654F920-0x000000018654F9D0 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton1 { /* [XID] */ /* 0x000000018967ED20-0x000000018967ED40 */ get => default; } // 0x00000001865500B0-0x0000000186550160 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton2 { /* [XID] */ /* 0x00000001899D5220-0x00000001899D5240 */ get => default; } // 0x0000000186550160-0x0000000186550210 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton3 { /* [XID] */ /* 0x0000000189B72B70-0x0000000189B72B90 */ get => default; } // 0x0000000186550210-0x00000001865502C0 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton4 { /* [XID] */ /* 0x00000001897C18B0-0x00000001897C18D0 */ get => default; } // 0x00000001865502C0-0x0000000186550370 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton5 { /* [XID] */ /* 0x00000001897D3780-0x00000001897D37A0 */ get => default; } // 0x0000000186550370-0x0000000186550420 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton6 { /* [XID] */ /* 0x00000001895F6C00-0x00000001895F6C20 */ get => default; } // 0x0000000186550420-0x00000001865504D0 
		IControllerTemplateButton IFlightYokeTemplate.centerButton1 { /* [XID] */ /* 0x00000001897CBD50-0x00000001897CBD70 */ get => default; } // 0x000000018654E950-0x000000018654EA00 
		IControllerTemplateButton IFlightYokeTemplate.centerButton2 { /* [XID] */ /* 0x0000000189A01AE0-0x0000000189A01B00 */ get => default; } // 0x000000018654EA00-0x000000018654EAB0 
		IControllerTemplateButton IFlightYokeTemplate.centerButton3 { /* [XID] */ /* 0x000000018960B8D0-0x000000018960B8F0 */ get => default; } // 0x000000018654EAB0-0x000000018654EB60 
		IControllerTemplateButton IFlightYokeTemplate.centerButton4 { /* [XID] */ /* 0x0000000189A10B30-0x0000000189A10B50 */ get => default; } // 0x000000018654EB60-0x000000018654EC10 
		IControllerTemplateButton IFlightYokeTemplate.centerButton5 { /* [XID] */ /* 0x0000000189A90AB0-0x0000000189A90AD0 */ get => default; } // 0x000000018654EC10-0x000000018654ECC0 
		IControllerTemplateButton IFlightYokeTemplate.centerButton6 { /* [XID] */ /* 0x0000000189A1F770-0x0000000189A1F790 */ get => default; } // 0x000000018654ECC0-0x000000018654ED70 
		IControllerTemplateButton IFlightYokeTemplate.centerButton7 { /* [XID] */ /* 0x000000018988B960-0x000000018988B980 */ get => default; } // 0x000000018654ED70-0x000000018654EE20 
		IControllerTemplateButton IFlightYokeTemplate.centerButton8 { /* [XID] */ /* 0x0000000189A2E230-0x0000000189A2E250 */ get => default; } // 0x000000018654EE20-0x000000018654EED0 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Up { /* [XID] */ /* 0x0000000189A35AE0-0x0000000189A35B00 */ get => default; } // 0x0000000186550790-0x0000000186550840 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Down { /* [XID] */ /* 0x0000000189A3D130-0x0000000189A3D150 */ get => default; } // 0x0000000186550630-0x00000001865506E0 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Press { /* [XID] */ /* 0x0000000189624910-0x0000000189624930 */ get => default; } // 0x00000001865506E0-0x0000000186550790 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Up { /* [XID] */ /* 0x0000000189615C00-0x0000000189615C20 */ get => default; } // 0x00000001865509A0-0x0000000186550A50 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Down { /* [XID] */ /* 0x0000000189A53810-0x0000000189A53830 */ get => default; } // 0x0000000186550840-0x00000001865508F0 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Press { /* [XID] */ /* 0x0000000189A5AFA0-0x0000000189A5AFC0 */ get => default; } // 0x00000001865508F0-0x00000001865509A0 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton1 { /* [XID] */ /* 0x0000000189A62780-0x0000000189A627A0 */ get => default; } // 0x000000018654EF80-0x000000018654F030 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton2 { /* [XID] */ /* 0x0000000189A6A5A0-0x0000000189A6A5C0 */ get => default; } // 0x000000018654F030-0x000000018654F0E0 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton3 { /* [XID] */ /* 0x0000000189A71970-0x0000000189A71990 */ get => default; } // 0x000000018654F0E0-0x000000018654F190 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton4 { /* [XID] */ /* 0x0000000189A79470-0x0000000189A79490 */ get => default; } // 0x000000018654F190-0x000000018654F240 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton5 { /* [XID] */ /* 0x0000000189A80C00-0x0000000189A80C20 */ get => default; } // 0x000000018654F240-0x000000018654F2F0 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton6 { /* [XID] */ /* 0x0000000189A885A0-0x0000000189A885C0 */ get => default; } // 0x000000018654F2F0-0x000000018654F3A0 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton7 { /* [XID] */ /* 0x00000001897535C0-0x00000001897535E0 */ get => default; } // 0x000000018654F3A0-0x000000018654F450 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton8 { /* [XID] */ /* 0x0000000189A976B0-0x0000000189A976D0 */ get => default; } // 0x000000018654F450-0x000000018654F500 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton9 { /* [XID] */ /* 0x0000000189934F30-0x0000000189934F50 */ get => default; } // 0x000000018654F500-0x000000018654F5B0 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton10 { /* [XID] */ /* 0x0000000189AA63E0-0x0000000189AA6400 */ get => default; } // 0x000000018654EED0-0x000000018654EF80 
		IControllerTemplateButton IFlightYokeTemplate.mode1 { /* [XID] */ /* 0x0000000189AAD9E0-0x0000000189AADA00 */ get => default; } // 0x000000018654FEA0-0x000000018654FF50 
		IControllerTemplateButton IFlightYokeTemplate.mode2 { /* [XID] */ /* 0x0000000189AB51B0-0x0000000189AB51D0 */ get => default; } // 0x000000018654FF50-0x0000000186550000 
		IControllerTemplateButton IFlightYokeTemplate.mode3 { /* [XID] */ /* 0x00000001898E2720-0x00000001898E2740 */ get => default; } // 0x0000000186550000-0x00000001865500B0 
		IControllerTemplateYoke IFlightYokeTemplate.yoke { /* [XID] */ /* 0x00000001897B6C40-0x00000001897B6C60 */ get => default; } // 0x0000000186550A50-0x0000000186550B00 
		IControllerTemplateThrottle IFlightYokeTemplate.lever1 { /* [XID] */ /* 0x000000018978EF80-0x000000018978EFA0 */ get => default; } // 0x000000018654FB30-0x000000018654FBE0 
		IControllerTemplateThrottle IFlightYokeTemplate.lever2 { /* [XID] */ /* 0x0000000189AD37F0-0x0000000189AD3810 */ get => default; } // 0x000000018654FBE0-0x000000018654FC90 
		IControllerTemplateThrottle IFlightYokeTemplate.lever3 { /* [XID] */ /* 0x0000000189ADB2D0-0x0000000189ADB2F0 */ get => default; } // 0x000000018654FC90-0x000000018654FD40 
		IControllerTemplateThrottle IFlightYokeTemplate.lever4 { /* [XID] */ /* 0x0000000189AE2B40-0x0000000189AE2B60 */ get => default; } // 0x000000018654FD40-0x000000018654FDF0 
		IControllerTemplateThrottle IFlightYokeTemplate.lever5 { /* [XID] */ /* 0x0000000189AEA5B0-0x0000000189AEA5D0 */ get => default; } // 0x000000018654FDF0-0x000000018654FEA0 
		IControllerTemplateHat IFlightYokeTemplate.leftGripHat { /* [XID] */ /* 0x0000000189AF1F90-0x0000000189AF1FB0 */ get => default; } // 0x000000018654F9D0-0x000000018654FA80 
		IControllerTemplateHat IFlightYokeTemplate.rightGripHat { /* [XID] */ /* 0x0000000189AF9980-0x0000000189AF99A0 */ get => default; } // 0x00000001865504D0-0x0000000186550580 
	
		// Constructors
		public FlightYokeTemplate() {} // Dummy constructor
		public FlightYokeTemplate(object payload) {} // 0x0000000186550B90-0x0000000186550C10
		static FlightYokeTemplate() {} // 0x0000000186550B00-0x0000000186550B90
	}
}
