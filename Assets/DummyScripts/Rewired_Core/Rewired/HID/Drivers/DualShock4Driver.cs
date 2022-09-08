/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Drivers.Interfaces;
using Rewired.HID;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.HID.Drivers
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal class DualShock4Driver : HIDDeviceDriver, IDisposable, IDriver_DualShock4 // TypeDefIndex: 4036
	{
		// Fields
		private readonly bool IPmdjkAEMPygLJbnslqnNUFTGYEh; // 0x58
		private readonly int ZuJUdCsQtJchgnotWnEYnVMXpZe; // 0x5C
		private readonly int BNlvTZuaNEZiINaOUJRyylCWGluH; // 0x60
		private readonly bool PerPoXkTXfpOMQfRmGkfJQQHaoP; // 0x64
		private readonly byte IBtisnbbWWhGYoIFHfsNUGxPeeLX; // 0x65
		private readonly int IHXNCBnWSZMiTkqhXGCjTYcVeXV; // 0x68
		private readonly int uMlElWUrgbAIiKkrXJRnPAvpqytV; // 0x6C
		private readonly int UKQIuyGITJLNlkJdHGiQDgySzqS; // 0x70
		private readonly int EqJUUgTPAMPnpzGTWoBKqTxaUEy; // 0x74
		private readonly int LNhGgNDPZPxNQoVvjFRWNyRKYYRm; // 0x78
		private readonly int lqaAMJIZSHTFOORbtbjXnblDwbb; // 0x7C
		private readonly NativeBuffer kBUmUcAyFhoFeddZhyvELUyrNQP; // 0x80
		private readonly NativeBuffer xQtqlAYhQUqbOGYibktAZaYeTPW; // 0x88
		private readonly OutputReport wDqsBPZBSKtSLRDQNHWwaHOApvg; // 0x90
		private readonly Func<OutputReport, bool> KoLbpdtSgwWZhTuekQfZVolIbnZ; // 0xB0
		private readonly Action<OutputReport> beVWMbKDuyboNeDypPMnahQkenTj; // 0xB8
		private bool nMRHwDHVkyhFMsbxVAyMIhvJflG; // 0xC0
		private bool zTheBZCijedqOOizslwtClyldJc; // 0xC1
		private float EHhmtnRpZFDWxBhVxCnDiVSQCODb; // 0xC4
		private byte mhKlLLqqMAKyZlptFRQvuxlqHUM; // 0xC8
		private Quaternion BqzyKqeMRqWdVzqIGDtBAZJqmAW; // 0xCC
		private ushort ofrjjRPapttBAlbDWLilShKwGHj; // 0xDC
		private float DDCLILznEmjHXRNGlShJQmgUAjo; // 0xE0
		private float ZyMzwUpLeqFNyNWsSptXYJmqUTp; // 0xE4
		private float czatfHRzqfCSyRnqBZwBRVKyPLf; // 0xE8
		private byte YFQNDSyDOKaQqFCDUMVSsqUKNcks; // 0xEC
		private byte razBnFUPWcgkvONpWLoHwSoEgea; // 0xED
		private Quaternion RwqCCllDmvDcaeupJLChTYgRdhLT; // 0xF0
		private bool IAVhrwZXyddpahAmYQQWnhnCQyR; // 0x100
		private int TzJfvFzrmRpepYoNHgNTYZIRTkP; // 0x104
		private int[] ZpXAlFZqpXnApjyTRbLgLCEZsh; // 0x108
		private int[] eVCzMVdIwbBgoceyyoIcZaFUlHuH; // 0x110
	
		// Properties
		private bool isVibrating { get => default; } // 0x0000000185827BD0-0x0000000185827D20 
		public float LeftMotor { set {} } // 0x00000001858287D0-0x0000000185828880
		public float RightMotor { set {} } // 0x0000000185828C80-0x0000000185828D30
		public float LightColorR { set {} } // 0x00000001858289E0-0x0000000185828A90
		public float LightColorG { set {} } // 0x0000000185828930-0x00000001858289E0
		public float LightColorB { set {} } // 0x0000000185828880-0x0000000185828930
		public float LightFlashOnDuration { set {} } // 0x0000000185828B90-0x0000000185828C80
		public float LightFlashOffDuration { set {} } // 0x0000000185828A90-0x0000000185828B90
		public Vector3 AccelerometerValue { get => default; } // 0x0000000185827700-0x00000001858277C0 
		public Quaternion Orientation { get => default; } // 0x0000000185827810-0x0000000185827880 
		public int MaxTouches { get => default; } // 0x00000001858277C0-0x0000000185827810 
	
		// Nested types
		private enum OIJTHJtnXdTuDYmTeTRraFfLFEWg // TypeDefIndex: 4037
		{
			TCGihQKDgeeGtvEXifcuojmabzj = 0,
			nHExoOJHSKhwzDejIGfajTEJGjw = 1,
			HsdTpmcCbyhcpteKCHBHGDBMpxWc = 2
		}
	
		// Constructors
		public DualShock4Driver() {} // Dummy constructor
		public DualShock4Driver(InitArgs initArgs) {} // 0x00000001858254C0-0x0000000185826B70
	
		// Methods
		public void ResetOrientation() {} // 0x00000001858248E0-0x0000000185824970
		public bool IsTouchingAtIndex(int index) => default; // 0x0000000185824060-0x0000000185824130
		public bool IsTouchingAtTouchId(int touchId) => default; // 0x0000000185824130-0x00000001858241E0
		public int GetTouchIdAtIndex(int index) => default; // 0x0000000185823E00-0x0000000185823F00
		public bool GetTouchPositionByIndex(int index, out Vector2 position) {
			position = default;
			return default;
		} // 0x0000000185823F00-0x0000000185824060
		public void StopLightFlash() {} // 0x0000000185824970-0x00000001858249E0
		public void StopVibration() {} // 0x00000001858249E0-0x0000000185824B10
		public override void Update(UpdateLoopType updateLoop) {} // 0x0000000185824E50-0x0000000185824EC0
		public override bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, float timestamp) => default; // 0x00000001858245C0-0x0000000185824880
		public override Controller.Extension CreateControllerExtension() => default; // 0x0000000185823B20-0x0000000185823BA0
		private void mhIXIkSvdPJvbpqArtnvHhRDBxw(UNPjxDoysgcOYEVoxVPcTxAqJcM param_0000864c) {} // 0x0000000185828720-0x00000001858287D0
		private bool ACsIgxEitXcAKXzTiBHLxHBNdSep(UNPjxDoysgcOYEVoxVPcTxAqJcM param_0000864d) => default; // 0x0000000185823830-0x00000001858238E0
		private void lIqLuvZbhVpBcfGmWiwKUvgnIba() {} // 0x0000000185827D20-0x0000000185828720
		private bool WkEAduGURWkiggCMBLveDEjiPugA(UNPjxDoysgcOYEVoxVPcTxAqJcM param_0000864e) => default; // 0x0000000185824F30-0x00000001858250D0
		private void bWqXMuWKIQJCfsxGeWCQkichWXy(NativeBuffer param_0000864f, float param_00008650) {} // 0x0000000185826B70-0x00000001858273C0
		private void TncRWDNnjIHJtHMNjIvXiptqHAB(HIDControllerElement[] param_00008651, NativeBuffer param_00008652, float param_00008653) {} // 0x0000000185824B10-0x0000000185824C20
		private void dJnLHrLkCrXvnwufhwWcVWfBtmx() {} // 0x00000001858273C0-0x0000000185827460
		private void uSSbnKXlVwCkvZlpkaSWdkYPLpZT(NativeBuffer param_00008654) {} // 0x0000000185829240-0x0000000185829360
		private void yxHKHUtasBIuQNNoZTPMjWeyAgQ() {} // 0x00000001858294A0-0x0000000185829B90
		private void tqhIKiigFbbAwQxmgOhWpaWsfxf(Vector3 param_00008655, Vector3 param_00008656) {} // 0x0000000185828D30-0x0000000185829240
		private Quaternion dhagaeodIeCaZTtNzbkTBVAXLGmW(Vector3 param_00008657, float param_00008658 = 0f /* Metadata: 0x00AC4881 */) => default; // 0x0000000185827460-0x0000000185827620
		private Quaternion giFUJOwViBqcokLnxDtGTORTDnt(Vector3 param_00008659, float param_0000865a = 0f /* Metadata: 0x00AC4885 */) => default; // 0x00000001858279A0-0x0000000185827BD0
		private bool CAWknWkhOtRGqsjMKOSuNHBkteW(Vector3 param_0000865b, out OIJTHJtnXdTuDYmTeTRraFfLFEWg param_0000865c) {
			param_0000865c = default;
			return default;
		} // 0x00000001858238E0-0x0000000185823B20
		private bool gUZQrjUyUNwVzdxmlKQnZLHvaiO(Vector3 param_0000865d) => default; // 0x0000000185827620-0x0000000185827700
		private bool ZmjKlswgeasNwBPycJzTEriYeEK(Vector3 param_0000865e) => default; // 0x00000001858250D0-0x0000000185825120
		private Vector3 gfIksWBUPneTPwaSnJsaSgelRIB(float[] param_0000865f) => default; // 0x0000000185827880-0x00000001858279A0
		private Vector3 wtISYhCRCzycHFisAlOtNIIrXDR(Vector3 param_00008660, float param_00008661) => default; // 0x0000000185829360-0x00000001858294A0
		private int OZVJCHVuQRDHwhJESGzfdPGcpPXg(int param_00008662) => default; // 0x0000000185824560-0x00000001858245C0
		private void KfnWFiyMnJFYWBOoIDDEkithkDJ(byte[] param_00008663, float[] param_00008664) {} // 0x00000001858241E0-0x0000000185824310
		private void NsoYwvXAMxiVoPSgaWbJtBxNaEa(byte[] param_00008665, float[] param_00008666) {} // 0x00000001858243A0-0x0000000185824560
		private float WVxFGFNrZebWrUluTTeeuhuHwIx() => default; // 0x0000000185824EC0-0x0000000185824F30
		private void ZpfLGLPckdPLWXJSNJGEhpuQEck(NativeBuffer param_00008667, HIDTouchpad.TouchData[] param_00008668) {} // 0x0000000185825120-0x00000001858254C0
		private int TwMutOTYkuWuVJqwVUrCsHRCESI(int param_00008669, bool param_0000866a, int param_0000866b) => default; // 0x0000000185824C20-0x0000000185824E50
		private void QuUBefhkJoFCpSvXPRjpEsdcMJcg() {} // 0x0000000185824880-0x00000001858248E0
		~DualShock4Driver() {} // 0x0000000185823D50-0x0000000185823E00
		protected override void Dispose(bool disposing) {} // 0x0000000185823BA0-0x0000000185823D50
		public static bool Matches(int vid, int pid) => default; // 0x0000000185824310-0x00000001858243A0
	}
}
