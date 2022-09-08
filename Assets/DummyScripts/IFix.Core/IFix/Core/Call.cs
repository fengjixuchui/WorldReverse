/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;

// Image 45: IFix.Core.dll - Assembly: IFix.Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5033-5067

namespace IFix.Core
{
	public struct Call // TypeDefIndex: 5061
	{
		// Fields
		internal unsafe Value* argumentBase; // 0x00
		internal unsafe Value* evaluationStackBase; // 0x08
		internal object[] managedStack; // 0x10
		internal unsafe Value* currentTop; // 0x18
		internal unsafe Value** topWriteBack; // 0x20
	
		// Methods
		public static Call Begin() => default; // 0x00000001894100B0-0x0000000189410260
		public void PushBoolean(bool b) {} // 0x0000000189410BE0-0x0000000189410C70
		public bool GetBoolean(int offset = 0 /* Metadata: 0x00ADAA5C */) => default; // 0x0000000189410260-0x00000001894102F0
		public void PushByte(byte b) {} // 0x0000000189410C70-0x0000000189410D00
		public byte GetByte(int offset = 0 /* Metadata: 0x00ADAA60 */) => default; // 0x00000001894102F0-0x0000000189410380
		public void PushSByte(sbyte sb) {} // 0x0000000189411460-0x0000000189411530
		public sbyte GetSByte(int offset = 0 /* Metadata: 0x00ADAA64 */) => default; // 0x00000001894108A0-0x0000000189410960
		public void PushInt16(short s) {} // 0x0000000189410E60-0x0000000189410F30
		public short GetInt16(int offset = 0 /* Metadata: 0x00ADAA68 */) => default; // 0x00000001894104D0-0x0000000189410580
		public void PushChar(char c) {} // 0x0000000189410D00-0x0000000189410DD0
		public char GetChar(int offset = 0 /* Metadata: 0x00ADAA6C */) => default; // 0x0000000189410380-0x0000000189410440
		public void PushUInt16(ushort us) {} // 0x00000001894115C0-0x0000000189411640
		public ushort GetUInt16(int offset = 0 /* Metadata: 0x00ADAA70 */) => default; // 0x00000001894109F0-0x0000000189410A80
		public void PushInt32(int i) {} // 0x0000000189410F30-0x0000000189411000
		public int GetInt32(int offset = 0 /* Metadata: 0x00ADAA74 */) => default; // 0x0000000189410580-0x0000000189410630
		public void PushUInt32(uint ui) {} // 0x0000000189411640-0x00000001894116D0
		public uint GetUInt32(int offset = 0 /* Metadata: 0x00ADAA78 */) => default; // 0x0000000189410A80-0x0000000189410B10
		public void PushInt64(long i) {} // 0x0000000189411000-0x0000000189411090
		public long GetInt64(int offset = 0 /* Metadata: 0x00ADAA7C */) => default; // 0x0000000189410630-0x00000001894106D0
		public void PushUInt64(ulong i) {} // 0x00000001894116D0-0x0000000189411840
		public ulong GetUInt64(int offset = 0 /* Metadata: 0x00ADAA80 */) => default; // 0x0000000189410B10-0x0000000189410BE0
		public void PushSingle(float f) {} // 0x0000000189411530-0x00000001894115C0
		public float GetSingle(int offset = 0 /* Metadata: 0x00ADAA84 */) => default; // 0x0000000189410960-0x00000001894109F0
		public void PushDouble(double d) {} // 0x0000000189410DD0-0x0000000189410E60
		public double GetDouble(int offset = 0 /* Metadata: 0x00ADAA88 */) => default; // 0x0000000189410440-0x00000001894104D0
		public void PushIntPtr(IntPtr i) {} // 0x0000000189411090-0x0000000189411160
		public IntPtr GetIntPtr(int offset = 0 /* Metadata: 0x00ADAA8C */) => default; // 0x00000001894106D0-0x0000000189410810
		public void PushObject(object o) {} // 0x00000001894112D0-0x00000001894113D0
		public void PushValueType(object o) {} // 0x0000000189411840-0x0000000189411980
		public object GetObject(int offset = 0 /* Metadata: 0x00ADAA90 */) => default; // 0x0000000189410810-0x00000001894108A0
		public T GetAsType<T>(int offset = 0 /* Metadata: 0x00ADAA94 */) => default;
		public void PushObjectAsResult(object obj, System.Type type) {} // 0x0000000189411160-0x00000001894112D0
		public void PushRef(int offset) {} // 0x00000001894113D0-0x0000000189411460
		public void UpdateReference(int offset, object obj, VirtualMachine virtualMachine, System.Type type) {} // 0x0000000189411980-0x00000001894119B0
	}
}
