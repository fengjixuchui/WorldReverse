/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class CamAutoRotControlFlag // TypeDefIndex: 32107
{
	// Fields
	public bool isPlentySpace; // 0x10
	public bool isOppositeSqueezed; // 0x11
	public bool isAlmostGoToAvaTrace; // 0x12
	public bool isGoingToCrash; // 0x13
	public bool isOverElevLimit; // 0x14
	public bool isXConsistent; // 0x15
	public bool isYConsistent; // 0x16
	public double crashTime; // 0x18
	public double overElevTime; // 0x20
	public double deltaAngleBetweenTrace; // 0x28
	public Vector2d controlReduceRatio; // 0x30
	public const double REDUCE_MAX_RATIO = 1000; // Metadata: 0x00B13EEA
	public double NORMAL_RATIO; // 0x40
	public double REDUCE_0_RATIO; // 0x48
	public double REDUCE_1_RATIO; // 0x50
	public double REDUCE_2_RATIO; // 0x58
	public double REDUCE_CONDITION_CRASH_RATIO; // 0x60
	public double REDUCE_CONDITION_OEVR_ELEV_RATIO; // 0x68
	public double REDUCE_FAST_X; // 0x70
	public double REDUCE_FAST_Y; // 0x78
	public CurrentEvaluation curEvaluation; // 0x80

	// Nested types
	public enum CurrentEvaluation // TypeDefIndex: 32108
	{
		normal = 0,
		reduce0 = 1,
		reduce1 = 2,
		reduce2 = 3,
		StopSafe = 4,
		StopCheck = 5,
		StopWTF = 6
	}

	// Constructors
	public CamAutoRotControlFlag() {} // 0x0000000183394970-0x0000000183394A30

	// Methods
	// [XID] // 0x00000001899AD030-0x00000001899AD050
	public void ControlSpeedReduce() {} // 0x00000001833943C0-0x0000000183394480
	// [XID] // 0x00000001899B4870-0x00000001899B4890
	private void CurrentStateEvaluation() {} // 0x0000000183394770-0x0000000183394970
	// [XID] // 0x00000001899BBEE0-0x00000001899BBF00
	private void PredictEvaluation() {} // 0x0000000183394690-0x0000000183394770
	// [XID] // 0x00000001899C3A10-0x00000001899C3A30
	private void CorrelationEvaluation() {} // 0x0000000183394580-0x0000000183394690
	// [XID] // 0x00000001899CAFD0-0x00000001899CAFF0
	public void ClearControlState() {} // 0x0000000183394480-0x0000000183394580
	// [XID] // 0x00000001899D2560-0x00000001899D2580
	public void Copy(CamAutoRotControlFlag camAutoRot) {} // 0x00000001833942B0-0x00000001833943C0
}

