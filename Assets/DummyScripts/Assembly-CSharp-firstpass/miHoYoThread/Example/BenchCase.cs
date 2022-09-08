/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread.Example
{
	public class BenchCase // TypeDefIndex: 9017
	{
		// Fields
		private const int FOO_CNT_SHORT = 40000; // Metadata: 0x00AE5081
		private const int FOO_CNT_LONG = 400000; // Metadata: 0x00AE5085
		private const int FOO_PHYSICS_SHORT = 10000; // Metadata: 0x00AE5089
		private const int FOO_PHYSICS_LONG = 20000; // Metadata: 0x00AE508D
		private CaseDelegate _A_0Delegate; // 0x10
		private IntPtr _A_0Ptr; // 0x18
		private CaseDelegate _B_0Delegate; // 0x20
		private IntPtr _B_0Ptr; // 0x28
		private CaseDelegate _C_0Delegate; // 0x30
		private IntPtr _C_0Ptr; // 0x38
		private CaseDelegate _A_1Delegate; // 0x40
		private IntPtr _A_1Ptr; // 0x48
		private CaseDelegate _B_1Delegate; // 0x50
		private IntPtr _B_1Ptr; // 0x58
		private CaseDelegate _C_1Delegate; // 0x60
		private IntPtr _C_1Ptr; // 0x68
		private CaseDelegate _D_1Delegate; // 0x70
		private IntPtr _D_1Ptr; // 0x78
		private CaseDelegate _A_2Delegate; // 0x80
		private IntPtr _A_2Ptr; // 0x88
		private CaseDelegate _B_2Delegate; // 0x90
		private IntPtr _B_2Ptr; // 0x98
		private CaseDelegate _C_2Delegate; // 0xA0
		private IntPtr _C_2Ptr; // 0xA8
		private CaseDelegate _D_2Delegate; // 0xB0
		private IntPtr _D_2Ptr; // 0xB8
		private CaseDelegate _E_2Delegate; // 0xC0
		private IntPtr _E_2Ptr; // 0xC8
		private CaseDelegate _A_3Delegate; // 0xD0
		private IntPtr _A_3Ptr; // 0xD8
		private CaseDelegate _B_3Delegate; // 0xE0
		private IntPtr _B_3Ptr; // 0xE8
		private CaseDelegate _C_3Delegate; // 0xF0
		private IntPtr _C_3Ptr; // 0xF8
		private CaseDelegate _D_3Delegate; // 0x100
		private IntPtr _D_3Ptr; // 0x108
		private CaseDelegate _E_3Delegate; // 0x110
		private IntPtr _E_3Ptr; // 0x118
		private CaseDelegate _F_3Delegate; // 0x120
		private IntPtr _F_3Ptr; // 0x128
		private CaseDelegate _G_3Delegate; // 0x130
		private IntPtr _G_3Ptr; // 0x138
	
		// Nested types
		public enum CASE // TypeDefIndex: 9018
		{
			NO_DEPENDENCY = 0,
			SIMPLE_DEPENDENCTY = 1,
			OVER_LAY_SAME = 2,
			OVER_LAY_SAME_REVERSE = 3,
			OVER_LAY_WITH_LONG = 4,
			OVER_LAY_WITH_LONG_REVERSE = 5,
			MULTI_WAIT = 6
		}
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void CaseDelegate(int index); // TypeDefIndex: 9019; 0x0000000187251CE0-0x0000000187251E70
	
		// Constructors
		public BenchCase() {} // 0x0000000187251B70-0x0000000187251BD0
	
		// Methods
		// [XID] // 0x0000000189B4E490-0x0000000189B4E4B0
		public static int ScheduleJob(IntPtr executeHandler, string profileName, int nodeIndex, JobPriority jobPriority, int depend) => default; // 0x0000000187250790-0x00000001872508B0
		// [XID] // 0x0000000189B55AE0-0x0000000189B55B00
		private static int Foo(int cnt) => default; // 0x000000018724EBA0-0x000000018724EC50
		// [XID] // 0x0000000189B5D520-0x0000000189B5D540
		private static void FooPhysics(int cnt) {} // 0x000000018724E980-0x000000018724EBA0
		// [XID] // 0x0000000189B6EDF0-0x0000000189B6EE10
		public void Init(CASE ct) {} // 0x0000000187250660-0x0000000187250790
		// [XID] // 0x0000000189B6C090-0x0000000189B6C0B0
		public void Clear(CASE ct) {} // 0x000000018724E850-0x000000018724E980
		// [XID] // 0x0000000189B738D0-0x0000000189B738F0
		public int[] Schedule(CASE ct) => default; // 0x00000001872508B0-0x00000001872509F0
		// [MonoPInvokeCallback] // 0x0000000189B7ADE0-0x0000000189B7AE40
		// [XID] // 0x0000000189B7ADE0-0x0000000189B7AE40
		private static void CallbackFunctionA_0(int index) {} // 0x000000018724CDE0-0x000000018724CF00
		// [MonoPInvokeCallback] // 0x0000000189B89E90-0x0000000189B89F00
		// [XID] // 0x0000000189B89E90-0x0000000189B89F00
		private static void CallbackFunctionB_0(int index) {} // 0x000000018724D270-0x000000018724D310
		// [MonoPInvokeCallback] // 0x0000000189B98800-0x0000000189B98870
		// [XID] // 0x0000000189B98800-0x0000000189B98870
		private static void CallbackFunctionC_0(int index) {} // 0x000000018724D570-0x000000018724D6A0
		// [XID] // 0x000000018983CD90-0x000000018983CDB0
		private void InitNoDependency() {} // 0x000000018724F180-0x000000018724F3F0
		// [XID] // 0x0000000189B51E20-0x0000000189B51E40
		private void ClearNoDependency() {} // 0x000000018724E360-0x000000018724E410
		// [XID] // 0x0000000189BB5EB0-0x0000000189BB5ED0
		private int[] StartNoDependency() => default; // 0x0000000187250D00-0x0000000187250EA0
		// [MonoPInvokeCallback] // 0x0000000189BBD4F0-0x0000000189BBD560
		// [XID] // 0x0000000189BBD4F0-0x0000000189BBD560
		private static void CallbackFunctionA_1(int index) {} // 0x000000018724CF00-0x000000018724D020
		// [MonoPInvokeCallback] // 0x0000000189BCCC80-0x0000000189BCCCE0
		// [XID] // 0x0000000189BCCC80-0x0000000189BCCCE0
		private static void CallbackFunctionB_1(int index) {} // 0x000000018724D310-0x000000018724D3B0
		// [MonoPInvokeCallback] // 0x0000000189BDBCA0-0x0000000189BDBD00
		// [XID] // 0x0000000189BDBCA0-0x0000000189BDBD00
		private static void CallbackFunctionC_1(int index) {} // 0x000000018724D6A0-0x000000018724D7D0
		// [MonoPInvokeCallback] // 0x00000001895EFDA0-0x00000001895EFE10
		// [XID] // 0x00000001895EFDA0-0x00000001895EFE10
		private static void CallbackFunctionD_1(int index) {} // 0x000000018724DA20-0x000000018724DB50
		// [XID] // 0x00000001895FEAF0-0x00000001895FEB10
		private void InitSimpleDependency() {} // 0x0000000187250350-0x0000000187250660
		// [XID] // 0x00000001896064D0-0x00000001896064F0
		private void ClearSimpleDependency() {} // 0x000000018724E790-0x000000018724E850
		// [XID] // 0x000000018960DE90-0x000000018960DEB0
		private int[] StartSimpleDependency() => default; // 0x0000000187251960-0x0000000187251B70
		// [MonoPInvokeCallback] // 0x00000001896154B0-0x0000000189615520
		// [XID] // 0x00000001896154B0-0x0000000189615520
		private static void CallbackFunctionA_2(int index) {} // 0x000000018724D020-0x000000018724D140
		// [MonoPInvokeCallback] // 0x0000000189624100-0x0000000189624160
		// [XID] // 0x0000000189624100-0x0000000189624160
		private static void CallbackFunctionB_2(int index) {} // 0x000000018724D3B0-0x000000018724D450
		// [MonoPInvokeCallback] // 0x0000000189633340-0x00000001896333A0
		// [XID] // 0x0000000189633340-0x00000001896333A0
		private static void CallbackFunctionC_2(int index) {} // 0x000000018724D7D0-0x000000018724D900
		// [MonoPInvokeCallback] // 0x0000000189642310-0x0000000189642380
		// [XID] // 0x0000000189642310-0x0000000189642380
		private static void CallbackFunctionD_2(int index) {} // 0x000000018724DB50-0x000000018724DC80
		// [MonoPInvokeCallback] // 0x0000000189651180-0x00000001896511F0
		// [XID] // 0x0000000189651180-0x00000001896511F0
		private static void CallbackFunctionE_2(int index) {} // 0x000000018724DDA0-0x000000018724DED0
		// [XID] // 0x000000018965FFF0-0x0000000189660010
		private void InitOverLaySameDependency() {} // 0x000000018724FBD0-0x000000018724FF90
		// [XID] // 0x0000000189667AD0-0x0000000189667AF0
		private void ClearOverLaySameDependency() {} // 0x000000018724E5D0-0x000000018724E6B0
		// [XID] // 0x000000018966F2A0-0x000000018966F2C0
		private int[] StartOverLaySameDependency() => default; // 0x0000000187251400-0x00000001872516B0
		// [XID] // 0x0000000189676D90-0x0000000189676DB0
		private void InitOverLaySameReverseDependency() {} // 0x000000018724FF90-0x0000000187250350
		// [XID] // 0x0000000189673000-0x0000000189673020
		private void ClearOverLaySameReverseDependency() {} // 0x000000018724E6B0-0x000000018724E790
		// [XID] // 0x0000000189685CD0-0x0000000189685CF0
		private int[] StartOverLaySameReverseDependency() => default; // 0x00000001872516B0-0x0000000187251960
		// [MonoPInvokeCallback] // 0x000000018968D690-0x000000018968D700
		// [XID] // 0x000000018968D690-0x000000018968D700
		private static void CallbackFunctionA_3(int index) {} // 0x000000018724D140-0x000000018724D270
		// [MonoPInvokeCallback] // 0x000000018969C8F0-0x000000018969C960
		// [XID] // 0x000000018969C8F0-0x000000018969C960
		private static void CallbackFunctionB_3(int index) {} // 0x000000018724D450-0x000000018724D570
		// [MonoPInvokeCallback] // 0x00000001896AB240-0x00000001896AB2B0
		// [XID] // 0x00000001896AB240-0x00000001896AB2B0
		private static void CallbackFunctionC_3(int index) {} // 0x000000018724D900-0x000000018724DA20
		// [MonoPInvokeCallback] // 0x00000001896B9D00-0x00000001896B9D70
		// [XID] // 0x00000001896B9D00-0x00000001896B9D70
		private static void CallbackFunctionD_3(int index) {} // 0x000000018724DC80-0x000000018724DDA0
		// [MonoPInvokeCallback] // 0x00000001896C8680-0x00000001896C86F0
		// [XID] // 0x00000001896C8680-0x00000001896C86F0
		private static void CallbackFunctionE_3(int index) {} // 0x000000018724DED0-0x000000018724E000
		// [MonoPInvokeCallback] // 0x00000001896D7460-0x00000001896D74C0
		// [XID] // 0x00000001896D7460-0x00000001896D74C0
		private static void CallbackFunctionF_3(int index) {} // 0x000000018724E000-0x000000018724E130
		// [MonoPInvokeCallback] // 0x00000001896E5FB0-0x00000001896E6020
		// [XID] // 0x00000001896E5FB0-0x00000001896E6020
		private static void CallbackFunctionG_3(int index) {} // 0x000000018724E130-0x000000018724E260
		// [XID] // 0x00000001899FFE20-0x00000001899FFE40
		private void InitOverLayLongCastDependency() {} // 0x000000018724F3F0-0x000000018724F7E0
		// [XID] // 0x0000000189B68690-0x0000000189B686B0
		private void ClearOverLayLongCastDependency() {} // 0x000000018724E410-0x000000018724E4F0
		// [XID] // 0x0000000189703C00-0x0000000189703C20
		private int[] StartOverLayLongCastDependency() => default; // 0x0000000187250EA0-0x0000000187251150
		// [XID] // 0x000000018996B2B0-0x000000018996B2D0
		private void InitOverLayLongCastReverseDependency() {} // 0x000000018724F7E0-0x000000018724FBD0
		// [XID] // 0x0000000189712BB0-0x0000000189712BD0
		private void ClearOverLayLongCastReverseDependency() {} // 0x000000018724E4F0-0x000000018724E5D0
		// [XID] // 0x00000001899F9E10-0x00000001899F9E30
		private int[] StartOverLayLongCastReverseDependency() => default; // 0x0000000187251150-0x0000000187251400
		// [XID] // 0x000000018993F980-0x000000018993F9A0
		private void InitMultiDependency() {} // 0x000000018724EC50-0x000000018724F180
		// [XID] // 0x0000000189B949D0-0x0000000189B949F0
		private void ClearMultiDependency() {} // 0x000000018724E260-0x000000018724E360
		// [XID] // 0x0000000189730870-0x0000000189730890
		private int[] StartMultiDependency() => default; // 0x00000001872509F0-0x0000000187250D00
	}
}
