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
	public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate // TypeDefIndex: 9819
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_leftStickX = 0; // Metadata: 0x00AE6348
		public const int elementId_leftStickY = 1; // Metadata: 0x00AE634C
		public const int elementId_rightStickX = 2; // Metadata: 0x00AE6350
		public const int elementId_rightStickY = 3; // Metadata: 0x00AE6354
		public const int elementId_actionBottomRow1 = 4; // Metadata: 0x00AE6358
		public const int elementId_a = 4; // Metadata: 0x00AE635C
		public const int elementId_actionBottomRow2 = 5; // Metadata: 0x00AE6360
		public const int elementId_b = 5; // Metadata: 0x00AE6364
		public const int elementId_actionBottomRow3 = 6; // Metadata: 0x00AE6368
		public const int elementId_c = 6; // Metadata: 0x00AE636C
		public const int elementId_actionTopRow1 = 7; // Metadata: 0x00AE6370
		public const int elementId_x = 7; // Metadata: 0x00AE6374
		public const int elementId_actionTopRow2 = 8; // Metadata: 0x00AE6378
		public const int elementId_y = 8; // Metadata: 0x00AE637C
		public const int elementId_actionTopRow3 = 9; // Metadata: 0x00AE6380
		public const int elementId_z = 9; // Metadata: 0x00AE6384
		public const int elementId_leftShoulder1 = 10; // Metadata: 0x00AE6388
		public const int elementId_leftBumper = 10; // Metadata: 0x00AE638C
		public const int elementId_leftShoulder2 = 11; // Metadata: 0x00AE6390
		public const int elementId_leftTrigger = 11; // Metadata: 0x00AE6394
		public const int elementId_rightShoulder1 = 12; // Metadata: 0x00AE6398
		public const int elementId_rightBumper = 12; // Metadata: 0x00AE639C
		public const int elementId_rightShoulder2 = 13; // Metadata: 0x00AE63A0
		public const int elementId_rightTrigger = 13; // Metadata: 0x00AE63A4
		public const int elementId_center1 = 14; // Metadata: 0x00AE63A8
		public const int elementId_back = 14; // Metadata: 0x00AE63AC
		public const int elementId_center2 = 15; // Metadata: 0x00AE63B0
		public const int elementId_start = 15; // Metadata: 0x00AE63B4
		public const int elementId_center3 = 16; // Metadata: 0x00AE63B8
		public const int elementId_guide = 16; // Metadata: 0x00AE63BC
		public const int elementId_leftStickButton = 17; // Metadata: 0x00AE63C0
		public const int elementId_rightStickButton = 18; // Metadata: 0x00AE63C4
		public const int elementId_dPadUp = 19; // Metadata: 0x00AE63C8
		public const int elementId_dPadRight = 20; // Metadata: 0x00AE63CC
		public const int elementId_dPadDown = 21; // Metadata: 0x00AE63D0
		public const int elementId_dPadLeft = 22; // Metadata: 0x00AE63D4
		public const int elementId_leftStick = 23; // Metadata: 0x00AE63D8
		public const int elementId_rightStick = 24; // Metadata: 0x00AE63DC
		public const int elementId_dPad = 25; // Metadata: 0x00AE63E0
	
		// Properties
		IControllerTemplateButton IGamepadTemplate.actionBottomRow1 { /* [XID] */ /* 0x0000000189AE8B90-0x0000000189AE8BB0 */ get => default; } // 0x0000000186553240-0x00000001865532F0 
		IControllerTemplateButton IGamepadTemplate.a { /* [XID] */ /* 0x0000000189AF09A0-0x0000000189AF09C0 */ get => default; } // 0x0000000186553190-0x0000000186553240 
		IControllerTemplateButton IGamepadTemplate.actionBottomRow2 { /* [XID] */ /* 0x0000000189918A90-0x0000000189918AB0 */ get => default; } // 0x00000001865532F0-0x00000001865533A0 
		IControllerTemplateButton IGamepadTemplate.b { /* [XID] */ /* 0x0000000189AFF5B0-0x0000000189AFF5D0 */ get => default; } // 0x0000000186553660-0x0000000186553710 
		IControllerTemplateButton IGamepadTemplate.actionBottomRow3 { /* [XID] */ /* 0x0000000189B06CC0-0x0000000189B06CE0 */ get => default; } // 0x00000001865533A0-0x0000000186553450 
		IControllerTemplateButton IGamepadTemplate.c { /* [XID] */ /* 0x00000001899D5CD0-0x00000001899D5CF0 */ get => default; } // 0x00000001865537C0-0x0000000186553870 
		IControllerTemplateButton IGamepadTemplate.actionTopRow1 { /* [XID] */ /* 0x0000000189B15690-0x0000000189B156B0 */ get => default; } // 0x0000000186553450-0x0000000186553500 
		IControllerTemplateButton IGamepadTemplate.x { /* [XID] */ /* 0x0000000189B1D130-0x0000000189B1D150 */ get => default; } // 0x0000000186554370-0x0000000186554420 
		IControllerTemplateButton IGamepadTemplate.actionTopRow2 { /* [XID] */ /* 0x00000001898F7910-0x00000001898F7930 */ get => default; } // 0x0000000186553500-0x00000001865535B0 
		IControllerTemplateButton IGamepadTemplate.y { /* [XID] */ /* 0x0000000189B2BB60-0x0000000189B2BB80 */ get => default; } // 0x0000000186554420-0x00000001865544D0 
		IControllerTemplateButton IGamepadTemplate.actionTopRow3 { /* [XID] */ /* 0x0000000189B33070-0x0000000189B33090 */ get => default; } // 0x00000001865535B0-0x0000000186553660 
		IControllerTemplateButton IGamepadTemplate.z { /* [XID] */ /* 0x0000000189B3AB90-0x0000000189B3ABB0 */ get => default; } // 0x00000001865544D0-0x0000000186554580 
		IControllerTemplateButton IGamepadTemplate.leftShoulder1 { /* [XID] */ /* 0x0000000189A15CA0-0x0000000189A15CC0 */ get => default; } // 0x0000000186553C90-0x0000000186553D40 
		IControllerTemplateButton IGamepadTemplate.leftBumper { /* [XID] */ /* 0x00000001896031C0-0x00000001896031E0 */ get => default; } // 0x0000000186553BE0-0x0000000186553C90 
		IControllerTemplateAxis IGamepadTemplate.leftShoulder2 { /* [XID] */ /* 0x0000000189B515A0-0x0000000189B515C0 */ get => default; } // 0x0000000186553D40-0x0000000186553DF0 
		IControllerTemplateAxis IGamepadTemplate.leftTrigger { /* [XID] */ /* 0x00000001895F4250-0x00000001895F4270 */ get => default; } // 0x0000000186553EA0-0x0000000186553F50 
		IControllerTemplateButton IGamepadTemplate.rightShoulder1 { /* [XID] */ /* 0x00000001898F19B0-0x00000001898F19D0 */ get => default; } // 0x0000000186554000-0x00000001865540B0 
		IControllerTemplateButton IGamepadTemplate.rightBumper { /* [XID] */ /* 0x0000000189B67D30-0x0000000189B67D50 */ get => default; } // 0x0000000186553F50-0x0000000186554000 
		IControllerTemplateAxis IGamepadTemplate.rightShoulder2 { /* [XID] */ /* 0x0000000189B6EFA0-0x0000000189B6EFC0 */ get => default; } // 0x00000001865540B0-0x0000000186554160 
		IControllerTemplateAxis IGamepadTemplate.rightTrigger { /* [XID] */ /* 0x0000000189B766E0-0x0000000189B76700 */ get => default; } // 0x0000000186554210-0x00000001865542C0 
		IControllerTemplateButton IGamepadTemplate.center1 { /* [XID] */ /* 0x0000000189B7DCA0-0x0000000189B7DCC0 */ get => default; } // 0x0000000186553870-0x0000000186553920 
		IControllerTemplateButton IGamepadTemplate.back { /* [XID] */ /* 0x0000000189B859A0-0x0000000189B859C0 */ get => default; } // 0x0000000186553710-0x00000001865537C0 
		IControllerTemplateButton IGamepadTemplate.center2 { /* [XID] */ /* 0x0000000189B8C870-0x0000000189B8C890 */ get => default; } // 0x0000000186553920-0x00000001865539D0 
		IControllerTemplateButton IGamepadTemplate.start { /* [XID] */ /* 0x0000000189B94120-0x0000000189B94140 */ get => default; } // 0x00000001865542C0-0x0000000186554370 
		IControllerTemplateButton IGamepadTemplate.center3 { /* [XID] */ /* 0x0000000189B9B7E0-0x0000000189B9B800 */ get => default; } // 0x00000001865539D0-0x0000000186553A80 
		IControllerTemplateButton IGamepadTemplate.guide { /* [XID] */ /* 0x0000000189BA2FB0-0x0000000189BA2FD0 */ get => default; } // 0x0000000186553B30-0x0000000186553BE0 
		IControllerTemplateThumbStick IGamepadTemplate.leftStick { /* [XID] */ /* 0x0000000189BAA2A0-0x0000000189BAA2C0 */ get => default; } // 0x0000000186553DF0-0x0000000186553EA0 
		IControllerTemplateThumbStick IGamepadTemplate.rightStick { /* [XID] */ /* 0x0000000189A7C300-0x0000000189A7C320 */ get => default; } // 0x0000000186554160-0x0000000186554210 
		IControllerTemplateDPad IGamepadTemplate.dPad { /* [XID] */ /* 0x0000000189BB8B20-0x0000000189BB8B40 */ get => default; } // 0x0000000186553A80-0x0000000186553B30 
	
		// Constructors
		public GamepadTemplate() {} // Dummy constructor
		public GamepadTemplate(object payload) {} // 0x0000000186554610-0x0000000186554690
		static GamepadTemplate() {} // 0x0000000186554580-0x0000000186554610
	}
}
